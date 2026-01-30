namespace TesteConhecimento
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loading = new Label();
            dgView = new DataGridView();
            btnPopulate = new Button();
            btnRefreshGrid = new Button();
            btnAddPessoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // loading
            // 
            loading.AutoSize = true;
            loading.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            loading.Location = new Point(648, 396);
            loading.Name = "loading";
            loading.Size = new Size(101, 19);
            loading.TabIndex = 0;
            loading.Text = "Carregando...";
            // 
            // dgView
            // 
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(12, 93);
            dgView.Name = "dgView";
            dgView.Size = new Size(737, 262);
            dgView.TabIndex = 2;
            dgView.CellClick += dgView_CellClick;
            // 
            // btnPopulate
            // 
            btnPopulate.BackColor = Color.Lime;
            btnPopulate.ForeColor = Color.ForestGreen;
            btnPopulate.Location = new Point(21, 392);
            btnPopulate.Name = "btnPopulate";
            btnPopulate.Size = new Size(75, 23);
            btnPopulate.TabIndex = 3;
            btnPopulate.Text = "POPULAR";
            btnPopulate.UseVisualStyleBackColor = false;
            btnPopulate.Click += btnPopulate_Click;
            // 
            // btnRefreshGrid
            // 
            btnRefreshGrid.Location = new Point(116, 392);
            btnRefreshGrid.Name = "btnRefreshGrid";
            btnRefreshGrid.Size = new Size(132, 23);
            btnRefreshGrid.TabIndex = 4;
            btnRefreshGrid.Text = "Recarregar Tabela";
            btnRefreshGrid.UseVisualStyleBackColor = true;
            btnRefreshGrid.Click += btnRefreshGrid_Click;
            // 
            // btnAddPessoa
            // 
            btnAddPessoa.Location = new Point(21, 37);
            btnAddPessoa.Name = "btnAddPessoa";
            btnAddPessoa.Size = new Size(75, 23);
            btnAddPessoa.TabIndex = 5;
            btnAddPessoa.Text = "Inserir";
            btnAddPessoa.UseVisualStyleBackColor = true;
            btnAddPessoa.Click += btnAddPessoa_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddPessoa);
            Controls.Add(btnRefreshGrid);
            Controls.Add(btnPopulate);
            Controls.Add(dgView);
            Controls.Add(loading);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loading;
        private DataGridView dgView;
        private Button btnPopulate;
        private Button btnRefreshGrid;
        private Button btnAddPessoa;
    }
}
