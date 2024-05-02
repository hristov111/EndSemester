using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemensterProject
{
    public class CircleDrawingStrategy : IDrawingStrategy
    {

        public int Radius { get; set; }

        public CircleDrawingStrategy(int radius)
        {
            Radius = radius;
        }

        public void DrawShape(Graphics g, Color FigureColor, Color Figure_outColor, int X, int Y)
        {
            // Create a brush with tahe same color for filling the circle
            using (Brush brush = new SolidBrush(FigureColor))
            {
                // Fill the circle with the color
                g.FillEllipse(brush, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            }
            // Create a pen with the same color for the outine
            using (Pen pen = new Pen(Figure_outColor,3))
            {
                // Draw the outline of the circle with the color
                g.DrawEllipse(pen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            }
        }
    }
}
