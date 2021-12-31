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
            biography = biographyRepository;
            book = bookRepository;
            cv = cvRepository;
            shortArticle = shortArticleRepository;
            Users = userRepository;
        }

        public IActivityRepository Activity { get; }

        public IArticleRepository Article { get; }

        public IBiographyRepository biography { get; }

        public IBookRepository book { get; }

        public ICVRepository cv { get; }

        public IShortArticleRepository shortArticle { get; }
        public IUserRepository Users { get; }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
