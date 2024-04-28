using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;   

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
            if (Instance.currentMode == "Create" && Instance.currentColor != Color.Empty)
            {
                if (Instance.current_option == "Rectangle")
                {
                    Instance.currentFigure = new EndSemesterProject.Rectangle(e.X, e.Y, Instance.currentColor, Instance.Rect_outColor, Instance.Rect_Width, Instance.Rect_Height, new RectangleDrawingStrategy(Instance.Height, Instance.Width));
                }
                else if (Instance.current_option == "Triangle")
                {
                    IDrawingStrategy strateg = new TriangleDrawingStrategy();
                    Instance.currentFigure = new Triangle(e.X, e.Y, Instance.currentColor, Instance.Triangle_outColor, Instance.Triangle_Side1, Instance.Triangle_Side2, Instance.Triangle_Side3,strateg);
                    TriangleDrawingStrategy triangleStrategy = (TriangleDrawingStrategy)strateg;
                    Triangle trig = (Triangle)Instance.currentFigure;
                    triangleStrategy.point1 = trig.point1;
                    triangleStrategy.point2 = trig.point2;
                    triangleStrategy.point3 = trig.point3;
                }
                else if (Instance.current_option == "Circle")
                {
                    Instance.currentFigure = new Circle(e.X, e.Y, Instance.currentColor, Instance.Circle_outColor, Instance.Circle_Radius, new CircleDrawingStrategy(Instance.Circle_Radius));
                }
                Instance.figures.Add(Instance.currentFigure);
                int idx = Instance.figures.Count - 1;
                Instance.redo_undo.Set_ValuesCreateDelete(Instance.currentFigure,idx, "Delete");
                Instance.Invalidate();
            }
        }

    }
}
