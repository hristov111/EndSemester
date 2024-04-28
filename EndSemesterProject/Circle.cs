using EndSemensterProject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public class Circle:Figure
    {
        public int Radius { get; set; }
        public static int NextID = 0;
        public int ID { get; set; }
        [JsonConstructor]
        public Circle(int x, int y,Color figurecolor,Color figure_outcolor, int radius,IDrawingStrategy drawingStrategy, bool garbage = false) 
            :base(x,y,figurecolor,figure_outcolor, drawingStrategy)
        {
            this.Radius = radius;
            if (!garbage)
            {
                ID = NextID++;
            }
        }

        public override bool Equals(object? obj)
        {
            if(obj == null || GetType() != obj.GetType())
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
            return HashCode.Combine(FigureColor, Figure_outColor,Radius);
        }

        protected override double GetArea()
        {
            return Math.PI * Radius * Radius;       
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
