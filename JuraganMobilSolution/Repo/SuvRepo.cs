using JuraganMobilSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Repo
{
    internal class SuvRepo : ISuvRepo
    {


        private List<SUV> _suvs;

        public SuvRepo()
        {
            _suvs = new List<SUV>{
                new SUV("D 1001 UM", 2010, 35000_0000M, 4, new DateOnly(2023, 01, 10), 500000M, 50000M)
               ,new SUV("D 1002 UM", 2010, 350000000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M)
               ,new SUV("D 1003 UM", 2015, 350000000M, 5, new DateOnly(2023, 01, 12), 500000M, 150000M)
               ,new SUV("D 1004 UM", 2015, 350000000M, 5, new DateOnly(2023, 01, 13), 500000M, 150000M)
            };
        }
        public List<SUV> Create(SUV suv)
        {
            _suvs.Add(suv);

            return FindAll();
        }

        public int Delete(string id)
        {
            var suvId = _suvs.Find(s => s.Nopol.Equals(id));

            if (suvId is not null)
            {
                _suvs.Remove(suvId);
                return 1;
            }

            return 0;
        }

        public List<SUV> FindAll()
        {
            return _suvs;
        }

        public SUV FindById(string id)
        {
            var suvId = _suvs.Find(s => s.Nopol.Equals(id));

            if (suvId is not null)
            {   
                return suvId;
            }

            return null;
        }

        public SUV Update(string id, SUV suv)
        {
            var existSuv = FindById(id);
            var suvIdx = _suvs.FindIndex(s => s.Nopol.Equals(id));

            if (existSuv is not null)
            {
                existSuv.Nopol = suv.Nopol is null ? existSuv.Nopol : suv.Nopol;
                existSuv.Price = suv.Price.Equals(0) ? existSuv.Price : suv.Price;
                existSuv.Tax = suv.Tax.Equals(0) ? existSuv.Tax : suv.Tax;
                existSuv.Seat = suv.Seat.Equals(0) ? existSuv.Seat : suv.Seat;
                existSuv.Year = suv.Year.Equals(0) ? existSuv.Year : suv.Year;
                existSuv.Trans = suv.Trans.Equals(1 / 1 / 0001) ? existSuv.Trans : suv.Trans;
                existSuv.Rent = suv.Rent.Equals(0) ? existSuv.Rent : suv.Rent;
                existSuv.Driver = suv.Rent.Equals(0) ? existSuv.Driver : suv.Driver;

                _suvs[suvIdx] = existSuv;

                return existSuv;
            }
            return existSuv;
        }
    }
}
