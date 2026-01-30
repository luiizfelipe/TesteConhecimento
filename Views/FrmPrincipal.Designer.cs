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
            btnPopulate = new Button();
            btnRefreshGrid = new Button();
            btnAddPessoa = new Button();
            btnReport = new Button();
            label1 = new Label();
            dgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // btnPopulate
            // 
            btnPopulate.Anchor = AnchorStyles.None;
            btnPopulate.BackColor = Color.FromArgb(0, 133, 250);
            btnPopulate.FlatAppearance.BorderColor = Color.Blue;
            btnPopulate.FlatStyle = FlatStyle.Flat;
            btnPopulate.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnPopulate.ForeColor = Color.White;
            btnPopulate.Location = new Point(164, 384);
            btnPopulate.Margin = new Padding(0);
            btnPopulate.Name = "btnPopulate";
            btnPopulate.Size = new Size(105, 45);
            btnPopulate.TabIndex = 3;
            btnPopulate.Text = "POPULAR";
            btnPopulate.UseVisualStyleBackColor = false;
            btnPopulate.Click += btnPopulate_Click;
            // 
            // btnRefreshGrid
            // 
            btnRefreshGrid.Anchor = AnchorStyles.None;
            btnRefreshGrid.BackColor = Color.FromArgb(0, 133, 250);
            btnRefreshGrid.FlatAppearance.BorderColor = Color.Blue;
            btnRefreshGrid.FlatStyle = FlatStyle.Flat;
            btnRefreshGrid.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRefreshGrid.ForeColor = Color.White;
            btnRefreshGrid.Location = new Point(164, 75);
            btnRefreshGrid.Name = "btnRefreshGrid";
            btnRefreshGrid.Size = new Size(219, 45);
            btnRefreshGrid.TabIndex = 4;
            btnRefreshGrid.Text = "RECARREGAR TABELA";
            btnRefreshGrid.UseVisualStyleBackColor = false;
            btnRefreshGrid.Click += btnRefreshGrid_Click;
            // 
            // btnAddPessoa
            // 
            btnAddPessoa.Anchor = AnchorStyles.None;
            btnAddPessoa.BackColor = Color.FromArgb(0, 133, 250);
            btnAddPessoa.FlatStyle = FlatStyle.Flat;
            btnAddPessoa.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnAddPessoa.ForeColor = Color.White;
            btnAddPessoa.Location = new Point(443, 384);
            btnAddPessoa.Name = "btnAddPessoa";
            btnAddPessoa.Size = new Size(219, 45);
            btnAddPessoa.TabIndex = 5;
            btnAddPessoa.Text = "ADICIONAR PESSOA";
            btnAddPessoa.UseVisualStyleBackColor = false;
            btnAddPessoa.Click += btnAddPessoa_Click;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.None;
            btnReport.BackColor = Color.FromArgb(0, 133, 250);
            btnReport.FlatAppearance.BorderColor = Color.Blue;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(505, 75);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(157, 45);
            btnReport.TabIndex = 6;
            btnReport.Text = "RELATÓRIO";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 133, 250);
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 45);
            label1.TabIndex = 7;
            label1.Text = "Gerenciamento de Pessoas";
            // 
            // dgView
            // 
            dgView.Anchor = AnchorStyles.None;
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(164, 170);
            dgView.Name = "dgView";
            dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgView.Size = new Size(498, 150);
            dgView.TabIndex = 8;
            dgView.CellClick += dgView_CellClick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 523);
            Controls.Add(dgView);
            Controls.Add(label1);
            Controls.Add(btnReport);
            Controls.Add(btnAddPessoa);
            Controls.Add(btnRefreshGrid);
            Controls.Add(btnPopulate);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Pessoas";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPopulate;
        private Button btnRefreshGrid;
        private Button btnAddPessoa;
        private Button btnReport;
        private Label label1;
        private DataGridView dgView;
    }
}
