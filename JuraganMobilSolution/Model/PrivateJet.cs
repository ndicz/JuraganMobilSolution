using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Model
{
    internal class PrivateJet : Vehicle
    {
        private decimal driver;
        private decimal rent;

        private decimal Rent { get => rent; set => rent = value; }
        private decimal Driver { get => driver; set => driver = value; }
        public PrivateJet(string nopol, int year, decimal price, int seat, DateOnly trans, decimal rent, decimal driver) : base(nopol, year, price, seat, trans)
        {
            Rent = rent;
            Driver = driver;
            Total = rent + driver;
        }

        public override string? ToString()
        {
            return
             $"No Police         :{Nopol} \n" +
                $"Year              :{Year}\n" +
                $"Vehicle Type      :Private Jet\n" +
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
