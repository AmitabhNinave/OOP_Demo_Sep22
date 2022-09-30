using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_I
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle objRectangle = new Rectangle(400,100);
            //objRectangle.Length = 100;
            //objRectangle.Breadth = 50;
            objRectangle.CalculateArea();
            Console.WriteLine("Area of a Rectangle is: {0}", objRectangle.Area);
            objRectangle.CalculatePerimeter();
            Console.WriteLine("Perimeter of a Rectangle is: {0}", objRectangle.Perimeter);
            
            //
            /*
            Rectangle objRectangle = new Rectangle();
            objRectangle.Display();//Derived Class method.
            */
            //
            /*
            Rectangle objRectangle = new Rectangle();
            objRectangle.Length = 100;
            objRectangle.Breadth = 50;
            CalculateAreaPerimeterOfShape(objRectangle);
            */
            //
            Console.ReadLine();
        }
        /*
        static void CalculateAreaPerimeterOfRectangle()
        {

        }

        static void CalculateAreaPerimeterOfSquare()
        {

        }
        */

        static void CalculateAreaPerimeterOfShape(Shape objShape)
        {
            objShape.CalculateArea();
            Console.WriteLine("Area of the Shape is: {0}", objShape.Area);
            objShape.CalculatePerimeter();
            Console.WriteLine("Perimeter of the Shape is: {0}", objShape.Perimeter);
        }


    }
}
