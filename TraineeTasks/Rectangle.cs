using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeTasks
{
    class Rectangle
    {

        private Point A;
        private Point B;

        public Point GetA { get { return A; } }
        public Point GetB { get { return B; } }

        public int GetArea {
            get
            {
                int width = B.GetX - A.GetX;
                int height = B.GetY - A.GetY;
                return width * height;
            }
        }

        public Rectangle(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
        

        public bool IntersectWith(Rectangle obj2)
        {
            bool intersect = false;
            if ((obj2.GetB.GetX >= GetA.GetX && obj2.GetA.GetX <= GetB.GetX) && (obj2.GetB.GetY >= GetA.GetY && obj2.GetA.GetY <= GetB.GetY))
            {
                intersect = true;
            }

            return intersect;
        }

        public Rectangle OverlapedArea(Rectangle obj2)
        {
            try
            {
                if (!IntersectWith(obj2))
                {
                    throw new Exception("2 object are not intersecting");
                }

                Rectangle OverlapedRect;
                Point pointA = null;
                Point pointB = null;

                pointA = GetA;
                for (int y = GetA.GetY; y <= GetB.GetY; y++)
                {
                    for (int x = GetA.GetX; x <= GetB.GetX; x++)
                    {
                        if ((x >= obj2.GetA.GetX && y >= obj2.GetA.GetY) && (x <= obj2.GetB.GetX && y <= obj2.GetB.GetY))
                        {
                            if (pointA == GetA)
                            {
                                pointA = new Point(x, y);
                            }
                            pointB = new Point(x, y);
                        }
                    }
                }
                OverlapedRect = new Rectangle(pointA, pointB);
                return OverlapedRect;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
    }

    class Point
    {
        private int x;
        private int y;

        public int GetX { get { return x; } }
        public int GetY { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
