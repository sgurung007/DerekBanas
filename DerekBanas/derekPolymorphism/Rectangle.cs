using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas.derekPolymorphism
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double lenght, double width)
        {
            Length = lenght;
            Width = width;

        }
        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a Length of {Length} and Width of {Width}");
        }
    }
}
