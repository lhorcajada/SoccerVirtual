using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lhg.SoccerVirtual.Backend.DomainServices.LeagueDomainService;
using Lhg.SoccerVirtual.Backend.AppServices.LeagueAppService;
using Lhg.SoccerVirtual.Backend.Controllers;
using Rhino.Mocks;
using Lhg.SoccerVirtual.Backend.Models.League;
using System.Web.Script.Serialization;
using Lhg.SoccerVirtual.Backend.DomainServices.ChampionshipTypeDomainService;
using Lhg.SoccerVirtual.Backend.AppServices.ChampionshipTypeAppService;
using System.Linq;
using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;
using System.Diagnostics.CodeAnalysis;
using Lhg.SoccerVirtual.Backend.Exceptions;

namespace Lhg.SoccerVirtual.Backend.Tests.Controllers
{
    /// <summary>
    /// Summary description for ChampionshipTypeTests
    /// </summary>
    ///
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ChampionshipTypeTests
    {
        [TestMethod()]
        [TestCategory("ChampionshipType")]
        public void Integrated_GetChampionshipTypeAll_ReturnNotNull_Test()
        {
            IChampionshipTypeLogic championshipTypeLogic = new ChampionshipTypeLogic();
            IChampionshipTypeService championshipTypeService = new ChampionshipTypeService(championshipTypeLogic);
            ChampionshipTypeController championshipTypeController = new ChampionshipTypeController(championshipTypeService);
            var championshipTypeList = championshipTypeController.GetChampionshipTypes();

            Assert.IsNotNull(championshipTypeList);

        }
        [TestCategory("ChampionshipType")]
        [TestMethod()]
        public void Integrated_GetChampionshipTypeAll_ReturnMajorOfZeroLeagues_Test()
        {
            IChampionshipTypeLogic championshipTypeLogic = new ChampionshipTypeLogic();
            IChampionshipTypeService championshipTypeService = new ChampionshipTypeService(championshipTypeLogic);
            ChampionshipTypeController championshipTypeController = new ChampionshipTypeController(championshipTypeService);
            var championshipTypeList = championshipTypeController.GetChampionshipTypes();

            Assert.IsTrue(championshipTypeList.Count() > 0);

        }
        [TestCategory("ChampionshipType")]
        [TestMethod()]
        public void UnitTest_GetChampionshipTypeAll_CanBeSerializeToJson_Test()
        {
            IChampionshipTypeLogic championshipTypeLogic = MockRepository.GenerateStub<IChampionshipTypeLogic>();
            IChampionshipTypeService championshipTypeService = MockRepository.GenerateStub<IChampionshipTypeService>();
            List<IChampionshipType> mockChampionshipTypeList = new List<IChampionshipType>
            {
                new ClassicChampionship
                {
                    Id = 1,
                    Name = "Clásico"
                },
                new SocialChampionship
                {
                    Id = 2,
                    Name = "Social"
                },
                new ComunioChampionship
                {
                    Id = 3,
                    Name = "Comunio"
                }
            };
            championshipTypeLogic.Stub(x => x.CreateChampionshipTypeList()).Return(mockChampionshipTypeList);
            championshipTypeService.Stub(x => x.GetChampionshipTypeAll()).Return(mockChampionshipTypeList);
            ChampionshipTypeController championshipTypeController = new ChampionshipTypeController(championshipTypeService);
            var championshipTypeList = championshipTypeController.GetChampionshipTypes();

            string expectedChampionshipTypeList = @"[{""Id"":1,""Name"":""Clásico""},{""Id"":2,""Name"":""Social""},{""Id"":3,""Name"":""Comunio""}]";
            var jsonSerialiser = new JavaScriptSerializer();
            var jsonList = jsonSerialiser.Serialize(championshipTypeList);

            Assert.AreEqual(expectedChampionshipTypeList, jsonList);

        }
        [TestMethod()]
        [TestCategory("ChampionshipType")]
        [ExpectedException(typeof(NotHandlerException), "El contenedor de dependencias no ha creado el objeto.")]

        public void UnitTest_GetChampionshipTypeAll_ReturnException_Test()
        {
   
            ChampionshipTypeController championshipTypeController = new ChampionshipTypeController(null);
            var championshipTypeList = championshipTypeController.GetChampionshipTypes();

        }
        [TestMethod()]
        [TestCategory("ChampionshipType")]
        [ExpectedException(typeof(NotHandlerException), "El contenedor de dependencias no ha creado el objeto.")]

        public void UnitTest_ChampionshipTypeService_ReturnException_Test()
        {

            ChampionshipTypeService championshipTypeService = new ChampionshipTypeService(null);

        }
    }
}
