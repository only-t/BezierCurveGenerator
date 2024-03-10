using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BezierCurveGenerator
{
    public enum ACTION_TYPE
    {
        ADD_CURVE,
        ADD_POINT,
        REMOVE_POINT
    }

    public partial class Main : Form
    {
        private const int BASE_RESOLUTION = 300;
        private const int MAX_POINTS = 8;
        private const int POINT_SELECT_RADIUS = 2;

        private readonly Color endPointColor = Color.FromKnownColor(KnownColor.Black);
        private readonly Color midPointColor = Color.FromKnownColor(KnownColor.Gray);
        private readonly Color toRemovePointColor = Color.FromKnownColor(KnownColor.Red);
        private readonly Color curveColor = Color.FromKnownColor(KnownColor.Black);
        private readonly Color skeletonLineColor = Color.FromKnownColor(KnownColor.Gray);

        private List<BezierCurve> curves = new List<BezierCurve>();
        private ACTION_TYPE actType;
        private BezierCurve currentCurve;
        private Point dummyP = new Point(0, 0); // ?
        private Point selectedPoint;

        public Main()
        {
            InitializeComponent();
            MinimumSize = new Size(550, 400);
            ActionTypeBtn.SelectedIndex = 0;
            actType = ACTION_TYPE.ADD_CURVE;
            MaxPointsLabel.Text = "Max points amount: " + MAX_POINTS.ToString();
            selectedPoint = dummyP;
        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            switch(actType)
            {
                case ACTION_TYPE.ADD_CURVE:
                    if(selectedPoint != dummyP)
                    {
                        return;
                    }
                    curves.Add(new BezierCurve(new Point(mouseEventArgs.X, mouseEventArgs.Y)));
                    CurveChooseBtn.Enabled = true;
                    CurveChooseBtn.Items.Add("Curve #" + curves.Count);
                    CurveChooseBtn.SelectedIndex = curves.Count - 1;

                    UpdateImage();

                    break;
                case ACTION_TYPE.ADD_POINT:
                    if(currentCurve == null || selectedPoint != dummyP)
                    {
                        return;
                    }

                    if(currentCurve.GetPoints().Count < MAX_POINTS)
                    {
                        currentCurve.AddControlPoint(new Point(mouseEventArgs.X, mouseEventArgs.Y));
                        UpdateImage();
                    }

                    break;
                case ACTION_TYPE.REMOVE_POINT:
                    if(currentCurve == null || selectedPoint == dummyP)
                    {
                        return;
                    }

                    bool removed = false;
                    for(int i = 0; i < curves.Count; i++)
                    {
                        BezierCurve c = curves[i];
                        List<Point> pts = c.GetPoints();
                        foreach(Point p in pts)
                        {
                            if(p == selectedPoint)
                            {
                                pts.Remove(p);
                                removed = true;

                                break;
                            }
                        }

                        if(removed)
                        {
                            if(pts.Count <= 0)
                            {
                                curves.Remove(c);

                                CurveChooseBtn.Items.Clear();
                                if (curves.Count <= 0)
                                {
                                    CurveChooseBtn.SelectedIndex = -1;
                                    CurveChooseBtn.Enabled = false;
                                } else
                                {
                                    for (int j = 1; j <= curves.Count; j++)
                                    {
                                        CurveChooseBtn.Items.Add("Curve #" + j);
                                    }

                                    CurveChooseBtn.SelectedIndex = curves.Count - 1;
                                }
                            }

                            break;
                        }
                    }

                    UpdateImage();

                    break;
            }
        }

        private void ActionTypeBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is ComboBox comboBox)
            {
                actType = (ACTION_TYPE)comboBox.SelectedIndex;
            }
        }

        private void LoadFromFile(Stream input)
        {
            if(curves.Count > 0)
            {
                ClearCurves();
            }

            using (StreamReader reader = new StreamReader(input))
            {
                try
                {
                    int curveAmount = int.Parse(reader.ReadLine());
                    for(int i = 0; i < curveAmount; i++)
                    {
                        int order = int.Parse(reader.ReadLine());
                        BezierCurve curve = null;

                        for(int j = 0; j <= order; j++)
                        {
                            string[] ints = reader.ReadLine().Split();
                            Point p = new Point(int.Parse(ints[0]), int.Parse(ints[1]));

                            if(curve == null)
                            {
                                curve = new BezierCurve(p);
                            } else
                            {
                                curve.AddControlPoint(p);
                            }
                        }

                        curves.Add(curve);

                        if(!CurveChooseBtn.Enabled)
                        {
                            CurveChooseBtn.Enabled = true;
                        }

                        CurveChooseBtn.Items.Add("Curve #" + curves.Count);
                    }

                    CurveChooseBtn.SelectedIndex = curveAmount - 1;
                } catch(FormatException)
                {
                    MessageBox.Show("Cannot load the file!", "Error!", MessageBoxButtons.OK);
                    return;
                }

                UpdateImage();
            }
        }

        private int BinomialCoefficient(int n, int k)
        {
            if(k > n)
            {
                return 0;
            }

            if(k == 0 || k == n)
            {
                return 1;
            }

            return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
        }

        private void DrawLine(Bitmap bitmap, Point p1, Point p2, Color c)
        {
            int x0 = p1.X, y0 = p1.Y;
            int x1 = p2.X, y1 = p2.Y;
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (;;)
            {
                bitmap.SetPixel(x0, y0, c);
                if (x0 == x1 && y0 == y1)
                {
                    break;
                }

                e2 = err;

                if (e2 > -dx)
                {
                    err -= dy; x0 += sx;
                }

                if (e2 < dy)
                {
                    err += dx; y0 += sy;
                }
            }
        }

        private Bitmap GenerateImage()
        {
            Bitmap bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);

            // Draw curve
            foreach (BezierCurve c in curves)
            {
                List<Point> pts = c.GetPoints();

                int order = pts.Count - 1;
                bool drawCurve = false;
                switch (order)
                {
                    case 0:
                        break;
                    case 1:
                        DrawLine(bitmap, pts[0], pts[1], curveColor);
                        break;
                    default:
                        drawCurve = true;
                        break;
                }

                if(drawCurve)
                {
                    int resolution = BASE_RESOLUTION * (order / 2);
                    for (double i = 0; i <= resolution; i++)
                    {
                        double x = 0, y = 0;

                        for (int j = 0; j <= order; j++)
                        {
                            int binomial = BinomialCoefficient(order, j);
                            double t = i / resolution;
                            x += binomial * Math.Pow(1 - t, order - j) * Math.Pow(t, j) * pts[j].X;
                            y += binomial * Math.Pow(1 - t, order - j) * Math.Pow(t, j) * pts[j].Y;
                        }

                        bitmap.SetPixel((int)x, (int)y, curveColor);
                    }
                }

                for (int i = 0; i < pts.Count; i++)
                {
                    // Draw curve skeleton
                    if (DrawSkelCheck.Checked && i > 0 && order > 1)
                    {
                        DrawLine(bitmap, pts[i], pts[i - 1], skeletonLineColor);
                    }

                    // Draw points
                    if(i != 0 && i != pts.Count - 1 && !DrawControlPointsCheck.Checked)
                    {
                        continue;
                    }

                    int pSize = 1;
                    Color pColor = midPointColor;

                    if (i == 0 || i == pts.Count - 1)
                    {
                        pSize++;
                        pColor = endPointColor;
                    }

                    if (pts[i] == selectedPoint)
                    {
                        pSize++;

                        if(actType == ACTION_TYPE.REMOVE_POINT)
                        {
                            pColor = toRemovePointColor;
                        }
                    }

                    for (int x = -pSize; x <= pSize; x++)
                    {
                        for (int y = -pSize; y <= pSize; y++)
                        {
                            bitmap.SetPixel(
                                Math.Min(Math.Max(pts[i].X + x, 0), MainPictureBox.Width),
                                Math.Min(Math.Max(pts[i].Y + y, 0), MainPictureBox.Height),
                                pColor);
                        }
                    }
                }
            }

            return bitmap;
        }

        private void UpdateImage()
        {
            if(MainPictureBox.Image != null)
            {
                MainPictureBox.Image.Dispose();
            }
            Bitmap btm = GenerateImage();
            MainPictureBox.Image = btm;
        }

        private void ClearCurves()
        {
            curves.Clear();
            CurveChooseBtn.Items.Clear();
            CurveChooseBtn.Enabled = false;
            CurveChooseBtn.SelectedIndex = -1;
            currentCurve = null;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Caution!", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                ClearCurves();
                MainPictureBox.Image = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
            }
        }

        private void CurveChooseBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCurve = curves[CurveChooseBtn.SelectedIndex];
        }

        private void DrawSkelCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            int mX = e.X;
            int mY = e.Y;
            foreach(BezierCurve c in curves)
            {
                foreach(Point p in c.GetPoints())
                {
                    if(p.X >= mX - POINT_SELECT_RADIUS &&
                        p.X <= mX + POINT_SELECT_RADIUS &&
                        p.Y >= mY - POINT_SELECT_RADIUS &&
                        p.Y <= mY + POINT_SELECT_RADIUS)
                    {
                        selectedPoint = p;
                        UpdateImage();

                        return;
                    }
                }
            }

            selectedPoint = dummyP;
            UpdateImage();
        }

        private void DrawControlPointsCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "Select a file",
                Filter = "BPT files (*.bpt)|*.bpt|Text files (*.txt)|*.txt",
                Title = "Open file"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream input = dialog.OpenFile())
                    {
                        LoadFromFile(input);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}", "Error!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
