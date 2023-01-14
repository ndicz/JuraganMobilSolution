using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Model
{
    internal class Taxi : Vehicle

    {

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
            count++;
        }

        public static int Count()
        {
            return count;
        }

        public override string? ToString()
        {
            return
               $"{Nopol} ,\n" +
               $"{Year} ,\n" +
               $"{Price} ,\n" +
               $"{Tax} ,\n" +
               $"{Seat} ,\n" +
               $"{Trans} ,\n" +
               $"{Order} ,\n" +
               $"{OrderKm} ,\n" +
               $"{Total} HALO ,";
        }


    }
}
