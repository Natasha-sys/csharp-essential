using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        public double PerimeterCalculator()
        {
            double perimeter = (side2 + side1) * 2;
            return perimeter;
        }
    }
}
