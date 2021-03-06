﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.DomainServices.DataContracts
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
        Task<int> CommitAsync();
    }
}
