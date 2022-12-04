namespace Task_4
{
    internal class Program
    {
        static void Main()
        {

            Figure figure = new Figure(
                new Point(8, 10, "p1"),
                new Point(12, 20, "p2"),
                new Point(12, 20, "p3")
            );
            figure.PerimeterCalculator();

            Figure figure1 = new Figure(
                new Point(8, 10, "p1"), 
                new Point(12, 20, "p2"), 
                new Point(12, 20, "p3"), 
                new Point(22, 30, "p4")
            );
            figure1.PerimeterCalculator();

            Figure figure2 = new Figure(
                new Point(8, 10, "p1"), 
                new Point(12, 20, "p2"), 
                new Point(12, 20, "p3"), 
                new Point(22, 30, "p4"), 
                new Point(33, 40, "p5")
            );

            figure2.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}