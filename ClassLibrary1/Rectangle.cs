﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Figure
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public static int NextID = 0;
        public int Left { get; set; }
        public int Right { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }
    public Rectangle(int x, int y, string figurecolor, string figure_outcolor, int width, int height, bool garbage = false) : base(x, y, figurecolor, figure_outcolor)
        {
            this.Width = width;
            this.Height = height;
            if (!garbage)
            {
                ID = NextID++;
            }
            ChangePos(x, y);
        }
        public Rectangle()
        {

        }

        public override bool Equals(object? rect)
        {
            if (rect == null || GetType() != rect.GetType())
            {
                return false;
            }
            Rectangle rect1 = (Rectangle)rect;
            return this.Width == rect1.Width &&
                this.Height == rect1.Height
                && rect1.FigureColor == this.FigureColor
                && rect1.Figure_outColor == this.Figure_outColor;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Width, Height, FigureColor, FigureColor);
        }
        protected override double GetArea()
        {
            return Width * Height;
        }


        // HitTest method to check if a point is inside the rectangle
        public override bool HitTest(int x,int y)
        {
            // check if the point is whithin the bounds of the rectangle
            return x >= X && x <= X + Width && y >= Y && y<= Y + Height;
        }
        public override void ChangePos(int x, int y)
        {
            X = x; Y = y;
            Left = X;
            Right = X + Width;
            Top = Y;
            Bottom = Y + Height;
        }
    }
}
