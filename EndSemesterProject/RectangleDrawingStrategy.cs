using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace EndSemensterProject
{
    public class RectangleDrawingStrategy: IDrawingStrategy
    {
        private int Height { get; set; }
        private int Width { get; set; }

        public RectangleDrawingStrategy(int height, int width)
        {
            Height = height;
            Width = width;
        }
        
        public void DrawShape(Graphics g, Color FigureColor,Color Figure_outColor, int X, int Y)
        {
            using (Brush brush = new SolidBrush(FigureColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
            using (Pen pen = new Pen(Figure_outColor))
            {
                g.DrawRectangle(pen, X, Y, Width, Height);
            }
        }
    }
}
