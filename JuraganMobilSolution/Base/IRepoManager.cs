using JuraganMobilSolution.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Base
{
    interface IRepoManager
    {
        public ISuvRepo Suv { get; }
        public ITaxiRepo taxi { get; }  
        public IPrivateJetRepo privateJet { get; }
    }
}
