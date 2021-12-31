using Contracts;
using Contracts.Repositories;
using System;

namespace EFCore
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
           IActivityRepository activityRepository,
           IArticleRepository articleRepository,
           IBiographyRepository biographyRepository,
           IBookRepository bookRepository,
           ICVRepository cvRepository,
           IShortArticleRepository shortArticleRepository,
           IUserRepository userRepository)
        {

            Activity = activityRepository;
            Article = articleRepository;
            Biography = biographyRepository;
            Book = bookRepository;
            Cv = cvRepository;
            ShortArticle = shortArticleRepository;
            Users = userRepository;
        }

        public IActivityRepository Activity { get; }

        public IArticleRepository Article { get; }

        public IBiographyRepository Biography { get; }

        public IBookRepository Book { get; }

        public ICVRepository Cv { get; }

        public IShortArticleRepository ShortArticle { get; }
        public IUserRepository Users { get; }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
