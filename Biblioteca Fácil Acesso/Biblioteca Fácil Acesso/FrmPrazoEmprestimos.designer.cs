namespace Controle_de_livros
{
    partial class FrmPrazoEmprestimos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrazoEmprestimos));
            this.dgvPrazosEmprestimos = new System.Windows.Forms.DataGridView();
            this.ColRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrazoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOcupacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrazosEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrazosEmprestimos
            // 
            this.dgvPrazosEmprestimos.AllowUserToAddRows = false;
            this.dgvPrazosEmprestimos.AllowUserToDeleteRows = false;
            this.dgvPrazosEmprestimos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrazosEmprestimos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrazosEmprestimos.ColumnHeadersHeight = 30;
            this.dgvPrazosEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrazosEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRegistro,
            this.ColTitulo,
            this.ColDataSolicitacao,
            this.ColPrazoEntrega,
            this.ColNome,
            this.ColAno,
            this.ColTurma,
            this.ColOcupacao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrazosEmprestimos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrazosEmprestimos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrazosEmprestimos.Location = new System.Drawing.Point(0, 0);
            this.dgvPrazosEmprestimos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrazosEmprestimos.MultiSelect = false;
            this.dgvPrazosEmprestimos.Name = "dgvPrazosEmprestimos";
            this.dgvPrazosEmprestimos.ReadOnly = true;
            this.dgvPrazosEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrazosEmprestimos.Size = new System.Drawing.Size(800, 520);
            this.dgvPrazosEmprestimos.TabIndex = 0;
            this.dgvPrazosEmprestimos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrazosEmprestimos_CellClick);
            this.dgvPrazosEmprestimos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrazosEmprestimos_CellDoubleClick);
            // 
            // ColRegistro
            // 
            this.ColRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRegistro.DataPropertyName = "N_Registro";
            this.ColRegistro.HeaderText = "Registro";
            this.ColRegistro.Name = "ColRegistro";
            this.ColRegistro.ReadOnly = true;
            this.ColRegistro.Width = 84;
            // 
            // ColTitulo
            // 
            this.ColTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTitulo.DataPropertyName = "Titulo";
            this.ColTitulo.HeaderText = "Tìtulo";
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            this.ColTitulo.Width = 68;
            // 
            // ColDataSolicitacao
            // 
            this.ColDataSolicitacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDataSolicitacao.DataPropertyName = "Data_Solicitacao";
            this.ColDataSolicitacao.HeaderText = "Data de Solicitação";
            this.ColDataSolicitacao.Name = "ColDataSolicitacao";
            this.ColDataSolicitacao.ReadOnly = true;
            this.ColDataSolicitacao.Width = 152;
            // 
            // ColPrazoEntrega
            // 
            this.ColPrazoEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPrazoEntrega.DataPropertyName = "Prazo_Entrega";
            this.ColPrazoEntrega.HeaderText = "Prazo de Entrega";
            this.ColPrazoEntrega.Name = "ColPrazoEntrega";
            this.ColPrazoEntrega.ReadOnly = true;
            this.ColPrazoEntrega.Width = 138;
            // 
            // ColNome
            // 
            this.ColNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNome.DataPropertyName = "Nome_Usuario";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 72;
            // 
            // ColAno
            // 
            this.ColAno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColAno.HeaderText = "Ano";
            this.ColAno.Name = "ColAno";
            this.ColAno.ReadOnly = true;
            this.ColAno.Width = 60;
            // 
            // ColTurma
            // 
            this.ColTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTurma.HeaderText = "Turma";
            this.ColTurma.Name = "ColTurma";
            this.ColTurma.ReadOnly = true;
            this.ColTurma.Width = 72;
            // 
            // ColOcupacao
            // 
            this.ColOcupacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColOcupacao.HeaderText = "Ocupação";
            this.ColOcupacao.Name = "ColOcupacao";
            this.ColOcupacao.ReadOnly = true;
            this.ColOcupacao.Width = 97;
            // 
            // FrmPrazoEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.dgvPrazosEmprestimos);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrazoEmprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrazosEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrazosEmprestimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrazoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOcupacao;
    }
}