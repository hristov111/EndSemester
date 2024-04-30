using EndSemesterProject;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace EndSemensterProject
{
    internal class EditMember:ICommand
    {
        private Form1 Instance;

        public EditMember(Form1 instance)
        {
            Instance = instance;
        }

        public void Execute(MouseEventArgs e)
        {
            if (Instance.currentMode == "Edit")
            {
                var current_Fig = Instance.figures.Where(figure => figure.HitTest(e.X,e.Y) == true).FirstOrDefault();
                if (current_Fig != default(Figure))
                {
                    if (current_Fig is Triangle)
                    {
                        Triangle curr_trig = current_Fig as Triangle;
                        SingleTriangle trig_edit = new SingleTriangle(Instance.redo_undo,curr_trig, curr_trig.FigureColor, curr_trig.Figure_outColor, curr_trig.FirstSide, curr_trig.SecondSide, curr_trig.ThirdSide, curr_trig.ID);
                        trig_edit.ShowDialog();
                        Instance.Invalidate();
                    }
                    else if (current_Fig.GetType().Name == "Rectangle")
                    {
                        Figures.Rectangle curr_rect = current_Fig as Figures.Rectangle;
                        SingleRectangle rect_edit = new SingleRectangle(Instance.redo_undo,curr_rect, curr_rect.FigureColor, curr_rect.Figure_outColor, curr_rect.Width, curr_rect.Height, curr_rect.ID);
                        rect_edit.ShowDialog();
                        Instance.Invalidate();
                    }
                    else if (current_Fig is Circle)
                    {
                        Circle curr_circle = current_Fig as Circle;
                        SingleCircle circle_edit = new SingleCircle(Instance.redo_undo,curr_circle, curr_circle.FigureColor, curr_circle.Figure_outColor, curr_circle.Radius, curr_circle.ID);
                        circle_edit.ShowDialog();
                        Instance.Invalidate();
                    }

                }
            }
        }
    }
}
