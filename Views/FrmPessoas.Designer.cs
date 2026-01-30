namespace TesteConhecimento.Views
{
    partial class FrmPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(62, 62);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(108, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(502, 23);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(119, 106);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(502, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(62, 109);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(119, 215);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 68);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(254, 215);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 68);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(411, 215);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(128, 68);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FrmPessoas";
            Text = "FrmPessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnFechar;
    }
}