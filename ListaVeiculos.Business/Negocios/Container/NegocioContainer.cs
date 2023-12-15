using ListaVeiculos.Business.Negocios;
using ListaVeiculos.Business.Negocios.Interface;
using ListaVeiculos.Services.Negocios.Container;
using Microsoft.Extensions.DependencyInjection;

namespace ListaVeiculos.Services.Business.Container
{
    public static class NegocioContainer
    {
        public static IServiceCollection AddNegocio(this IServiceCollection services)
        {
            services.AddTransient<IVeiculoNegocio, VeiculoNegocio>();
            services.AddAutoMapper(typeof(MapeamentoContainer));

            return services;
        }
    }
}
