namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "customerName", "Provider1", "product 1", 45);
            double result;
            result = invoice.Calculate(withVAT: true);

            Console.WriteLine($"Price with VAT = {result}");

            result = invoice.Calculate(withVAT: false);
            Console.WriteLine($"Price without VAT = {result}");

            Console.ReadKey();
        }
    }
}