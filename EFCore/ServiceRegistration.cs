using Contracts;
using Contracts.Repositories;
using EFCore.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace EFCore
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IActivityRepository, ActivityRepository>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IBiographyRepository, BiographyRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<ICVRepository, CVRepository>();
            services.AddTransient<IShortArticleRepository, ShortArticleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
