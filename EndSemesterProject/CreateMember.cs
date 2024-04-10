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
    class CreateMember:ICommand
    {
        private Form1 Instance;
        public CreateMember(Form1 instance)
        {
            this.Instance = instance;
        }
        public void CreateFigure(Type figure, Color current_color, Point formPos)
        {
            // in the last minute found a mistake here i need to correct
            Figure newFigure = (Figure)Activator.CreateInstance(figure, formPos.X, formPos.Y, current_color, Instance.Rect_outColor, Instance.Rect_Width, Instance.Rect_Height);
            Instance.currentFigure = newFigure;
        }
        public void Execute(MouseEventArgs e)
        {
            if (Instance.currentMode == "Create")
            {
                if (Instance.currentFigure.GetType().Name == "Rectangle")
                {
                    Instance.create_Rectangle_Click(Instance.create_Rectangle, EventArgs.Empty);
                }
                else if (Instance.currentFigure is Triangle)
                {
                    Instance.create_Triangle_Click(Instance.create_Triangle, EventArgs.Empty);
                }
                else if (Instance.currentFigure is Circle)
                {
                    Instance.create_circle_Click(Instance.create_circle, EventArgs.Empty);
                }
                Instance.redo_undo.undo_modes.Push("Create");
                Instance.redo_undo.undo.Push(Instance.currentFigure);
                Instance.figures.Add(Instance.currentFigure);
                Instance.redo_undo.undo_indices.Push(Instance.figures.IndexOf(Instance.currentFigure));
                Instance.Invalidate();
            }
        }

    }
}
