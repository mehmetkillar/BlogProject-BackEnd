using Microsoft.Extensions.DependencyInjection;
using MKProject.UdemyBlog.Business.Concrete;
using MKProject.UdemyBlog.Business.Interfaces;
using MKProject.UdemyBlog.Business.Tools.JWTTool;
using MKProject.UdemyBlog.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using MKProject.UdemyBlog.DataAccess.Interfaces;

namespace MKProject.UdemyBlog.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IGenericDal<>),typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IJwtService, JwtManager>();
        }
    }
}
