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
           
            Color returnColor = instance.FigureColor == "red"
                ? Color.Red: instance.FigureColor == "blue"
                ? Color.Blue: instance.FigureColor == "yellow"
                ? Color.Yellow: instance.FigureColor == "green"
                ? Color.Green: Color.Black;
            return returnColor;
        }
        public static Color GetFigure_outColor(this Figure instance)
        {
            Color returnColor = instance.Figure_outColor == "red"
                 ? Color.Red : instance.Figure_outColor == "blue"
                 ? Color.Blue : instance.Figure_outColor == "yellow"
                 ? Color.Yellow : instance.Figure_outColor == "green"
                 ? Color.Green : Color.Black;
            return returnColor;
        }
    }
}
