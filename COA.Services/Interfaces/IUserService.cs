using COA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COA.Services.Implementations
{
    public interface IUserService
    {
        Task<ICollection<User>> GetUsersAsync();
        ICollection<User> GetUsers();
        void GetUsersWithLazyLoading();
    }
}
