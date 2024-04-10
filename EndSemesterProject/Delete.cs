using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    class Delete:Form1
    {
        public Delete() { }

        public void Delete_type(MouseEventArgs e)
        {
            for (int i = figures.Count -1; i>=0; i--)
            {
                if (figures[i].HitTest(new Point(e.X, e.Y)))
                {
                    redo_undo.undo_modes.Push("Delete");
                    redo_undo.undo.Push(figures[i]);
                    redo_undo.undo_indices.Push(i);
                    figures.Remove(figures[i]);
                    ChangeInidces(figures[i], i, true);
                    this.Invalidate();
                    break;

                }
            }
        }
    }
}
