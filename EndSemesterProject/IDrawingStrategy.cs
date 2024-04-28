using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemensterProject
{
    public interface IDrawingStrategy
    {
        void DrawShape(Graphics g, Color FigureColor, Color Figure_outColor, int X, int Y);

    }
}
