using JuraganMobilSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Repo
{
    internal class PrivateJetRepo : IPrivateJetRepo
    {

        private List<PrivateJet> _privatejet;

        public PrivateJetRepo()
        {
            _privatejet = new List<PrivateJet>
            {
                new PrivateJet("ID 8089",2015,150_000_000_000M,12,new DateOnly(2023,12,23),35_000_000,15_000_000),
                new PrivateJet("ID 80899",2018,175_000_000_000M,15, new DateOnly(2023,12,25),55_000_000,25_000_000)

            };
        }
        public List<PrivateJet> Create(PrivateJet privateJet)
        {
            _privatejet.Add(privateJet);

            return FindAll();
        }

        public int Delete(string id)
        {
            var jetId = _privatejet.Find(s => s.Nopol.Equals(id));

            if (jetId is not null)
            {
                _privatejet.Remove(jetId);
                return 1;
            }

            return 0;
        }

        public List<PrivateJet> FindAll()
        {
            return _privatejet;
        }

        public PrivateJet FindById(string id)
        {
            var jetId = _privatejet.Find(s => s.Nopol.Equals(id));

            if (jetId is not null)
            {
                return jetId;
            }

            return null;
        }

        public PrivateJet Update(string id, PrivateJet privateJet)
        {
            throw new NotImplementedException();
        }
    }
}
