﻿using Lhg.SoccerVirtual.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.DomainServices.Contracts
{
    interface IChampionshipLogic
    {
        void CreateChampionship(Championship championshipToCreate);
        void JoinChampionship(ApplicationUser user, string password);
        IQueryable<Championship> GetChampionshipByName(string name);
        IQueryable<Championship> GetChampionshipById(int id);
        void DeleteChampionship(ApplicationUser user, string password);
    }
}