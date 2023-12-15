using ListaVeiculos.Business.Negocios.Interface;
using ListaVeiculos.Business.Negocios;
using Ninject.Modules;
using ListaVeiculosData.Repository.Interface;
using ListaVeiculosData.Repository;
using ListaVeiculosData.Crud.Interface;
using ListaVeiculosData.Crud;

namespace ListaVeiculos.Views.Container
{
    public class VeiculoModulo : NinjectModule
    {
        public override void Load()
        {
            Bind<IVeiculoNegocio>().To<VeiculoNegocio>();
            Bind<IVeiculoRepositorio>().To<VeiculoRepositorio>();
            Bind<ICrudGenerico>().To<CrudGenerico>();
        }
        public static VeiculoModulo Create()
        {
            return new VeiculoModulo();
        }
    }
}
