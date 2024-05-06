using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace EndSemensterProject
{
    public class CreateMember:ICommand
    {
        private Form1 Instance;

        public CreateMember(Form1 instance)
        {
            this.Instance = instance;
            
        }
        public void Execute(MouseEventArgs e)
        {
            if (Instance.currentMode == "Create" &&  Instance.currentColor != null)
            {
                if (Instance.current_option == "Rectangle")
                {
                    Instance.currentFigure = new Figures.Rectangle(e.X, e.Y, Instance.currentColor, Instance.currentOutColor, Instance.Rect_Width, Instance.Rect_Height);
                }
                else if (Instance.current_option == "Triangle")
                {
                    Instance.currentFigure = new Triangle(e.X, e.Y, Instance.currentColor, Instance.currentOutColor, Instance.Triangle_Side1, Instance.Triangle_Side2, Instance.Triangle_Side3);
                }
                else if (Instance.current_option == "Circle")
                {
                    Instance.currentFigure = new Circle(e.X, e.Y, Instance.currentColor, Instance.currentOutColor, Instance.Circle_Radius);
                }
                Instance.figures.Add(Instance.currentFigure);
                Instance.colors.Add(Instance.currentFigure.FigureColor);
                Instance.outline_colors.Add(Instance.currentFigure.Figure_outColor);
                int idx = Instance.figures.Count - 1;
                Instance.redo_undo.Set_ValuesCreateDelete(Instance.currentFigure,idx, "Delete");
                Instance.Invalidate();
            }
        }

    }
}
