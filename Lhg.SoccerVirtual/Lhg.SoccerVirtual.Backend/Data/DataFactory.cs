using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lhg.SoccerVirtual.Backend.Data.Model;

namespace Lhg.SoccerVirtual.Backend.Data
{
    public class DataFactory : IDisposable, IDataFactory
    {
        private SoccerVirtualContext _soccerVirtualContext;
     
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public SoccerVirtualContext GetSoccerVirtualContext()
        {
            
            return _soccerVirtualContext ?? (_soccerVirtualContext = new SoccerVirtualContext());
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
            
            if (this._soccerVirtualContext == null)
            {
                return;
            }

            this._soccerVirtualContext.Dispose();
            this._soccerVirtualContext = null;
        }
    }
}