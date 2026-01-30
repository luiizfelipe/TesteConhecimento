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
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 13F);
            lblNome.Location = new Point(61, 88);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtNome.Location = new Point(148, 88);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(502, 27);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.Font = new Font("Segoe UI", 13F);
            txtTelefone.Location = new Point(148, 138);
            txtTelefone.MaxLength = 100;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(502, 31);
            txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.None;
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 13F);
            lblTelefone.Location = new Point(61, 141);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(81, 25);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.None;
            btnSalvar.BackColor = Color.FromArgb(0, 133, 250);
            btnSalvar.FlatAppearance.BorderColor = Color.Blue;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(62, 193);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 50);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.None;
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(178, 193);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 50);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.None;
            btnFechar.BackColor = Color.FromArgb(0, 133, 250);
            btnFechar.FlatAppearance.BorderColor = Color.Blue;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(540, 193);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(110, 50);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F);
            lblTitle.Location = new Point(61, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 45);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "TITULO";
            // 
            // FrmPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 293);
            Controls.Add(lblTitle);
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
        private Label lblTitle;
    }
}