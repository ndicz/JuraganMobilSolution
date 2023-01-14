using JuraganMobilSolution.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Base
{
    internal class RepoManager : IRepoManager

    {
        private ISuvRepo _suv;
        private ITaxiRepo _taxi;
        private IPrivateJetRepo _privateJet;

        public ISuvRepo Suv
        {
            get
            {
                if (_suv is null)
                    _suv = new SuvRepo();

                return _suv;
            }
        }

        public ITaxiRepo taxi
        {

            get
            {
                if (_taxi is null)
                    _taxi = new TaxiRepo();
                return _taxi;
            }
        }

        public IPrivateJetRepo privateJet
        {

            get
            {
                if (_privateJet is null)
                    _privateJet = new PrivateJetRepo();
                return  _privateJet;
            }
        }

    }
}