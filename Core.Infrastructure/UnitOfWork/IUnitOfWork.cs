using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        void ResetCurrentContext();
    }
}
