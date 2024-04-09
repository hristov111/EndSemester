using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color FigureColor { get; set; }
        public Color Figure_outColor { get; set; }

        [JsonConstructor]
        public Figure(int x, int y,Color figurecolor, Color figure_outcolor)
        {
            this.X = x;
            this.Y = y;
            this.FigureColor = figurecolor;
            this.Figure_outColor = figure_outcolor;
        }

        protected abstract double GetArea();

        public abstract void DrawShape(Graphics g);
        public abstract bool HitTest(Point point);
        public abstract void ChangePos(int newX, int newY);
    }
}
