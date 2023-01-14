using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Model
{
    internal abstract class Vehicle
    {
        private decimal total;
        private DateOnly trans;
        private int seat;
        private decimal tax;
        private decimal price;
        private int year;
        private string nopol;

        public string Nopol { get => nopol; set => nopol = value; }
        public int Year { get => year; set => year = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal Tax { get => tax; set => tax = value; }
        public int Seat { get => seat; set => seat = value; }
        public DateOnly Trans { get => trans; set => trans = value; }
        public decimal Total { get => total; set => total = value; }



        public Vehicle(string nopol, int year, decimal price, int seat, DateOnly trans)
        {
            Nopol = nopol;
            Year = year;
            Price = price;
            Tax = price * 10 / 100;
            Seat = seat;
            Trans = trans;
        }
    }
}
