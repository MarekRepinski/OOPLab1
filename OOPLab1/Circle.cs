using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    public class Circle : Shape
    {
        public double Radius;
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return (Radius * Radius * Math.PI);
        }

        public override double GetPerimeter()
        {
            return (2 * Radius * Math.PI);
        }

        public override string ToString()
        {
            return $"This is a circle with radius {Radius}. The area is {GetArea()} and the perimeter is {GetPerimeter()}";
        }
    }
}
