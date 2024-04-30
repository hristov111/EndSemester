using EndSemesterProject;
using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemensterProject
{
    public class TriangleDrawingStrategy : IDrawingStrategy
    {
        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }
        public PointF Point3 { get; set; }
        public TriangleDrawingStrategy(Triangle.Points point1, Triangle.Points point2, Triangle.Points point3) 
        {
            this.Point1 = new PointF(point1.X, point1.Y);
            this.Point2 = new PointF(point2.X, point2.Y);
            this.Point3 = new PointF(point3.X, point3.Y);
        }
        public void DrawShape(Graphics g, Color FigureColor, Color Figure_outColor, int X, int Y)
        {
            PointF[] trianglePoints = {Point1, Point2, Point3 };
            // Creating a brush to fill the rectangle
            using (Brush brush = new SolidBrush(FigureColor))
            {
                g.FillPolygon(brush, trianglePoints);
            }
            using (Pen pen = new Pen(Figure_outColor))
            {
                g.DrawLine(pen, Point1, Point2);
                g.DrawLine(pen, Point1, Point2);
                g.DrawLine(pen, Point1, Point2);
            }
        }
    }
}
