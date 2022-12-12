using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee
    {
        public string name;
        public string surname;

        public string Position { get; set; }
        public int YearsOfExpirience { get; set; }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void EmployeeInfo()
        {
            double salary;
            double fullSalary;

            const double vat = 0.2;
            switch (Position)
            {
                case "Manager":
                    salary = 10500;
                    break;
                case "Clerk":
                    salary = 2000;
                    break;
                default:
                    salary = 0;
                    break;
            }

            if ((YearsOfExpirience <5)&&(YearsOfExpirience>=0))
            {
                fullSalary = salary;
            }else if ((YearsOfExpirience >= 5) && (YearsOfExpirience < 10))
            {
                fullSalary = salary * 1.15;
            }
            else if ((YearsOfExpirience >=10) && (YearsOfExpirience < 20))
                {
                fullSalary = salary*1.25;
            }
            else if (YearsOfExpirience >= 20)
            {
                fullSalary = salary * 1.5;
            }
            else
            {
                fullSalary = 0;
            }

            double result = fullSalary * vat;

            Console.WriteLine($"Position - {Position}");
            Console.WriteLine($"Full salary - {fullSalary}");
            Console.WriteLine($"VAT is - {result}");
        }
    }
}
