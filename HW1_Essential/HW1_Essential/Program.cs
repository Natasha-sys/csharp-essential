using Task_2;

namespace HW1_Essential
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter value for side 1 of Rechtangle:");
            bool isNumber = Double.TryParse(Console.ReadLine(), out double side1);

            Console.WriteLine("Please enter value for side 2 of Rechtangle:");
            bool isNumber2 = Double.TryParse(Console.ReadLine(), out double side2);

            if (isNumber && isNumber2)
            {
                Rectangle rectangle = new Rectangle(side1, side2);

                Console.WriteLine($"Area is {rectangle.Area}");
                Console.WriteLine($"Perimeter is {rectangle.Perimeter}");
            }
            else
            { 
            Console.WriteLine($"Value id not valid");
            }
            Console.ReadKey();
        }
    }
}