﻿using JuraganMobilSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobilSolution.Repo
{
   internal interface ITaxiRepo
    {
        List<Taxi> FindAll();
        Taxi FindById(string id);
        List<Taxi> Create(Taxi taxi);
        Taxi Update(string id, Taxi  taxi);
        int Delete(string id);
    }
}
