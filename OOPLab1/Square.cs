using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    public class Square : Shape
    {
        public double SideLength;
        public Square(double SideLength)
        {
            this.SideLength = SideLength;
        }
        public override double GetArea()
        {
            return (SideLength * SideLength);
        }

        public override double GetPerimeter()
        {
            return (4 * SideLength);
        }

        public override string ToString()
        {
            return $"This is a square with side length {SideLength}, area {GetArea()} and perimeter length {GetPerimeter()}";
        }
    }
}
