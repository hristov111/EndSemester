using EndSemensterProject;
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
        protected IDrawingStrategy DrawingStrategy;
        public int X { get; set; }
        public int Y { get; set; }
        public Color FigureColor { get; set; }
        public Color Figure_outColor { get; set; }

        [JsonConstructor]
        public Figure(int x, int y,Color figurecolor, Color figure_outcolor, IDrawingStrategy drawingStrategy = null)
        {
            this.DrawingStrategy = drawingStrategy;
            this.X = x;
            this.Y = y;
            this.FigureColor = figurecolor;
            this.Figure_outColor = figure_outcolor;
        }

        protected abstract double GetArea();

        public void DrawShape(Graphics g)
        {
            DrawingStrategy.DrawShape(g,FigureColor, Figure_outColor, X,Y );
        }
        public abstract bool HitTest(Point point);
        public abstract void ChangePos(int newX, int newY);
    }
}
