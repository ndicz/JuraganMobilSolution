using JuraganMobilSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Repo
{
    internal class TaxiRepo : ITaxiRepo
    {

        private List<Taxi> _taxi;

        public TaxiRepo ()
        {

            _taxi = new List<Taxi> { 
            new Taxi("D 11 UK",2002,175_000_000M,4,new DateOnly(2023, 01, 13),45,4500),
            new Taxi("D 12 UK",2015,225_000_000M,4,new DateOnly(2023,01,13), 75,4500),
            new Taxi("D 13 UK",2020,275_000_000,4,new DateOnly(2023,01,13),90,4500)
            
            };
        }

        public List<Taxi> Create(Taxi taxi)
        {
            _taxi.Add(taxi);

            return FindAll();
        }

        public int Delete(string id)
        {
            var taxiId = _taxi.Find(s => s.Nopol.Equals(id));

            if (taxiId is not null)
            {
                _taxi.Remove(taxiId);
                return 1;
            }

            return 0;
        }

        public List<Taxi> FindAll()
        {
            return _taxi;
        }

        public Taxi FindById(string id)
        {
            var taxiId = _taxi.Find(s => s.Nopol.Equals(id));

            if (taxiId is not null)
            {
                return taxiId;
            }

            return null;
        }

        public Taxi Update(string id, Taxi suv)
        {
            throw new NotImplementedException();
        }
    }
}
