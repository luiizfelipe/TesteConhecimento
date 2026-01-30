using Microsoft.EntityFrameworkCore;
using TesteConhecimento.Infrastructure.Mapping;
using TesteConhecimento.Models;


namespace TesteConhecimento.Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(
                "server=localhost;database=teste_cadastros;user=MySQLUser;password=MySqlPassword;",
                ServerVersion.AutoDetect("server=localhost;database=TesteConhecimento;user=MySQLUser;password=MySqlPassword;")
            );

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(new PessoaMapping().Configure);
        }
    }
}
