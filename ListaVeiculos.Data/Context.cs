using Microsoft.EntityFrameworkCore;

namespace ListaVeiculos.Data
{
    public class Context : DbContext
    {
        private static string _servidor = "localhost";
        private static string _bancoDados = "lista_veiculos";
        private static string _usuario = "root";
        private static string _senha = "root";

        private static string cadeiaConexao = $@"server={_servidor};
                                                database={_bancoDados};
                                                user={_usuario};
                                                password={_senha};";

        public Context() : this(new DbContextOptions<Context>())
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Veiculo> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        optionsBuilder.UseMySql(cadeiaConexao,
                                    new MySqlServerVersion(new Version(5, 5, 13)));

            base.OnConfiguring(optionsBuilder);
        }
    }
}