using JuraganMobilSolution.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Base
{
    internal class RepoManager : IRepoManager

    {
        private ISuvRepo _suv;

        public ISuvRepo Suv
        {
            get
            {
                if (_suv is null)
                    _suv = new SuvRepo();

                return _suv;
            }
        }
    }
}
