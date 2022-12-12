namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("To finish registration please add some data:");
            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine("Enter your Surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your login:");
            string login = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Int32.Parse(Console.ReadLine());

            User instance = new User(name, login, surname, age);

            instance.Show();
            Console.ReadKey();



        }
    }
}