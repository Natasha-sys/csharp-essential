using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class User
    {
        private string name;
        private string login;
        private string surname;
        private int age;
        private readonly DateTime created;

        public User(string name, string login, string surname, int age)
        {
            this.name = name;
            this.login = login;
            this.surname = surname;
            this.age = age;
            created = DateTime.Now;
        }
        public void Show() { 
            Console.WriteLine("User information is:");
            Console.WriteLine($"User name is {name} \n User Surname is {surname} \n User login is {login} \n User age is {age}");
            Console.WriteLine($"Created date is {created}");
        }
    }
}
