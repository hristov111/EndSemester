using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemensterProject
{
    public class TriangleDrawingStrategy : IDrawingStrategy
    {
        public PointF point1 { get; set; }
        public PointF point2 { get; set; }
        public PointF point3 { get; set; }
        public TriangleDrawingStrategy() { }
        public void DrawShape(Graphics g, Color FigureColor, Color Figure_outColor, int X, int Y)
        {
            PointF[] trianglePoints = { point1, point2, point3 };
            // Creating a brush to fill the rectangle
            using (Brush brush = new SolidBrush(FigureColor))
            {
                g.FillPolygon(brush, trianglePoints);
            }
            using (Pen pen = new Pen(Figure_outColor))
            {
                g.DrawLine(pen, point1, point2);
                g.DrawLine(pen, point2, point3);
                g.DrawLine(pen, point1, point2);
            }
        }
    }
}
