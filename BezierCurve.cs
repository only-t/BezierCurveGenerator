using System.Collections.Generic;
using System.Drawing;

namespace BezierCurveGenerator
{
    internal class BezierCurve
    {
        private List<Point> points;

        public BezierCurve(Point p)
        {
            points = new List<Point>() { p };
        }

        public void AddControlPoint(Point p)
        {
            points.Add(p);
        }

        public void RemoveControlPoint(Point p)
        {
            points.Remove(p);
        }

        public List<Point> GetPoints()
        {
            return points;
        }
    }
}
