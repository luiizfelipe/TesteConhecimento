using TesteConhecimento.Controls;
using TesteConhecimento.Infrastructure.Context;
using TesteConhecimento.Models;

namespace TesteConhecimento
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Shown += async (s, e) => await CheckConnectionDatabase();

        }

        internal async Task CheckConnectionDatabase()
        {
            try
            {
                using var context = new DatabaseContext();
                bool connected = await context.Database.CanConnectAsync();
                if (!connected)
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await context.Database.EnsureCreatedAsync(); // Garante que o banco de dados seja criado se não existir.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar com o banco de dados: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task CarregarGridViewAsync()
        {
            try
            {
                var pessoas = await PessoaController.GetAllPessoas();
                dgView.DataSource = pessoas
                .Select(p => new
                {
                    p.Nome,
                    p.Telefone
                })
                .ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await PessoaController.SeedAsync();
            await CarregarGridViewAsync();
            MessageBox.Show("Dados inseridos com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private async void FrmPrincipal_Load(object sender, EventArgs e)
        {
            await CarregarGridViewAsync();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await CarregarGridViewAsync();

        }

        private void btnAddPessoa_Click(object sender, EventArgs e)
        {

        }
    }
}
