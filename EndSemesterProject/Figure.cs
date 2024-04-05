using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    internal abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color FigureColor { get; set; }
        public Color Figure_outColor { get; set; }

        static private int numberofFigures=0;
        public Figure(int x, int y,Color color, Color outline)
        {
            this.X = x;
            this.Y = y;
            this.FigureColor = color;
            this.Figure_outColor = outline;
            numberofFigures++;
        }

        protected abstract double GetArea();

        public abstract void DrawShape(Graphics g);
    }
}
