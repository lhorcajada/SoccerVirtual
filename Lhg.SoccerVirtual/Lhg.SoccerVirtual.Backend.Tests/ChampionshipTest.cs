using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lhg.SoccerVirtual.Backend.DomainServices.UserDomainService;
using Rhino.Mocks;
using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using Lhg.SoccerVirtual.Backend.Models;
using System.Threading.Tasks;
using Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService;
using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;
using Lhg.SoccerVirtual.Backend.Models.League;
using Lhg.SoccerVirtual.Backend.Models.PointSystems;
using Lhg.SoccerVirtual.Backend.Exceptions;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using Lhg.SoccerVirtual.Backend.Controllers;
using System.Net.Http;

namespace Lhg.SoccerVirtual.Backend.Tests
{
    [TestClass]
    public class ChampionshipTest
    {
        IUserLogic _userLogic;
        IChampionshipRepository _championshipRepository;
        IUnitOfWork _uow;
        ApplicationUser _appUserReturn;
        Championship championshipToAdd;

        [TestInitialize()]
        private void Initialize()
        {
            _userLogic = MockRepository.GenerateStub<IUserLogic>();
            _championshipRepository = MockRepository.GenerateStub<IChampionshipRepository>();
            _uow = MockRepository.GenerateStub<IUnitOfWork>();

        }
        private void CreateUser()
        {
            _appUserReturn = new ApplicationUser
            {
                Id = 1,
                Alias = "User1"
            };

        }
        private void CreateChampionshipToAdd()
        {
            championshipToAdd = new Championship
            {
                Id = 1,
                AppUser = _appUserReturn,
                AppUserId = _appUserReturn.Id,
                Budget = 300000000,
                ChampionshipTypeName = "Clásico",
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                LeagueName = "Liga Santander",
                Name = "Futmonditos",
                PointSystemName = "Estadísticas"
            };
        }
        private void CreateChampionshipToAddWithEmptyName()
        {
            championshipToAdd = new Championship
            {
                Id = 1,
                AppUser = _appUserReturn,
                AppUserId = _appUserReturn.Id,
                Budget = 300000000,
                ChampionshipTypeName = "Clásico",
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                LeagueName = "Liga Santander",
                Name = "",
                PointSystemName = "Estadísticas"
            };
        }
        [TestMethod]
        [TestCategory("Championship")]
        public async Task UnitTest_Controller_Championship_Create_IsSuccesfully()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAdd();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Return(Task.FromResult<int>(1));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "Futmonditos",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };
            IChampionshipService service = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            ChampionshipController controller = new ChampionshipController(service);
            await controller.CreateChampionship(championshipFromClient);
            

        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(NotHandlerException), "El contenedor de dependencias no ha creado el objeto.")]
        public void UnitTest_Controller_Championship_Create_ThrowNotHandlerException()
        {
            ChampionshipController controller = new ChampionshipController(null);

        }


        [TestMethod]
        [TestCategory("Championship")]
        public async Task UnitTest_Championship_Create_IsSuccesfully()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAdd();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Return(Task.FromResult<int>(1));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "Futmonditos",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },
           
            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(BusinessException), "El número de objetos escritos en base de datos ha sido cero.")]
        public async Task UnitTest_Championship_Create_CommitZero_ThrowBusinessExceptionToCommit()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAdd();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Return(Task.FromResult<int>(0));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "Futmonditos",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(BusinessException), "Debe introducir un nombre más largo")]
        public async Task UnitTest_Championship_Create_EmptyName_ThrowBusinessException()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAddWithEmptyName();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Throw(new DbEntityValidationException("Debe introducir un nombre más largo"));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(BusinessException), "No se puede obtener acceso al objeto desechado.")]
        public async Task UnitTest_Championship_Create_ObjectDisposed_ThrowBusinessException()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAddWithEmptyName();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Throw(new ObjectDisposedException("No se puede obtener acceso al objeto desechado."));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(BusinessException), "")]
        public async Task UnitTest_Championship_Create_InvalidOperationException_ThrowBusinessException()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAddWithEmptyName();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Throw(new InvalidOperationException(""));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(BusinessException), "")]
        public async Task UnitTest_Championship_Create_NotSupportedException_ThrowBusinessException()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAddWithEmptyName();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Throw(new NotSupportedException(""));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(BusinessException), "")]
        public async Task UnitTest_Championship_Create_DbUpdateConcurrencyException_ThrowBusinessException()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAddWithEmptyName();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Throw(new DbUpdateConcurrencyException(""));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }
        [TestMethod]
        [TestCategory("Championship")]
        [ExpectedException(typeof(BusinessException), "")]
        public async Task UnitTest_Championship_Create_DbUpdateException_ThrowBusinessException()
        {
            Initialize();
            CreateUser();
            CreateChampionshipToAddWithEmptyName();
            _userLogic.Stub(x => x.GetUserData()).Return(_appUserReturn);
            _championshipRepository.Stub(x => x.Add(championshipToAdd));
            _uow.Stub(x => x.CommitAsync()).Throw(new DbUpdateException(""));

            ChampionshipDto championshipFromClient = new ChampionshipDto
            {
                Id = 1,
                AppUserId = 1,
                Budget = 300000000,
                ChampionshipType = new ClassicChampionship { Id = 1, Name = "Clásico" },
                DiscountBudgetTeamValue = true,
                InitialPlayers = 20,
                IsPrivate = true,
                League = new FirstDivisionSpanish { Id = 1, Name = "Liga Santander" },
                Name = "",
                PointSystem = new StatisticsPointSystem { Id = 1, Name = "Estadísticas" },

            };

            IChampionshipService championshipService = new ChampionshipService(_userLogic, _championshipRepository, _uow);
            await championshipService.CreateChampionship(championshipFromClient);
        }

    }
}
