using Microsoft.EntityFrameworkCore;

namespace ListaVeiculos.Data
{
    public class Contexto : DbContext
    {
        private static string _servidor = "localhost";
        private static string _bancoDados = "lista_veiculos";
        private static string _usuario = "root";
        private static string _senha = "root";

        private static string CadeiaConexao =>
            $"server={_servidor};database={_bancoDados};user={_usuario};password={_senha};";

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<RegistroLogin> RegistroUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(CadeiaConexao, new MySqlServerVersion(new Version(5, 5, 13)));
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
