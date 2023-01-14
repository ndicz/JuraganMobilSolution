using JuraganMobilSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Repo
{
    internal interface ISuvRepo
    {
        List<SUV> FindAll();
        SUV FindById(string id);
        List<SUV> Create(SUV suv);
        SUV Update(string id, SUV suv);
        int Delete(string id);

    }
}
