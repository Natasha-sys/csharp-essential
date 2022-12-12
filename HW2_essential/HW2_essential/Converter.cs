using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Converter
    {
        private double usd;
        private double eur;
        private double rub;


        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double ConvertToHrn(double value, string currency)
        {
            switch (currency)
            {
                case "usd":
                    return value * this.usd;
                case "eur":
                    return value * this.eur;
                case "rub":
                    return value * this.rub;
                default: return 0;
            }

        }

        public double ConvertfromHrn(double value, string currency)
        {
            switch (currency)
            {
                case "usd":
                    return value / this.usd;
                case "eur":
                    return value / this.eur;
                case "rub":
                    return value / this.rub;
                default: return 0;
            }

        }

    }
}
