using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Figure
    {
        Point p1;
        Point p2;
        Point p3;
        Point p4;
        Point p5;

        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }


        public void PerimeterCalculator()
        {
            double p1p2 = LengthSide(p1, p2);
            double p2p3 = LengthSide(p2, p3);
            double perimeter;

            if (p4 == null)
            {
                double p1p3 = LengthSide(p1, p3);
                perimeter = p1p2 + p2p3 + p1p3;
                Console.WriteLine($"this is triangle with the perimetr {perimeter}");
            }
            else if ((p4 != null) && (p5 != null))
            {
                double p3p4 = LengthSide(p3, p4);
                double p4p5 = LengthSide(p4, p5);
                double p1p5 = LengthSide(p1, p5);
                perimeter = p1p2 + p2p3 + p3p4 + p4p5 + p1p5;
                Console.WriteLine($"this is pentagon with the perimetr {perimeter}");
            }
            else
            {

                double p3p4 = LengthSide(p3, p4);
                double p1p4 = LengthSide(p1, p4);
                perimeter = p1p2 + p2p3 + p3p4 + p1p4;
                Console.WriteLine($"this is quadrangle with the perimetr {perimeter}");
            }

        }
    }
}
