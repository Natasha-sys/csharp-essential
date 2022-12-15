using Task_6;

namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("ytruytur");

            B b = new B();
            b.Print("y");
            Console.ReadKey();
        }
        public class B : Printer
        {
            public override void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                base.Print(value);
                Console.ResetColor();
            }
        }

    }

}
