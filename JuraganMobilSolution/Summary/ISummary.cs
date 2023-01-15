using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Summary
{
    internal interface ISummary
    {
        int GetTotalVehicle();
        decimal GetTotalIncomeVehicle();

        int GetTotalVehicle(string Vehicle);

        decimal GetTotalIncome(string Vehicle);

    }
}
