using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TesteConhecimento.Controls;
using TesteConhecimento.Models;

namespace TesteConhecimento.Views
{
    public partial class FrmPessoas : Form
    {
        Pessoa? Pessoa = null;
        bool IsEditMode = false;
        public FrmPessoas(Pessoa? pessoa = null)
        {
            InitializeComponent();
            this.Pessoa = pessoa;
            this.IsEditMode = this.Pessoa != null;

            if(IsEditMode && Pessoa != null)
            {
                txtNome.Text = Pessoa.Nome;
                txtTelefone.Text = Pessoa.Telefone;
            } else { 
                btnExcluir.Enabled = false;
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Pessoa == null)
            {
                this.Pessoa = new Pessoa();
            }
            this.Pessoa.Nome = txtNome.Text;
            this.Pessoa.Telefone = txtTelefone.Text;

            bool result = false;

            if (!IsEditMode)
            {
                result = await PessoaController.AddPessoa(Pessoa);
            }
            else
            {
                result = await PessoaController.UpdatePessoa(Pessoa);
            }

            if (!result)
            {
                MessageBox.Show("Erro ao salvar pessoa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if(!IsEditMode || Pessoa == null)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir esta pessoa?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (confirmResult == DialogResult.Yes)
            {
                if (await PessoaController.DeletePessoa(Pessoa.Id))
                {
                    MessageBox.Show("Pessoa excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir pessoa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
