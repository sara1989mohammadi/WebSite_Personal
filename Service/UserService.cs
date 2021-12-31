using Contracts;
using Contracts.Services;
using Entites;
using System;

namespace Service
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        public void AddUser(Users user)
        {
            unitOfWork.Users.AddAsync(user);           
            unitOfWork.Execute();
        }
    }
}
