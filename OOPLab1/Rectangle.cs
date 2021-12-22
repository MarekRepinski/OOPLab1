using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public Rectangle(double Side)
        {
            this.Width = Side;
            this.Height = Side;
        }
        public override double GetArea()
        {
            return (Width * Height);
        }

        public override double GetPerimeter()
        {
            return (2 * Height + 2 * Width);
        }

        public override string ToString()
        {
            return $"This is a rectangle with height {Height} and width {Width}. Area is {GetArea()} and perimeter is {GetPerimeter()}";
        }
    }
}
