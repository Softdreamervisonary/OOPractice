using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPracticeGUI.Servcie
{
    /// <summary>
    /// further changes of that kind are achieved by adding new code, 
    /// not by changing old code that already works.
    /// </summary>


    public class OpenClosedPrincipleSample 
    {
        //public class Rectangle
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }
        //}

        //public class Circle
        //{
        //    public double Radius { get; set; }
        //}

        //public double Area(object[] shapes)
        //{
        //    double area = 0;
        //    foreach (var shape in shapes)
        //    {
        //        if (shape is Rectangle)
        //        {
        //            Rectangle rectangle = (Rectangle)shape;
        //            area += rectangle.Width * rectangle.Height;
        //        }
        //        else
        //        {
        //            Circle circle = (Circle)shape;
        //            area += circle.Radius * circle.Radius * Math.PI;
        //        }
        //    }

        //    return area;
        //}

        public abstract class Shape
        {
            public abstract double Area();
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area()
            {
                return Width * Height;
            }
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double Area()
            {
                return Radius * Radius * Math.PI;
            }
        }

        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }


        

        

    }
}
