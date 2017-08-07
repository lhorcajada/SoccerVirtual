using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using Lhg.SoccerVirtual.Backend.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.AppServices.Shared
{
    public class CommitAsync
    {
        public static async Task SetCommitAsync(IUnitOfWork uow)
        {
            try
            {
                var result = await uow.CommitAsync();
                if (result <= 0)
                    throw new BusinessException(Resources.ErrorMessages.ZeroNumberObjectsWrittenToUnderlyingDatabase);

            }
            catch (ObjectDisposedException ex)
            {
                throw new BusinessException(ex.Message, ex.InnerException);

            }
            catch (InvalidOperationException ex)
            {
                throw new BusinessException(ex.Message, ex.InnerException);

            }
            catch (NotSupportedException ex)
            {
                throw new BusinessException(ex.Message, ex.InnerException);

            }
            catch (DbEntityValidationException ex)
            {
                throw new BusinessException(ex.Message, ex.InnerException);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new BusinessException(ex.Message, ex.InnerException);

            }
            catch (DbUpdateException ex)
            {

                throw new BusinessException(ex.Message, ex.InnerException);

            }
            catch (Exception ex)
            {
                throw new BusinessException(ex.Message, ex.InnerException);

            }
        }

    }
}