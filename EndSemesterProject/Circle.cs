using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public class Circle:Figure
    {
        public int Radius { get; set; }
        public static int NextID = 0;
        public int ID { get; set; }

        public Circle(int x, int y,Color color,Color outline, int radius) :base(x,y,color,outline)
        {
            this.Radius = radius;
            ID = NextID++;
        }

        protected override double GetArea()
        {
            return Math.PI * Radius * Radius;       
        }
        public override void DrawShape(Graphics g)
        {
            // Create a brush with tahe same color for filling the circle
            using(Brush brush = new SolidBrush(FigureColor)) 
            {
                // Fill the circle with the color
                g.FillEllipse(brush, X - Radius, Y-Radius, 2*Radius, 2*Radius);
            }
            // Create a pen with the same color for the outine
            using (Pen pen = new Pen(Figure_outColor))
            {
                // Draw the outline of the circle with the color
                g.DrawEllipse(pen, X - Radius, Y-Radius, 2*Radius, 2*Radius);
            }
        }
        public override bool HitTest(Point point)
        {
            // Calculate the distance from the point to the circle's center
            double distance = Math.Sqrt((point.X - X) * (point.X - X) + (point.Y - Y) * (point.Y-Y));

            // if the distance is less than or equal to the radius, the point is inside the cirle
            return distance < Radius;
        }
        public override void ChangePos(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }
    }
}
