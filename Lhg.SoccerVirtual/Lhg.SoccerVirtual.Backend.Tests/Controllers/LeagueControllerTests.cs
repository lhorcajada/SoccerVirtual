﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lhg.SoccerVirtual.Backend.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lhg.SoccerVirtual.Backend.AppServices.LeagueAppService;
using Lhg.SoccerVirtual.Backend.DomainServices.LeagueDomainService;
using System.Web.Script.Serialization;
using Rhino.Mocks;
using Lhg.SoccerVirtual.Backend.Models.League;

namespace Lhg.SoccerVirtual.Backend.Controllers.Tests
{
    [TestClass()]
    public class LeagueControllerTests
    {
        [TestMethod()]
        public void Integrated_GetLeagueAll_ReturnNotNull_Test()
        {
            ILeagueLogic leagueLogic = new LeagueLogic();
            ILeagueService leagueService = new LeagueService(leagueLogic);
            LeagueController leagueController = new LeagueController(leagueService);
            var leagueList = leagueController.GetLeagueAll();

            Assert.IsNotNull(leagueList);

        }
        [TestMethod()]
        public void Integrated_GetLeagueAll_ReturnMajorOfZeroLeagues_Test()
        {
            ILeagueLogic leagueLogic = new LeagueLogic();
            ILeagueService leagueService = new LeagueService(leagueLogic);
            LeagueController leagueController = new LeagueController(leagueService);
            var leagueList = leagueController.GetLeagueAll();

            Assert.IsTrue(leagueList.Count() > 0);

        }
        [TestMethod()]
        public void Unit_GetLeagueAll_CanBeSerializeToJson_Test()
        {
            ILeagueLogic leagueLogic = MockRepository.GenerateStub<ILeagueLogic>();
            ILeagueService leagueService = MockRepository.GenerateStub<ILeagueService>();
            List<ILeague> mockLeagueList = new List<ILeague>
            {
                new FirstDivisionSpanish
                {
                    Id = 1,
                    Name = "Liga Santander"
                },
                new SecondDivisionSpanish
                {
                    Id=2,
                    Name = "Liga 1 | 2 | 3"
                }
            };
            leagueLogic.Stub(x => x.CreateLeagueList()).Return(mockLeagueList);
            leagueService.Stub(x => x.GetLeagueAll()).Return(mockLeagueList);
            LeagueController leagueController = new LeagueController(leagueService);
            var leagueList = leagueController.GetLeagueAll();

            string expectedLeagueList = @"[{""Id"":1,""Name"":""Liga Santander""},{""Id"":2,""Name"":""Liga 1 | 2 | 3""}]";
            var jsonSerialiser = new JavaScriptSerializer();
            var jsonList = jsonSerialiser.Serialize(leagueList);

            Assert.AreEqual(expectedLeagueList, jsonList);

        }

       

    }
}