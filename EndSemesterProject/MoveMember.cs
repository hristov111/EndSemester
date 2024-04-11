using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemensterProject
{
    internal class MoveMember:ICommand
    {
        private Form1 Instance;
        public MoveMember(Form1 instance) { this.Instance = instance; }

        public void StartMove(MouseEventArgs e)
        {
            if (Instance.currentMode == "Move")
            {
                for (int i = Instance.figures.Count - 1; i >= 0; i--)
                {
                    if (Instance.figures[i].HitTest(new Point(e.X, e.Y)))
                    {
                        Instance.draggingShape = Instance.figures[i];
                        Instance.DragStart = new Point(e.X - Instance.figures[i].X, e.Y - Instance.figures[i].Y);
                        Instance.redo_undo.Set_ValueMove(Instance.draggingShape, new Point(Instance.figures[i].X, Instance.figures[i].Y));
                        break;
                    }
                }
            }
        }
        public void Execute(MouseEventArgs e)
        {
            if (Instance.draggingShape != null)
            {
                Instance.draggingShape.ChangePos(e.X - Instance.DragStart.X, e.Y - Instance.DragStart.Y);
                Point current_point = new Point(e.X - Instance.DragStart.X, e.Y - Instance.DragStart.Y);
                Instance.redo_undo.Set_ValueMove(Instance.draggingShape,current_point);
                
                Instance.Invalidate();
            }
            foreach (Figure fig in Instance.figures)
            {
                if (fig.HitTest(new Point(e.X, e.Y)))
                {
                    if (Instance.Cursor != Cursors.Hand)
                    {
                        Instance.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        if (Instance.Cursor != Cursors.Default)
                        {
                            Instance.Cursor = Cursors.Default;
                        }
                    }
                }
            }
        }
    }
}
