using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace EndSemensterProject
{
    public static class ColorExtention
    {

        public static Color GetFigureColor(this Figure instance)
        {
            if(instance.FigureColor == "red")
            {
                return Color.Red;
            }
            else if(instance.FigureColor == "blue")
            {
                return Color.Blue;
            }
            else if( instance.FigureColor == "yellow")
            {
                return Color.Yellow;
            }
            else if(instance.FigureColor == "green")
            {
                return Color.Green;
            }
            return Color.Black;
        }
        public static Color GetFigure_outColor(this Figure instance)
        {
            if (instance.Figure_outColor == "red")
            {
                return Color.Red;
            }
            else if (instance.Figure_outColor == "blue")
            {
                return Color.Blue;
            }
            else if (instance.Figure_outColor == "yellow")
            {
                return Color.Yellow;
            }
            else if (instance.Figure_outColor == "green")
            {
                return Color.Green;
            }
            return Color.Black;
        }
    }
}
