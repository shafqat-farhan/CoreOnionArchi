using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COA.Repositories.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : class;
        Task<int> Commit();
        void Rollback();
    }
}
