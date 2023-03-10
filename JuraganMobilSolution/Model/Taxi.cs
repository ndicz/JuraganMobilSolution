using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Model
{
    internal class Taxi : Vehicle

    {
        static decimal Totalincome;
        static int count = 0;
        private decimal order;
        private decimal orderKm;
        private decimal Order { get => order; set => order = value; }

        private decimal OrderKm { get => orderKm; set => orderKm = value; }

   

        public Taxi(string nopol, int year, decimal price, int seat, DateOnly trans, decimal order, decimal orderkm) : base(nopol, year, price, seat, trans)
        {
            Order = order;
            OrderKm = orderkm;
            Total = order * orderkm;
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
                $"Vehicle Type      :Taxi\n" +
                $"Price             :{Price}\n" +
                $"Tax               :{Tax}\n" +
                $"Seat              :{Seat}\n" +
                $"Transaction Date  :{Trans} \n" +
                $"Order             :{Order} \n" +
                $"Order KM          :{OrderKm}\n" +
                $"Total             :{Total}\n" +
                $" ";
        }


    }
}
