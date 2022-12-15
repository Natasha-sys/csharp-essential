namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Vehicle car = new Car(1200, 34.8, 34);
            Console.WriteLine($"It is a car. Year - {car.year}, Price = {car.price}, speed = {car.speed}");

            Plane plane = new Plane(1200, 34.8, 34, 2.30, 340);
            Console.WriteLine($"It is a plane. Year - {plane.year}, Price = {plane.price}, speed = {plane.speed}, High = {plane.high}, Passangers = {plane.passangers}");

            Ship ship = new Ship(1200, 34.8, 34, 340, "portaddress");
            Console.WriteLine($"It is a Ship. Year - {ship.year}, Price = {ship.price}, speed = {ship.speed}, High = {ship.passangers}, Address = {ship.portaddress}");

            Console.ReadKey();
        }
    }
}