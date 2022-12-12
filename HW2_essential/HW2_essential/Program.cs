using Task2;

namespace HW2_essential
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an amonts of money you would like to exchange: ");
            bool isValid = Double.TryParse(Console.ReadLine(), out double value);

            if (!isValid)
            {
                Console.WriteLine("Amount is not a number value");
                return;
            }

            Console.WriteLine("Enter the currency you would like to exchange. Possible change eur, usd, rub:");
            string currency = Console.ReadLine().ToLower();

            if (currency != "eur" && currency != "usd" && currency != "rub")
            {
                Console.WriteLine("Unknown currency");

                return;
            }

            Console.WriteLine($"to cxchange to 'hrn' - enter - 'to';  to exchange from 'hrn' - enter 'from': ");
            string toOrftom = Console.ReadLine().ToLower();


            if (toOrftom != "to" && currency != "from")
            {
                Console.WriteLine("Unknown value");

                return;
            }
            Converter converter = new Converter(40.2, 41.3, 0.3);
            if (toOrftom == "to")
            {
                double result = converter.ConvertToHrn(value, currency);
                Console.WriteLine($"You have exchange {value} of {currency} to hrn and your amaount of hrn is {result}");
            }
            else
            {
                double result = converter.ConvertfromHrn(value, currency);
                Console.WriteLine($"You have exchange {value} of hrn to the {currency} and your amaount of {currency} is {result}");
            }
            Console.ReadKey();
        }


    }
}