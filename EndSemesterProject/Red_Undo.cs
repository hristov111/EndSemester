using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public class Red_Undo
    {
        private Form1 Instance;
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
        public Red_Undo(Form1 instance)
        {
            this.Instance = instance;
        } 
        public void Set_ValuesCreateDelete(Figure fig, int index, string mode)
        {
            Create_Delete new_create_delete = new Create_Delete(fig,index,mode);
            create_delete_undo.Push(new_create_delete);
            
        }
        public void Set_ValueMove(Figure fig, Point point)
        {
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
            Clear_Screen new_clear = new Clear_Screen(figures_,trig,rect,circle);
            undo_clear.Push(new_clear);
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
                Rectangle.NextID = scrren_clear.Rect_NextID;
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
                Rectangle.NextID = 0;
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
                    Instance.figures.Remove(undo_object.Fig);
                    Instance.ChangeInidces(undo_object.Fig, undo_object.Index, true);
                }
                else if (undo_object.Mode == "Create")
                {
                    Instance.ChangeInidces(undo_object.Fig, undo_object.Index, false);
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
                    Instance.figures.Remove(redo_object.Fig);
                    Instance.ChangeInidces(redo_object.Fig, redo_object.Index, true);
                }
                else if (redo_object.Mode == "Delete")
                {
                    Instance.ChangeInidces(redo_object.Fig, redo_object.Index, false);
                    Instance.figures.Insert(redo_object.Index, redo_object.Fig);
                }
                create_delete_undo.Push(redo_object);
            }
        }
    }
}
