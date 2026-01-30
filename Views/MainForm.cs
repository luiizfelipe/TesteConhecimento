using TesteConhecimento.Infrastructure.Context;

namespace TesteConhecimento
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Shown += async (s, e) => _ = CheckConnectionDatabase();

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
    }
}
