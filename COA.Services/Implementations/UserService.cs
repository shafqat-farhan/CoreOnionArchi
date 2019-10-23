using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using COA.Models;
using COA.Repositories.Interface;

namespace COA.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ICollection<User>> GetUsersAsync()
        {
            var users = await _unitOfWork.Repository<User>().GetAllAsync();
            return users;
        }

        public ICollection<User> GetUsers()
        {
            var users = _unitOfWork.Repository<User>().GetAll();
            return users;
        }

        public void GetUsersWithLazyLoading()
        {
            var user = _unitOfWork.Repository<User>().FindAll(e => e.UserId == 1);
            foreach (var u in user)
            {
                foreach (var post in u.Post)
                {
                    var postID = post.PostId;
                    var userID = post.UserId;
                }
            }
        }
    }
}
