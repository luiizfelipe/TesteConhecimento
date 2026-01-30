using TesteConhecimento.Controls;
using TesteConhecimento.Infrastructure.Context;
using TesteConhecimento.Models;
using TesteConhecimento.Views;

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

        private async void btnPopulate_Click(object sender, EventArgs e)
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

        private async void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            await CarregarGridViewAsync();

        }

        private async void btnAddPessoa_Click(object sender, EventArgs e)
        {
            using var formAddPessoa = new FrmPessoas();
            var result = formAddPessoa.ShowDialog();
            if (result == DialogResult.OK)
            {
                await CarregarGridViewAsync();
            }

        }

        private async void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignora header

            Pessoa? pessoa = (Pessoa?)dgView.Rows[e.RowIndex].DataBoundItem;
            if (pessoa == null) return;

            using var formAddPessoa = new FrmPessoas(pessoa);
            var result = formAddPessoa.ShowDialog();
            if (result == DialogResult.OK)
            {
                await CarregarGridViewAsync();
            }


        }
    }
}
