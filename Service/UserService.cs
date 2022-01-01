using Contracts;
using Contracts.Services;
using Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Add(Users users)
        {
            return await _unitOfWork.Users.AddAsync(users);
            _unitOfWork.Execute();
        }

        public async Task<int> Delete(int id)
        {
            return await _unitOfWork.Users.DeleteAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<IReadOnlyList<Users>> GetAll()
        {
            return await _unitOfWork.Users.GetAllAsync();
            _unitOfWork.Execute();
        }

        public async Task<Users> GetById(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<int> Update(Users users)
        {
            return await _unitOfWork.Users.UpdateAsync(users);
            _unitOfWork.Execute();
        }
    }
}
