﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lhg.SoccerVirtual.Backend.Models;
using Lhg.SoccerVirtual.Backend.DomainServices.ChampionshipService;

namespace Lhg.SoccerVirtual.Backend.DomainServices
{
    public class ChampionshipLogic : IChampionshipLogic
    {
        public ChampionshipLogic()
        {
        }
        public void CreateChampionship(ApplicationUser user, Championship championshipToCreate)
        {
            

        }

        public void DeleteChampionship(ApplicationUser user, string password)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Championship> GetChampionshipById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Championship> GetChampionshipByName(string name)
        {
            throw new NotImplementedException();
        }

        public void JoinChampionship(ApplicationUser user, string password)
        {
            throw new NotImplementedException();
        }
    }
}