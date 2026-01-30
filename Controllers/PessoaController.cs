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

        public static async Task<bool> AddPessoa(Pessoa pessoa)
        {
            try
            {
                using var context = new DatabaseContext();

                context.Pessoa.Add(pessoa);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar pessoa: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static async Task<bool> UpdatePessoa(Pessoa pessoa)
        {
            try
            {
                using var context = new DatabaseContext();

                var pessoaDb = await context.Pessoa.FindAsync(pessoa.Id);
                if (pessoaDb == null)
                    return false;

                pessoaDb.Nome = pessoa.Nome;
                pessoaDb.Telefone = pessoa.Telefone;

                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar pessoa: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static async Task<bool> DeletePessoa(int id)
        {
            try
            {
                using var context = new DatabaseContext();

                var pessoa = await context.Pessoa.FindAsync(id);
                if (pessoa == null)
                    return false;

                context.Pessoa.Remove(pessoa);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover pessoa: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
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
