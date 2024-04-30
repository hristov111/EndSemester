using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace EndSemensterProject
{
    public class Draw
    {
        public void Draw_shape(Graphics g,Figure fg)
        {
            if(fg is Circle)
            {
                Circle circ = (Circle)fg;
                IDrawingStrategy strategy = new CircleDrawingStrategy(circ.Radius);
                strategy.DrawShape(g,fg.GetFigureColor(), fg.GetFigure_outColor(), fg.X,fg.Y);
            }
            else if(fg is Triangle)
            {
                Triangle triangle = (Triangle)fg;
                IDrawingStrategy strategy = new TriangleDrawingStrategy(triangle.point1, triangle.point2, triangle.point3);
                strategy.DrawShape(g, fg.GetFigureColor(), fg.GetFigure_outColor(), fg.X,fg.Y);
            }
            else if(fg is Figures.Rectangle)
            {
                Figures.Rectangle rectangle = (Figures.Rectangle)fg;
                IDrawingStrategy strategy = new RectangleDrawingStrategy(rectangle.Height, rectangle.Width);
                strategy.DrawShape(g, fg.GetFigureColor(), fg.GetFigure_outColor(), fg.X, fg.Y);
            }
            
        }
    }
}
