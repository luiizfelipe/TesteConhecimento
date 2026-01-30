using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteConhecimento.Models;

namespace TesteConhecimento.Infrastructure.Mapping
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoas");

            builder.HasKey(e => e.Id); //Auto incremento inplicito
            builder.Property(e => e.Nome).HasMaxLength(100);
            builder.Property(e => e.Telefone).HasMaxLength(100);
        }
    }
}
