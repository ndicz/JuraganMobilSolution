using JuraganMobilSolution.Base;
using JuraganMobilSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Summary
{
    internal class SummaryInfo : ISummary
    {

        public SummaryInfo()
        {


        }
        public decimal GetTotalIncome(string Vehicle)
        {
            return Vehicle == "Taxi" ? Taxi.Tot() : Vehicle == "PrivateJet" ? PrivateJet.Tot() : Vehicle == "SUV" ? SUV.Tot() : 0;
        }

        public decimal GetTotalIncomeVehicle()
        {
           
            return SUV.Tot() + Taxi.Tot() + PrivateJet.Tot();
        }

        public int GetTotalVehicle()
        {
         
         
            return SUV.Count() + Taxi.Count() + PrivateJet.Count();

        }

        public int GetTotalVehicle(string Vehicle)
        {
            return Vehicle == "Taxi" ? Taxi.Count() : Vehicle == "PrivateJet" ? PrivateJet.Count() : Vehicle == "SUV" ? SUV.Count() : 0;

        }
    }
}
