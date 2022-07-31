using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Notifications;
using Cadastro_De_Produtos.Business.Servicecs;
using Cadastro_De_Produtos.Data.Context;
using Cadastro_De_Produtos.Data.Repository;
using Cadastro_De_Produtos.Identity.Exensions;

namespace Cadastro_De_Produtos.Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IExampleRepository, ExampleRepository>();
            services.AddScoped<IExampleService, ExampleService>();
            


            services.AddScoped<INotificator, Notificator>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            return services;
        }
    }
}
