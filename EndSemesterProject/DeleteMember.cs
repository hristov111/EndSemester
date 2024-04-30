using EndSemesterProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures; 

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
                var indexToRemove = Instance.figures.Select((fig, idx) => new { Figure = fig, Index = idx, HitTestPassed = fig.HitTest(e.X, e.Y) }).Where(x => x.HitTestPassed == true).Select(x => x.Index).ToList();
                indexToRemove.ForEach(tp=>
                {
                    Instance.redo_undo.Set_ValuesCreateDelete(Instance.figures[tp], tp, "Create");
                    Instance.figures.RemoveAt(tp);
                    if (tp != Instance.figures.Count)
                    {
                        Instance.ChangeInidces(Instance.figures[tp].GetType(), tp, true);
                    }
                    Instance.Invalidate();
                });
            }
        }
    }
}
