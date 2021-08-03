using System;

namespace objectDemo2
{
    class Parallelogram
    {
        public double Length;
        public double Width;

        public double GetArea()
        {
            return Length * Width;

        }

        public double GetPerimeter()
        {
            return Length + Length + Width + Width;

        }

        public void print()
        {
            Console.WriteLine("here is your Parallelogram");
            Console.WriteLine($"Length: {Length}, Width: {Width}");
            Console.WriteLine($"Area: {GetArea()}, Perimeter : {GetPerimeter()}");
        }

        public void Resize(double NewLength, double Newwidth)
        {
            Length = NewLength;
            Width = Newwidth;
            
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Parallelogram p1 = new Parallelogram() { Length = 10, Width = 20 };
            Console.WriteLine(p1.GetArea());

        }
    }
    
}
