using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    internal class Move:Form1
    {
        public Move() { }

        public void StartMove(MouseEventArgs e)
        {
            if(currentMode == "Move")
            {
                for (int i = figures.Count - 1; i >= 0; i--)
                {
                    if (figures[i].HitTest(new Point(e.X, e.Y)))
                    {
                        draggingShape = figures[i];
                        DragStart = new Point(e.X - figures[i].X, e.Y - figures[i].Y);
                        redo_undo.undo_point.Push(new Point(figures[i].X, figures[i].Y));
                        redo_undo.undo_modes.Push("Move");
                        redo_undo.undo.Push(draggingShape);
                        break;
                    }
                }
            }
        }
        public void Moving(MouseEventArgs e)
        {
            if (draggingShape != null)
            {
                draggingShape.ChangePos(e.X - DragStart.X, e.Y - DragStart.Y);
                Point current_point = new Point(e.X - DragStart.X, e.Y - DragStart.Y);
                if (redo_undo.undo_point.Count != 0)
                {
                    Point previous_point = redo_undo.undo_point.Peek();
                    if (Math.Abs((previous_point.X + previous_point.Y) - (current_point.X + current_point.Y)) > 20)
                    {
                        redo_undo.undo_point.Push(current_point);
                        redo_undo.undo_modes.Push("Move");
                        redo_undo.undo.Push(draggingShape);
                    }
                }
                else
                {
                    redo_undo.undo_point.Push(current_point);
                    redo_undo.undo_modes.Push("Move");
                    redo_undo.undo.Push(draggingShape);
                }
                Invalidate();
            }
            foreach (Figure fig in figures)
            {
                if (fig.HitTest(new Point(e.X, e.Y)))
                {
                    if (this.Cursor != Cursors.Hand)
                    {
                        this.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        if (this.Cursor != Cursors.Default)
                        {
                            this.Cursor = Cursors.Default;
                        }
                    }
                }
            }
        }
    }
}
