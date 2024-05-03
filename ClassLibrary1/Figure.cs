using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Figures
{
    [Serializable]
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int ID { get; set; }
        private  int WIDTH = 1387;
        private  int HEIGHT = 655;
        public  int Xvelocity = 5;
        public  int Yvelocity = 3;

        public string FigureColor { get; set; } = null;
        public string Figure_outColor { get; set; } = null;
        public Figure(int x, int y, string figurecolor, string figure_outcolor, bool garbage = false)
        {
            this.X = x;
            this.Y = y;
            this.FigureColor = figurecolor;
            this.Figure_outColor = figure_outcolor;
        }
        public Figure()
        {

        }

        protected abstract double GetArea();
        public abstract bool HitTest(int x,int y);
        public abstract void ChangePos(int newX, int newY);
        public void MoveMember(bool Right, bool Left, bool Top, bool Bottom)
        {
            if(Right && Xvelocity > 0)
            {
                Xvelocity = -Xvelocity;
            }
            if (Left&& Xvelocity < 0)
            {
                Xvelocity = -Xvelocity;
            }
            if(Top && Yvelocity <0) 
            {
                Yvelocity = -Yvelocity;
            }
            if(Bottom && Xvelocity > 0) { Xvelocity = -Xvelocity; }
            X += Xvelocity;
            Y += Yvelocity;
        }
    }
}
