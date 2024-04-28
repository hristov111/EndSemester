using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EndSemensterProject;

namespace EndSemesterProject
{
    public class Triangle: Figure
    {
        public static int NextID = 0;
        public int ID { get; set; }
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        public PointF point1;
        public PointF point2;
        public PointF point3;

        [JsonConstructor]
        public Triangle(int x, int y, Color figurecolor,Color figure_outcolor,int firstSide, int secondSide, int thirdSide, IDrawingStrategy drawingStrategy, bool garbage = false) 
            : base(x, y, figurecolor, figure_outcolor, drawingStrategy)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
            if (!garbage)
            {
                ID = NextID++;
            }
            ChangePos(x,y);
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Triangle trig = (Triangle)obj;
            return this.FigureColor == trig.FigureColor &&
                this.Figure_outColor == trig.Figure_outColor &&
                this.FirstSide == trig.FirstSide &&
                this.SecondSide == trig.SecondSide &&
                this.ThirdSide == trig.ThirdSide;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FigureColor,Figure_outColor,FirstSide,SecondSide,ThirdSide);
        }
        public override void ChangePos(int x, int y)
        {
            X = x; Y = y;
            point1 = new PointF(X, Y);
            point2 = new PointF(X+FirstSide, Y);
            double h = 2 * GetArea() / FirstSide;
            point3 = new PointF(X + FirstSide/2, Y-(float)h);
        }
        protected override double GetArea()
        {
            // Calculate the height 'h' using Heron's formula and the area formula
            float s = (FirstSide + SecondSide + ThirdSide) /2; // semi perimeter
            double area = Math.Sqrt(s * (s-FirstSide) * (s-SecondSide) * (s-ThirdSide));
            return area;
        }
        private double Area(PointF p1, PointF p2, PointF p3)
        {
            return Math.Abs((p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2.0);
        }
        public override bool HitTest(Point point)
        {
            // Calculate the area of the main triagle
            double mainArea = Area(point1, point2, point3);

            // Calculate the areas of the three sub-triangles
            double area1 = Area(point, point2, point3);
            double area2 = Area(point1, point, point3);
            double area3 = Area(point1,point2, point);

            // if the sum of the three sub-triangles areas  is equal to the main triangle's area, the point is inside 
            return Math.Abs(mainArea - (area1 + area2 + area3)) < 0.01;

        }
    }
}
