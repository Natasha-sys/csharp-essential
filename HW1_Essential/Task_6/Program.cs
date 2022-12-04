namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address();
            address.Index = "1212AA";
            address.Country = "Netherland";
            address.City = "Hilversum";
            address.Street = "Hoher-Str";
            address.House = "34";
            address.Apartment = "33";

            Console.WriteLine($"Index = {address.Index}");
            Console.WriteLine($"Country = {address.Country}");
            Console.WriteLine($"City = {address.City}");
            Console.WriteLine($"Street = {address.Street}");
            Console.WriteLine($"House = {address.House}");
            Console.WriteLine($"Apartment = {address.Apartment}");
            Console.ReadKey();

        }
    }
}