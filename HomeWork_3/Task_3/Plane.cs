using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Plane : Vehicle
    {
        public double high;
        public int passangers;
        public Plane(int year1, double price1, double speed1, double high, int passangers) : base(year1,price1,speed1)
        {
            this.high = high;
            this.passangers = passangers;
        }
    }
}
