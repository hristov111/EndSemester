using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

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
                var shape = Instance.figures.Where(figure => figure.HitTest(e.X, e.Y) == true).FirstOrDefault();
                if (shape != default(Figure)) 
                {
                    Instance.draggingShape = shape;
                    Instance.DragStart = new Point(e.X - shape.X, e.Y - shape.Y);
                    Instance.redo_undo.Set_ValueMove(Instance.draggingShape, new Point(shape.X, shape.Y));
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
            var bool1 = Instance.figures.Where(fig => fig.HitTest(e.X,e.Y) == true).ToList().Any();
            if (bool1)
            {
                Instance.Cursor = Instance.Cursor != Cursors.Hand?Cursors.Hand:Instance.Cursor != Cursors.Default?Cursors.Default:Cursors.No;
            }


        }
    }
}
