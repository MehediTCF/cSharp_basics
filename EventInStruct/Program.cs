using System;

namespace EventInStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.PointChanged += PointHandler;
            p.X = 10;
            p.X = 20;
        }
        static void PointHandler(int point)
        {
            Console.WriteLine("Point changed to {0}", point);
        }
    }
    struct Point
    {
        private int x, y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                PointChanged(x);
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                PointChanged(y);
            }
        }
        public event Action<int> PointChanged;
    }
}
