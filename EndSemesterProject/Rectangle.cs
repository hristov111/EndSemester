using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    internal class Rectangle:Figure
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, Color color, Color outline, int width, int height) : base(x, y, color, outline)
        {
            this.Width = width;
            this.Height= height;
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
    }
}
