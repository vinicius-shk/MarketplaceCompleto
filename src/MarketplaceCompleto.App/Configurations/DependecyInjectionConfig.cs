using MarketplaceCompleto.App.Extensions;
using MarketplaceCompleto.Business.Interfaces;
using MarketplaceCompleto.Business.Notifications;
using MarketplaceCompleto.Business.Services;
using MarketplaceCompleto.Data.Context;
using MarketplaceCompleto.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace MarketplaceCompleto.App.Configurations
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<MarketplaceDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
