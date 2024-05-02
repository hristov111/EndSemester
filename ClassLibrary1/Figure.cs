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
        private  int Xvelocity = 5;
        private  int Yvelocity = 3;

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
        public void MoveMember()
        {
            if (X > WIDTH - 100)
            {
                Xvelocity = -Xvelocity;
            }
            if (X < 100)
            {
                Xvelocity = -Xvelocity;
            }
            if (Y > HEIGHT - 50)
            {
                Yvelocity = -Yvelocity;
            }
            if (Y < 100)
            {
                Yvelocity = -Yvelocity;
            }
            X += Xvelocity;
            Y += Yvelocity;
        }
    }
}
