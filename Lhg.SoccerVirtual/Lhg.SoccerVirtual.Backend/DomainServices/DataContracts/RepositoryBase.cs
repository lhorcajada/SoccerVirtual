using Lhg.SoccerVirtual.Backend.Data;
using Lhg.SoccerVirtual.Backend.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.DomainServices.DataContracts
{
    public abstract class RepositoryBase<T> : IRepository<T>, IDisposable where T : class
    {
        private readonly IDbSet<T> _dbset;
        private SoccerVirtualContext _soccerVirtualContext;
        protected RepositoryBase(IDataFactory dataFactory)
        {
            _soccerVirtualContext = dataFactory.GetSoccerVirtualContext();
            _dbset = _soccerVirtualContext.Set<T>();
        }
        public void Add(T entityToAdd)
        {
            _dbset.Add(entityToAdd);
        }

        public void Delete(T entityToDelete)
        {
            _dbset.Remove(entityToDelete);
        }

        public void Dispose()
        {
            
        }

        public IQueryable<T> GetAll()
        {
            return _dbset.AsNoTracking().AsQueryable();
        }

        public void Update(T entityToUpdate)
        {
            _dbset.Attach(entityToUpdate);
            _soccerVirtualContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}