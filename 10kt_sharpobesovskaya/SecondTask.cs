using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kt_sharpobesovskaya
{
    interface IClonable<T> where T : new()
    {
        public T Clone();
    }
    class Point : IClonable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point() { }
        public Point Clone()
        {
            return new Point(X, Y);
        }
    }
    class Rectangle : IClonable<Rectangle>
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle() { }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public Rectangle Clone()
        {
            return new Rectangle(this.TopLeft.Clone(), this.BottomRight.Clone());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(20, 30);
            Point clone = p.Clone();
            Console.WriteLine("Координаты двух точек {0} {1}", p.X, p.Y);
            Console.WriteLine("Координаты двух склонированных точек {0} {1}", clone.X, clone.Y);
            Rectangle r = new Rectangle(p, p);
            Rectangle rectangle = r.Clone();
            Console.WriteLine("Координаты двух точек TopLeft: {0}, {1}    BottomRight: {2}, {3}", r.TopLeft.X, r.TopLeft.Y, r.BottomRight.X, r.BottomRight.Y);
            Console.WriteLine("Координаты двух склонированных точек {0} {1}    BottomRight: {2}, {3}", rectangle.TopLeft.X, rectangle.TopLeft.Y, rectangle.BottomRight.X, rectangle.BottomRight.Y);
        }
    }
}
