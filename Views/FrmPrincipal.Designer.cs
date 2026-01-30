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
            dgView = new DataGridView();
            btnPopulate = new Button();
            btnRefreshGrid = new Button();
            btnAddPessoa = new Button();
            btnReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // dgView
            // 
            dgView.Anchor = AnchorStyles.None;
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(207, 107);
            dgView.Name = "dgView";
            dgView.Size = new Size(498, 217);
            dgView.TabIndex = 2;
            dgView.CellClick += dgView_CellClick;
            // 
            // btnPopulate
            // 
            btnPopulate.Anchor = AnchorStyles.None;
            btnPopulate.BackColor = Color.FromArgb(0, 133, 250);
            btnPopulate.FlatAppearance.BorderColor = Color.Blue;
            btnPopulate.FlatStyle = FlatStyle.Flat;
            btnPopulate.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnPopulate.ForeColor = Color.White;
            btnPopulate.Location = new Point(207, 340);
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
            btnRefreshGrid.Location = new Point(207, 31);
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
            btnAddPessoa.Location = new Point(486, 340);
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
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(548, 31);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(157, 45);
            btnReport.TabIndex = 6;
            btnReport.Text = "RELATÓRIO";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 528);
            Controls.Add(btnReport);
            Controls.Add(btnAddPessoa);
            Controls.Add(btnRefreshGrid);
            Controls.Add(btnPopulate);
            Controls.Add(dgView);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgView;
        private Button btnPopulate;
        private Button btnRefreshGrid;
        private Button btnAddPessoa;
        private Button btnReport;
    }
}
