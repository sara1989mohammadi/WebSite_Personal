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
        IBiographyRepository biography { get; }
        IBookRepository book { get; }
        ICVRepository cv { get; }
        IShortArticleRepository shortArticle { get; }
        void Execute();
    }
}
