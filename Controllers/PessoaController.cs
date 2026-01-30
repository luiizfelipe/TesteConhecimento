using TesteConhecimento.Infrastructure.Context;
using TesteConhecimento.Models;
using Microsoft.EntityFrameworkCore;

namespace TesteConhecimento.Controls
{
    public class PessoaController
    {

        public static async Task<List<Pessoa>> GetAllPessoas()
        {
            try
            {
                using var context = new DatabaseContext();

                var pessoas = await context.Pessoa
                   .AsNoTracking()
                     .ToListAsync();
                return pessoas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                return new List<Pessoa>();
            }
        }


        public static async Task SeedAsync()
        {
            try
            {

                using var context = new DatabaseContext();

                context.Pessoa.AddRange(
                    new Pessoa { Nome = "Ana Lima", Telefone = "51 983213312" },
                    new Pessoa { Nome = "Pedro Santos", Telefone = "51 9827412312" }
                );

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir dados: {ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }
    }
}
