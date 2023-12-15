using ListaVeiculosData.Crud;
using ListaVeiculosData.Crud.Interface;
using ListaVeiculosData.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ListaVeiculosData.Repository.Container
{
    public static class RepositorioContainer
    {
        public static IServiceCollection AddRepositorio(this IServiceCollection services)
        {
            services.AddTransient<IVeiculoRepositorio, VeiculoRepositorio>();
            services.AddTransient<ICrudGenerico, CrudGenerico>();

            return services;
        }
    }
}
