using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Ship : Vehicle
    {
        public int passangers;
        public string portaddress;
        public Ship(int year, double price, double speed, int passangers, string portaddress) : base(year, price, speed)
        {
            this.passangers = passangers;
            this.portaddress = portaddress;

        }
    }
}
