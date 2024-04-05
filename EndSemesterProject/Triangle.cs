using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    internal class Triangle: Figure
    {
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        private PointF point1;
        private PointF point2;


        public Triangle(int x, int y, Color color,Color outline,int firstSide, int secondSide, int thirdSide) : base(x, y, color,outline)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
            point1 = new PointF(X, Y);
            point2 = new PointF(X+firstSide, Y);
        }
        protected override double GetArea()
        {
            // Calculate the height 'h' using Heron's formula and the area formula
            float s = (FirstSide + SecondSide + ThirdSide) /2; // semi perimeter
            double area = Math.Sqrt(s * (s-FirstSide) * (s-SecondSide) * (s-ThirdSide));
            return area;
        }

        public override void DrawShape(Graphics g)
        {
            double h = 2 * GetArea() / FirstSide;
            PointF point3 = new PointF(X + FirstSide/2, Y-(float)h);
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
                g.DrawLine(pen, point3,point1);
            }

        }
    }
}
