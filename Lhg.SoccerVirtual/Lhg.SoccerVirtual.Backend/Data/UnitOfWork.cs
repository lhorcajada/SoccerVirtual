using Lhg.SoccerVirtual.Backend.Data.Model;
using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using Lhg.SoccerVirtual.Backend.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataFactory _dataFactory;
        private SoccerVirtualContext _soccerVirtualContext;

        protected SoccerVirtualContext SoccerVirtualContext
        {
            get { return _soccerVirtualContext ?? _dataFactory.GetSoccerVirtualContext(); }
            
        }


        public UnitOfWork(IDataFactory dataFactory)
        {
            if (dataFactory == null)
                throw new NotHandlerException(Resources.ErrorMessages.IOCNoCreatedObject);
        }
        public void Commit()
        {
            _soccerVirtualContext.SaveChanges();
        }
        public async Task<int> CommitAsync()
        {
            return await _soccerVirtualContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            this._soccerVirtualContext = null;
        }
    }
}