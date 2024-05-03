using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Figures;

namespace EndSemensterProject
{
    public static class ScreenBoundaryHelper
    {
        public static Point GetScreenBounds()
        {
            return new Point(1387, 655);
        }

        public static bool IsAtTop(this Figures.Rectangle rect)
        {
            return rect.Top <= 0;
        }

        public static bool IsAtBottom(this Figures.Rectangle rect)
        {
            Point screenBounds = GetScreenBounds();
            return rect.Bottom >= screenBounds.Y-35;
        }

        public static bool IsAtLeft(this Figures.Rectangle rect)
        {
            return rect.Left <= 0;
        }

        public static bool IsAtRight(this Figures.Rectangle rect)
        {
            Point screenBounds = GetScreenBounds();
            return rect.Right >= screenBounds.X -20;
        }

        public static bool IsAtTop(this Circle circle)
        {
            return circle.Y - circle.Radius <= 0;
        }

        public static bool IsAtBottom(this Circle circle)
        {
            Point screenBounds = GetScreenBounds();
            return circle.Y + circle.Radius >= screenBounds.Y - 35;
        }

        public static bool IsAtLeft(this Circle circle)
        {
            return circle.X - circle.Radius <= 0;
        }

        public static bool IsAtRight(this Circle circle)
        {
            Point screenBounds = GetScreenBounds();
            return circle.X + circle.Radius >= screenBounds.X - 20;
        }

        public static bool IsAtTop(this Triangle triangle)
        {
            Triangle.Points[] vertices = { triangle.point1, triangle.point2, triangle.point3 };
            foreach (Triangle.Points vertex in vertices)
            {
                if (vertex.Y <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAtBottom(this Triangle triangle)
        {
            Point screenBounds = GetScreenBounds();
            Triangle.Points[] vertices = { triangle.point1, triangle.point2, triangle.point3 };
            foreach (Triangle.Points vertex in vertices)
            {
                if (vertex.Y >= screenBounds.Y - 40)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAtLeft(this Triangle triangle)
        {
            Triangle.Points[] vertices = { triangle.point1, triangle.point2, triangle.point3 };
            foreach (Triangle.Points vertex in vertices)
            {
                if (vertex.X <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAtRight(this Triangle triangle)
        {
            Point screenBounds = GetScreenBounds();
            Triangle.Points[] vertices = { triangle.point1, triangle.point2, triangle.point3 };
            foreach (Triangle.Points vertex in vertices)
            {
                if (vertex.X >= screenBounds.X - 20)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

