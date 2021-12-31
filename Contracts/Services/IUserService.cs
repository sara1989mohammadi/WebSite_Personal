using Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IUserService 
    {
        void AddUser(Users user);
        void AddRole(Role role);
    }
}
