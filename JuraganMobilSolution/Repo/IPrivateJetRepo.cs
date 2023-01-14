using JuraganMobilSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Repo
{
   internal interface IPrivateJetRepo
    {
        List<PrivateJet> FindAll();
        PrivateJet FindById(string id);
        List<PrivateJet> Create(PrivateJet privateJet);
        PrivateJet Update(string id, PrivateJet privateJet);
        int Delete(string id);

    }
}
