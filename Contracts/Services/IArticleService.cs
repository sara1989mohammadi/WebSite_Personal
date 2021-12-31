using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
 public   interface IArticleService
    {
        Task GetById(int id);
        Task GetAll();
        Task Add(Article article);
        Task Update(Article article);
        Task Delete(int id);
    }
}
