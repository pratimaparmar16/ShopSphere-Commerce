using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
