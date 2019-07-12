namespace Controle_de_livros
{
    partial class FrmAnaliseUsuarioMaisLeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaliseUsuarioMaisLeu));
            this.dgvBusca = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cb_Opcao = new System.Windows.Forms.ComboBox();
            this.txt_Aluno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_dataFinal = new System.Windows.Forms.DateTimePicker();
            this.dt_DataInicial = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusca
            // 
            this.dgvBusca.AllowUserToAddRows = false;
            this.dgvBusca.AllowUserToDeleteRows = false;
            this.dgvBusca.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusca.ColumnHeadersHeight = 30;
            this.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBusca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2});
            this.dgvBusca.Location = new System.Drawing.Point(98, 119);
            this.dgvBusca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBusca.Name = "dgvBusca";
            this.dgvBusca.ReadOnly = true;
            this.dgvBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusca.Size = new System.Drawing.Size(797, 419);
            this.dgvBusca.TabIndex = 0;
            this.dgvBusca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBusca_DataBindingComplete);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Cod_Usuario";
            this.Column5.HeaderText = "Código do Usuário";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 157;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Nome_Usuario";
            this.Column1.HeaderText = "Aluno";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Ano";
            this.Column3.HeaderText = "Ano";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 61;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Turma";
            this.Column4.HeaderText = "Turma";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 77;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Quantidade";
            this.Column2.HeaderText = "Quantidade de Livros lidos";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 213;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.Location = new System.Drawing.Point(870, 41);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(99, 35);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cb_Opcao
            // 
            this.cb_Opcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Opcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Opcao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cb_Opcao.FormattingEnabled = true;
            this.cb_Opcao.Items.AddRange(new object[] {
            "Aluno",
            "Turma",
            "Ano"});
            this.cb_Opcao.Location = new System.Drawing.Point(28, 34);
            this.cb_Opcao.Name = "cb_Opcao";
            this.cb_Opcao.Size = new System.Drawing.Size(121, 27);
            this.cb_Opcao.TabIndex = 2;
            this.cb_Opcao.SelectedIndexChanged += new System.EventHandler(this.cb_Opcao_SelectedIndexChanged);
            this.cb_Opcao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Opcao_KeyDown);
            // 
            // txt_Aluno
            // 
            this.txt_Aluno.Location = new System.Drawing.Point(547, 46);
            this.txt_Aluno.Name = "txt_Aluno";
            this.txt_Aluno.Size = new System.Drawing.Size(317, 26);
            this.txt_Aluno.TabIndex = 3;
            this.txt_Aluno.TextChanged += new System.EventHandler(this.txt_Aluno_TextChanged);
            this.txt_Aluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Aluno_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Opcao);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(375, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Pesquisar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dt_dataFinal);
            this.groupBox2.Controls.Add(this.dt_DataInicial);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por período:";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Pesquisar.Location = new System.Drawing.Point(233, 48);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(99, 35);
            this.btn_Pesquisar.TabIndex = 4;
            this.btn_Pesquisar.Text = "Buscar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(130, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicial:";
            // 
            // dt_dataFinal
            // 
            this.dt_dataFinal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dt_dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dataFinal.Location = new System.Drawing.Point(125, 50);
            this.dt_dataFinal.Name = "dt_dataFinal";
            this.dt_dataFinal.Size = new System.Drawing.Size(102, 26);
            this.dt_dataFinal.TabIndex = 1;
            // 
            // dt_DataInicial
            // 
            this.dt_DataInicial.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dt_DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DataInicial.Location = new System.Drawing.Point(17, 50);
            this.dt_DataInicial.Name = "dt_DataInicial";
            this.dt_DataInicial.Size = new System.Drawing.Size(102, 26);
            this.dt_DataInicial.TabIndex = 0;
            // 
            // FrmAnaliseUsuarioMaisLeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Aluno);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dgvBusca);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAnaliseUsuarioMaisLeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Alunos letrados";
            this.Load += new System.EventHandler(this.FrmAnaliseUsuarioMaisLeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cb_Opcao;
        private System.Windows.Forms.TextBox txt_Aluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_dataFinal;
        private System.Windows.Forms.DateTimePicker dt_DataInicial;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}