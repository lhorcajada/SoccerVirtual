using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.DomainServices.DataContracts
{
    public interface IRepository<TModel> where TModel : class
    {
        IQueryable<TModel> GetAll();
        void Add(TModel entityToAdd);
        void Update(TModel entityToUpdate);
        void Delete(TModel entityToDelete);

    }
}
