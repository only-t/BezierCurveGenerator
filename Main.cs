using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BezierCurveGenerator
{
    public enum ACTION_TYPE
    {
        ADD_POINT,
        REMOVE_POINT,
        MOVE_POINT
    }

    public partial class Main : Form
    {
        private List<Point> points = new List<Point>();
        private ACTION_TYPE actType;
        private const int BASE_RESOLUTION = 100;
        private const int MAX_POINTS = 8;

        public Main()
        {
            InitializeComponent();
            this.MinimumSize = new Size(550, 400);
            this.ActionTypeBtn.SelectedIndex = 0;
            this.actType = ACTION_TYPE.ADD_POINT;
        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            if(this.actType == ACTION_TYPE.ADD_POINT && this.points.Count < MAX_POINTS)
            {
                points.Add(new Point(mouseEventArgs.X, mouseEventArgs.Y));

                Bitmap btm = GenerateImage();
                this.MainPictureBox.Image = btm;
            }
        }

        private void ActionTypeBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is ComboBox comboBox)
            {
                this.actType = (ACTION_TYPE)comboBox.SelectedIndex;
            }
        }

        private int ComputeBinomial(int n, int k)
        {
            if(k > n)
            {
                return 0;
            }

            if(k == 0 || k == n)
            {
                return 1;
            }

            return ComputeBinomial(n - 1, k - 1) + ComputeBinomial(n - 1, k);
        }

        private Bitmap GenerateImage()
        {
            Bitmap bitmap = new Bitmap(this.MainPictureBox.Width, this.MainPictureBox.Height);
            Color black = Color.Black;

            foreach (Point p in this.points)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        try
                        {
                            bitmap.SetPixel(p.X + i, p.Y + j, black);
                        } catch (ArgumentOutOfRangeException) { }
                    }
                }
            }

            int order = this.points.Count - 1;

            switch(order)
            {
                case 0:
                    return bitmap;
                case 1:

                    return bitmap;
                default:
                    break;
            }

            int resolution = BASE_RESOLUTION * (order / 2);
            Console.WriteLine(resolution);  
            for (double i = 0; i <= resolution; i++)
            {
                double x = 0, y = 0;

                for (int j = 0; j <= order; j++)
                {
                    int binomial = ComputeBinomial(order, j);
                    double t = i / resolution;
                    x += binomial * Math.Pow(1 - t, order - j) * Math.Pow(t, j) * this.points[j].X;
                    y += binomial * Math.Pow(1 - t, order - j) * Math.Pow(t, j) * this.points[j].Y;
                }

                bitmap.SetPixel((int)x, (int)y, black);
            }

            return bitmap;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.points.Clear();
            this.MainPictureBox.Image = new Bitmap(this.MainPictureBox.Width, this.MainPictureBox.Height);
        }
    }
}
