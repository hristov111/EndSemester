using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public class Red_Undo
    {
        private Form1 Instance;
        public Stack<Figure> undo = new Stack<Figure>();
        public  Stack<Figure> redo = new Stack<Figure>();
        public Stack<string> undo_modes = new Stack<string>();
        public Stack<string> redo_modes = new Stack<string>();
        public Stack<int> undo_indices = new Stack<int>();
        public Stack<int> redo_indices = new Stack<int>();
        public List<Figure> undo_clear = new List<Figure>();
        public List<Figure> redo_clear = new List<Figure>();

        public Stack<Point> undo_point = new Stack<Point>();

        public Stack<Point> redo_point = new Stack<Point>();

        public int rectangle_nextId;
        public int circle_nextId;
        public int triangle_nextId;
        private int count;
        private int second_count;



        public Red_Undo(Form1 instance)
        {
            this.Instance = instance;
        } 


        public void Undo()
        {
            if(undo.Count != 0 && undo_modes.Count != 0 && (undo_indices.Count !=0||undo_modes.Peek() == "Move")) 
            {
                string current_mode = undo_modes.Pop();
                if (current_mode == "Clear")
                {
                    for (int i = 0; i<undo_clear.Count; ++i)
                    {
                        Instance.figures.Add(undo_clear[i]);
                    }
                    Rectangle.NextID = rectangle_nextId;
                    Triangle.NextID = triangle_nextId;
                    Circle.NextID = circle_nextId;
                    undo_clear.Clear();
                    redo_modes.Push(current_mode);
                    return;
                }
                Figure current_fig = undo.Pop();
                if (current_mode == "Move" && undo_point.Count == 0)
                {
                    return;
                }
                Point point = new Point(1,1); 
                try
                {
                    point = undo_point.Pop();
                }
                catch (Exception e){ }
                int idx=0;
                try
                {
                     idx = undo_indices.Pop();

                }
                catch (Exception e) { }
                if (idx < 0)
                {
                    return;
                }
                if (current_mode == "Create")
                {
                    Instance.figures.Remove(current_fig);
                    Instance.ChangeInidces(current_fig,idx,true);
                    if(count >0)
                    {
                        second_count++;
                    }
                }
                else if (current_mode == "Delete")
                {
                    Instance.figures.Insert(idx, current_fig);
                    Instance.ChangeInidces(current_fig, idx+1, false);
                }
                else if(current_mode == "Move")
                {
                    current_fig.ChangePos(point.X, point.Y);
                    redo.Push(current_fig);
                    redo_point.Push(point);
                    count++;
                    return;
                }
                redo.Push(current_fig);
                redo_modes.Push(current_mode);
                redo_indices.Push(idx);
            }
        }

        public void Redo()
        {
            // make three figs
            // undo one figure 
            // clear the screen
            if(redo_modes.Count != 0)
            {
                string current_mode = redo_modes.Pop();
                if (current_mode == "Clear")
                {
                    for (int i = 0; i<Instance.figures.Count; i++)
                    {
                        undo_clear.Add(Instance.figures[i]);
                    }
                    Instance.figures.Clear();
                    Rectangle.NextID = 0;
                    Circle.NextID = 0;
                    Triangle.NextID = 0;
                    undo_modes.Push(current_mode);
                    return;
                }else if(redo.Count != 0 &&  redo_indices.Count != 0)
                {
                    Figure current_fig = redo.Pop();
                    int idx = redo_indices.Pop();

                    Point point = new Point(1, 1);

                    try
                    {
                        point = redo_point.Pop();
                    }
                    catch(Exception e) { }
                    if (current_mode == "Create")
                    {
                        try
                        {
                            Instance.figures.Insert(idx, current_fig);
                            Instance.ChangeInidces(current_fig, idx+1, false);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            for(int i = 0; i<undo_clear.Count; i++)
                            {
                                Instance.figures.Add(undo_clear[i]);
                            }
                            redo_modes.Push(current_mode);
                            redo.Push(current_fig);
                            redo_indices.Push(idx);
                            undo_clear.Clear();
                            return;
                        }
                        
                        
                    }
                    else if (current_mode == "Delete")
                    {
                        Instance.figures.Remove(current_fig);
                        Instance.ChangeInidces(current_fig, idx, true);
                    }
                    else if (current_mode == "Move")
                    {
                        current_fig.ChangePos(point.X, point.Y);
                        undo.Push(current_fig);
                        undo_point.Push(point);
                        return;
                    }
                    undo.Push(current_fig);
                    undo_modes.Push(current_mode);
                    undo_indices.Push(idx);
                }
            }   

        }
        
    }
}
