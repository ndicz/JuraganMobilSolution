using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Model
{
    internal class SUV : Vehicle

    {
         
        static decimal Totalincome;
        static int count = 0;
        private decimal rent;
        private decimal driver;

        public decimal Rent { get => rent; set => rent = value; }
        public decimal Driver { get => driver; set => driver = value; }
        public SUV(string nopol, int year, decimal price, int seat, DateOnly trans, decimal rent, decimal driver) : base(nopol, year, price, seat, trans)
        {
            Rent = rent;
            Driver = driver;
            Total = rent + driver;
            Totalincome += Total;
            count++;
        }
        public static int Count()
        {
            return count;
        }

        public static decimal Tot()
        {
            return Totalincome;
        }



        public override string? ToString()
        {
            return
                $"No Police         :{Nopol} \n" +
                $"Year              :{Year}\n" +
                $"Vehicle Type      :SUV\n" +
                $"Price             :{Price}\n" +
                $"Tax               :{Tax}\n" +
                $"Seat              :{Seat}\n" +
                $"Transaction Date  :{Trans} \n" +
                $"Rent              :{Rent} \n" +
                $"Driver            :{Driver}\n" +
                $"Total             :{Total}\n" +
                $" ";

        }
    }

}

