using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_I
{
    internal sealed class Rectangle:Shape
    {
        private int length;
        private int breadth;

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Breadth
        {
            get
            {
                return breadth;
            }
            set
            {
                breadth = value;
            }
        }

        public Rectangle()
        {

        }

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        internal override void CalculateArea()
        {
            //base.CalculateArea();
            Area = Length * Breadth;
        }
        internal override void CalculatePerimeter()
        {
            //base.CalculatePerimeter();
            Perimeter = (Length * 2) + (Breadth * 2);
        }

        internal new void Display()//Shadowing
        {

        }

    }

    /*
    class DerivedRectangle:Rectangle//Can derive from sealed class.
    {

    }
    */
}
