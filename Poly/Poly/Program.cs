﻿using System;
using System.Globalization;

namespace Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.DrawShape();          //Shape
            Circle c1 = new Circle();
            c1.DrawShape();          //Circle
            Rectangle r1 = new Rectangle();
            r1.DrawShape();          //Rectangle

            Shape s2 = new Circle();   //Upcasting
            s2.DrawShape();            //Circle

            Shape s3 = new Rectangle();
            s3.DrawShape();            //Rectangle
         //Array of references of base class referencing 
         //Derived class object (UPCASTING)
            Shape[] p =
            {
                new Circle()
            }
        }
    }
}
