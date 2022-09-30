using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_I
{
    internal class Shape
    {
        private int area;
        private int perimeter;

        public int Area
        {
            get
            {
                return area;
            }
            set
            {
                //if(value > 100)
                //{
                    area = value;
                //}
            }
        }
        public int Perimeter
        {
            get
            {
                return perimeter;
            }
            set
            {
                perimeter = value;
            }
        }

        internal virtual void CalculateArea()
        {
            
        }
        internal virtual void CalculatePerimeter()
        {

        }

        internal void Display()
        {

        }

    }
}
