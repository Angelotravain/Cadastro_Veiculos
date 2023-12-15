using ListaVeiculos.Views.Container;
using Ninject;

namespace ListaVeiculos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormResolve.Wire(VeiculoModulo.Create());
            Application.Run(FormResolve.Resolve<Principal>());
        }
    }
}
