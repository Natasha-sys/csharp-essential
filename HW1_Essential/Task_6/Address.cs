using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get
            {
                if (index != null)

                    return index;
                else
                    return "No index.";
            }
            set { index = value; }
        }

        public string Country
        {
            get
            {
                if (country != null)

                    return country;
                else
                    return "No value for country.";
            }
            set { country = value; }
        }

        public string City
        {
            get
            {
                if (city != null)

                    return city;
                else
                    return "No value for city";
            }
            set { city = value; }
        }
        public string Street
        {
            get
            {
                if (street != null)

                    return street;
                else
                    return "No value for street";
            }
            set { street = value; }
        }

        public string House
        {
            get
            {
                if (house != null)
                    return house;
                else
                    return "No value for hause";
            }
            set { house = value; }
        }
        public string Apartment
        {
            get
            {
                if (apartment != null)

                    return apartment;
                else
                    return "No value for apartment";
            }
            set { apartment = value; }
        }
    }
}