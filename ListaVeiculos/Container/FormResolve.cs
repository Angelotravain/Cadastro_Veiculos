using Ninject;
using Ninject.Modules;

namespace ListaVeiculos.Views.Container
{
    public static class FormResolve
    {
        private static IKernel _ninjectKernel;
        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}
