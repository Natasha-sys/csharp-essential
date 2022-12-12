namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee instance = new Employee("John", "Dou");
            instance.Position = "Manager";
            instance.YearsOfExpirience = 5;

            instance.EmployeeInfo();

            Console.WriteLine($"User name - {instance.name}");
            Console.WriteLine($"User surname - {instance.surname}");
            Console.ReadKey();
        }
    }
}