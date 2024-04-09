using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public class Rectangle:Figure
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public static int NextID = 0;
        public int ID { get; set; }
        [JsonConstructor]
        public Rectangle(int x, int y, Color figurecolor, Color figure_outcolor, int width, int height) : base(x, y, figurecolor, figure_outcolor)
        {
            this.Width = width;
            this.Height= height;
            ID = NextID++;
        }
        protected override double GetArea()
        {
            return Width * Height;
        }

        public override void DrawShape(Graphics g)
        {
            // Creating a brush to fill the rectangle
            using(Brush brush = new SolidBrush(FigureColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
            using (Pen pen = new Pen(Figure_outColor))
            {
                g.DrawRectangle(pen, X,Y,Width,Height);
            }

        }
        // HitTest method to check if a point is inside the rectangle
        public override bool HitTest(Point point)
        {
            // check if the point is whithin the bounds of the rectangle
            return point.X >= X && point.X <=X +Width && point.Y >= Y && point.Y <= Y + Height;
        }
        public override void ChangePos(int x, int y)
        {
            X = x; Y = y;
        }
    }
}
