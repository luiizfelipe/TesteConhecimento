using Microsoft.EntityFrameworkCore;
using TesteConhecimento.Infrastructure.Mapping;
using TesteConhecimento.Models;


namespace TesteConhecimento.Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        private string ConnectionString = "server=localhost;database=teste_cadastros;user=MySQLUser;password=MySqlPassword;";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(
                ConnectionString,
                ServerVersion.AutoDetect(ConnectionString)
            );

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(new PessoaMapping().Configure);
        }
    }
}
