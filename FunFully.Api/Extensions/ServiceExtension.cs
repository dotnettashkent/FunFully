using FunFully.Data.IRepositories;
using FunFully.Data.Repositories;
using FunFully.Service.Interfaces;
using FunFully.Service.Services;

namespace FunFully.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IMoneyService, MoneyService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
