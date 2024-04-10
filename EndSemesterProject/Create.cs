using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    internal class Create:Form1
    {
        public Create()
        {
        }
        public void CreateFigure(Type figure, Color current_color,Point formPos)
        {
            Figure newFigure = (Figure)Activator.CreateInstance(figure, formPos.X, formPos.Y, current_color, Rect_outColor, Rect_Width, Rect_Height);
            currentFigure =  newFigure;
        }
        public void On_mouse_Click()
        {
            if (currentFigure is Rectangle)
            {
                create_Rectangle_Click(create_Rectangle, EventArgs.Empty);
            }
            else if (currentFigure is Triangle)
            {
                create_Triangle_Click(create_Triangle, EventArgs.Empty);
            }
            else if (currentFigure is Circle)
            {
                create_circle_Click(create_circle, EventArgs.Empty);
            }
            redo_undo.undo_modes.Push("Create");
            redo_undo.undo.Push(currentFigure);
            figures.Add(currentFigure);
            redo_undo.undo_indices.Push(figures.IndexOf(currentFigure));
            Invalidate();
        }
    }
}
