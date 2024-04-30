using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using EndSemensterProject;
using Figures; 

namespace EndSemesterProject
{
    public class Red_Undo
    {
        private Form1 Instance;
        private int number_of_clear = 0;
        public struct Create_Delete
        {
            public Figure Fig;
            public int Index;
            public string Mode;

            public Create_Delete(Figure fig, int index, string mode)
            {
                Mode = mode;
                Index = index;
                Fig = fig;
            }
        }
        public Stack<Create_Delete> create_delete_undo = new Stack<Create_Delete>();
        public Stack<Create_Delete> create_delete_redo = new Stack<Create_Delete>();
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public struct Move
        {
            public Figure Fig;
            public Point Point;
            public Move(Figure fig,Point point)
            {
                Fig = fig;
                Point = point;
            }
        }
        public Stack<Move> move_undo = new Stack<Move>();
        public Stack<Move> move_redo = new Stack<Move>();
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        public struct Clear_Screen
        {
            public List<Figure> Figures = new List<Figure>();
            public int Rect_NextID { get; set; }
            public int Trig_NextID { get; set; }
            public int Circle_NextID { get; set; }
            public Clear_Screen(List<Figure> figures,int rect_nextid, int trig_nextid,int circle_nextid)
            {
                Rect_NextID = rect_nextid;
                Trig_NextID = trig_nextid;
                Circle_NextID = circle_nextid;
                for(int i = 0; i < figures.Count; ++i)
                {
                    Figures.Add(figures[i]);
                }
            }
        }
        public Stack<Clear_Screen> undo_clear = new Stack<Clear_Screen>();
        public Stack<Clear_Screen> redo_clear = new Stack<Clear_Screen>();
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////
        /// </summary>
       private interface IFigure
        {
            string Color { get; set; }
            string OutColor { get; set; }
        }
        public struct TrigEdit:IFigure
        {
            public string Color { get; set; }
            public string OutColor { get; set; }
            public int Trig_Side1;
            public int Trig_Side2;
            public int Trig_Side3;
            public TrigEdit(string color,string outColor,int side1, int side2, int side3)
            {
                Color = color;
                OutColor = outColor;
                Trig_Side1 = side1;
                Trig_Side2 = side2;
                Trig_Side3 = side3;
            }
        }
        public struct RectEdit:IFigure
        {
            public string Color { get; set; }
            public string OutColor { get; set; }
            public int Rect_Width;
            public int Rect_Height;
            public RectEdit(string color,string outColor, int width,int height)
            {
                Color = color;
                OutColor = outColor;
                Rect_Width = width;
                Rect_Height = height;
            }
        }
        public struct CircleEdit:IFigure
        {
            public string Color { get; set; }
            public string OutColor { get; set; }
            public int Circle_Radius;
            public CircleEdit(string color, string outColor, int radius)
            {
                Color = color;
                OutColor = outColor;
                Circle_Radius = radius;

            }
        }
        Stack<IFigure> undo_edit_current = new Stack<IFigure>();
        Stack<Figure> undo_edit_updated = new Stack<Figure> ();
        Stack<IFigure> redo_edit_current = new Stack<IFigure>();
        Stack<Figure> redo_edit_updated = new Stack<Figure>();
        /// <summary>
        /// //////////////////////////////////////////////////////////
        /// </summary>
        Stack<string> MAIN_undo = new Stack<string>();
        Stack<string> MAIN_redo = new Stack<string>(); 
        public Red_Undo(Form1 instance)
        {
            this.Instance = instance;
        } 
        public void SetValuesEdit(Figure fig,Figure updated)
        {
            if(fig is Figures.Rectangle)
            {
                Figures.Rectangle rect = (Figures.Rectangle)fig;
                Figures.Rectangle updated_rect = (Figures.Rectangle)updated;
                if(!rect.Equals(updated_rect))
                {
                    IFigure new_rect = new RectEdit(rect.FigureColor, rect.Figure_outColor, rect.Width, rect.Height);
                    undo_edit_current.Push(new_rect);
                    undo_edit_updated.Push(updated);
                    MAIN_undo.Push("Edit");
                }
            }
            else if(fig is Triangle)
            {
                Triangle trig = (Triangle)fig;
                Triangle other = (Triangle)updated;
                if (!trig.Equals(other))
                {
                    IFigure new_trig = new TrigEdit(trig.FigureColor, trig.Figure_outColor, trig.FirstSide, trig.SecondSide, trig.ThirdSide);
                    undo_edit_current.Push(new_trig);
                    undo_edit_updated.Push(updated);
                    MAIN_undo.Push("Edit");
                }
            }
            else if(fig is Circle)
            {
                Circle circle = (Circle)fig;
                Circle other = (Circle)updated;
                if (!circle.Equals(other))
                {
                    IFigure new_circle = new CircleEdit(circle.FigureColor, circle.Figure_outColor, circle.Radius);
                    undo_edit_current.Push(new_circle);
                    undo_edit_updated.Push(updated);
                    MAIN_undo.Push("Edit");
                }
            }
        }
        public void Set_ValuesCreateDelete(Figure fig, int index, string mode)
        {
            create_delete_undo.Push(new Create_Delete(fig,index,mode));
            MAIN_undo.Push("Create/Delete");

        }
        public void Set_ValueMove(Figure fig, Point point)
        {
            MAIN_undo.Push("Move");
            if(move_undo.Count == 0)
            {
                Move new_move = new Move(fig, point);
                move_undo.Push(new_move);
            }
            else
            {
                Move last_move = move_undo.Peek();
                Point last_point = last_move.Point;
                if(Math.Abs((last_point.X + last_point.Y) - (point.X + point.Y)) > 20)
                {
                    Move new_move = new Move(fig, point);
                    move_undo.Push(new_move);
                }
            }
        }
        public void Set_ClearList(List<Figure> figures_,int trig,int rect,int circle)
        {
            if(number_of_clear > 1)
            {
                Clear_All_Stacks();
                number_of_clear = 0;
            }
            number_of_clear++;
            MAIN_undo.Push("Clear");
            Clear_Screen new_clear = new Clear_Screen(figures_,trig,rect,circle);
            undo_clear.Push(new_clear);
        }
        private void Clear_All_Stacks()
        {
            create_delete_undo.Clear();
            create_delete_redo.Clear();
            undo_clear.Clear();
            redo_clear.Clear();
            undo_edit_current.Clear();
            undo_edit_updated.Clear();
            move_undo.Clear();
            move_redo.Clear();
            MAIN_undo.Clear();
            MAIN_redo.Clear();
        }
        public void DetermineUndo_Method()
        {
            if(MAIN_undo.Count != 0)
            {
                string txt = MAIN_undo.Pop();
                if (txt == "Edit")
                {
                    Undo_Edit();
                }
                else if (txt == "Create/Delete")
                {
                    Undo_Create_Delete();
                    MAIN_redo.Push("Create/Delete");

                }
                else if (txt == "Move")
                {
                    Undo_Move();
                    MAIN_redo.Push("Move");
                }
                else if (txt == "Clear")
                {
                    Undo_Clear();
                    MAIN_redo.Push("Clear");
                }
            }
        }
        public void DetermineRedo_Method()
        {
           if(MAIN_redo.Count != 0)
            {
                string txt = MAIN_redo.Pop();
                if (txt == "Create/Delete")
                {
                    Redo_Create_Delete();
                    MAIN_undo.Push("Create/Delete");

                }
                else if (txt == "Move")
                {
                    Redo_Move();
                    MAIN_undo.Push("Move");
                }
                else if (txt == "Clear")
                {
                    Redo_Clear();
                    MAIN_undo.Push("Clear");
                }
            }
        }

        public void Undo_Edit()
        {
            if (undo_edit_current.Count != 0)
            {
                IFigure fig = undo_edit_current.Pop();
                Figure updated = undo_edit_updated.Pop();
                if (fig is RectEdit)
                {
                    RectEdit rect = (RectEdit)fig;
                    Figures.Rectangle up = (Figures.Rectangle)updated;
                    redo_edit_current.Push(rect);
                    redo_edit_updated.Push(up);
                    up.Height = rect.Rect_Height;
                    up.Width = rect.Rect_Width;
                }
                else if (fig is TrigEdit)
                {
                    TrigEdit trig = (TrigEdit)fig;
                    Triangle up = (Triangle)updated;
                    redo_edit_current.Push(trig);
                    redo_edit_updated.Push(up);
                    up.FirstSide = trig.Trig_Side1;
                    up.SecondSide = trig.Trig_Side2;
                    up.ThirdSide = trig.Trig_Side3;
                }
                else if (fig is CircleEdit)
                {
                    CircleEdit circle = (CircleEdit)fig;
                    Circle up = (Circle)updated;
                    redo_edit_current.Push(circle);
                    redo_edit_updated.Push(up);
                    up.Radius = circle.Circle_Radius;
                }
                updated.FigureColor = fig.Color;
                updated.Figure_outColor = fig.OutColor;
            }
        }
        
        public void Undo_Clear()
        {
            if(undo_clear.Count != 0)
            {
                Clear_Screen scrren_clear = undo_clear.Pop();
                for(int i=0;i<scrren_clear.Figures.Count;i++)
                {
                    Instance.figures.Add(scrren_clear.Figures[i]);
                }
                Figures.Rectangle.NextID = scrren_clear.Rect_NextID;
                Triangle.NextID = scrren_clear.Trig_NextID;
                Circle.NextID = scrren_clear.Circle_NextID;
                redo_clear.Push(scrren_clear);
            }
        }
        public void Redo_Clear()
        {
            if(redo_clear.Count != 0)
            {
                Clear_Screen scrren_clear = redo_clear.Pop();
                Instance.figures.Clear();
                Figures.Rectangle.NextID = 0;
                Triangle.NextID = 0;
                Circle.NextID = 0;
                undo_clear.Push(scrren_clear);
            }
        }

        public void Undo_Move()
        {
            if(move_undo.Count != 0)
            {
                Move move_object = move_undo.Pop();
                move_object.Fig.ChangePos(move_object.Point.X, move_object.Point.Y);
                move_redo.Push(move_object);
            }
        }
        public void Redo_Move()
        {
            if(move_redo.Count != 0)
            {
                Move move_object = move_redo.Pop();
                move_object.Fig.ChangePos(move_object.Point.X, move_object.Point.Y);
                move_undo.Push(move_object);

            }
        }

        public void Undo_Create_Delete()
        {
            //1. Create- Figure,index,mode
            //2. Delete - Figure, index, mode
            if (create_delete_undo.Count != 0)
            {

                Create_Delete undo_object = create_delete_undo.Pop();
                if (undo_object.Mode == "Delete")
                {
                    Instance.figures.RemoveAt(undo_object.Index);
                    Instance.ChangeInidces(undo_object.Fig.GetType(), undo_object.Index, true);
                }
                else if (undo_object.Mode == "Create")
                {
                    Instance.ChangeInidces(undo_object.Fig.GetType(), undo_object.Index, false);
                    Instance.figures.Insert(undo_object.Index, undo_object.Fig);
                }
                create_delete_redo.Push(undo_object);
            }

        }
        public void Redo_Create_Delete()
        {
            if(create_delete_redo.Count != 0)
            {
                Create_Delete redo_object = create_delete_redo.Pop();
                if (redo_object.Mode == "Create")
                {
                    Instance.figures.RemoveAt(redo_object.Index);
                    Instance.ChangeInidces(redo_object.Fig.GetType(), redo_object.Index, true);
                }
                else if (redo_object.Mode == "Delete")
                {
                    Instance.ChangeInidces(redo_object.Fig.GetType(), redo_object.Index, false);
                    Instance.figures.Insert(redo_object.Index, redo_object.Fig);
                }
                create_delete_undo.Push(redo_object);
            }
        }
    }
}
