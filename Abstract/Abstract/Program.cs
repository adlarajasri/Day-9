using System;

namespace Abstract
{
    abstract class Figure
    {
        public int Dimension;
        public abstract double Area();
        public abstract double Perimeter();
    }
    class Square : Figure
    {
        public override double Area()
        {
            return Dimension * Dimension;
        }
        public override double Perimeter()
        {
            return 4 * Dimension; 
        }
    }
    class Circle : Figure
    {
        public override double Area()
        {
            return Math.PI*Dimension*Dimension;
        }
        public override double Perimeter()
        {
            return 2*Math.PI*Dimension;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure f = new Square();        //Upcasting
            f.Dimension = 10;
            Console.WriteLine(f.Area());
            Console.WriteLine(f.Perimeter());
            Figure f1 = new Circle();        //Upcasting
            f1.Dimension = 20;
            Console.WriteLine(f1.Area());
            Console.WriteLine(f1.Perimeter());

        }
    }
}
