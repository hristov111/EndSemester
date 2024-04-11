using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemensterProject
{
    internal class DeleteMember:ICommand
    {
        private Form1 Instance;
        public DeleteMember(Form1 instance) { Instance = instance; }

        public void Execute(MouseEventArgs e)
        {
            if (Instance.currentMode == "Delete")
            {
                for (int i = Instance.figures.Count - 1; i >= 0; i--)
                {
                    if (Instance.figures[i].HitTest(new Point(e.X, e.Y)))
                    {
                        Instance.redo_undo.Set_ValuesCreateDelete(Instance.figures[i], i, "Delete");
                        Instance.figures.Remove(Instance.figures[i]);
                        if (i != Instance.figures.Count)
                        {
                            Instance.ChangeInidces(Instance.figures[i], i, true);
                        }
                        Instance.Invalidate();
                        break;


                    }
                }
            }
        }
    }
}
