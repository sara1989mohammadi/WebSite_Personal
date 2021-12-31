using Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IUnitOfWork
    {
        IActivityRepository Activity { get; }
       
        IArticleRepository Article { get; }
        IUserRepository Users { get; }
        IBiographyRepository Biography { get; }
        IBookRepository Book { get; }
        ICVRepository Cv { get; }
        IShortArticleRepository ShortArticle { get; }
        void Execute();
    }
}
