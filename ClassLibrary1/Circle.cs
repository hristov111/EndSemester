using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure
    {
        public int Radius { get; set; }
        public static int NextID = 0;

        public Circle() { }
        public Circle(int x, int y, string figurecolor, string figure_outcolor, int radius, bool garbage = false)
            : base(x, y, figurecolor, figure_outcolor)
        {
            this.Radius = radius;
            if (!garbage)
            {
                ID = NextID++;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Circle other = (Circle)obj;
            return this.Radius == other.Radius &&
                this.FigureColor == other.FigureColor &&
                this.Figure_outColor == other.Figure_outColor;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FigureColor, Figure_outColor, Radius);
        }

        protected override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override bool HitTest(int x, int y)
        {
            // Calculate the distance from the point to the circle's center
            double distance = Math.Sqrt((x - X) * (x - X) + (y - Y) * (y - Y));

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
