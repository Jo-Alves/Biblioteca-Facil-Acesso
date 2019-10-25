namespace Controle_de_livros
{
    partial class FrmBuscarLivroDidatico
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgv_Busca = new System.Windows.Forms.DataGridView();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.cb_Opcao = new System.Windows.Forms.ComboBox();
            this.txt_Dados = new System.Windows.Forms.TextBox();
            this.ColRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEnsino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(581, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 39);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(686, 324);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 39);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgv_Busca
            // 
            this.dgv_Busca.AllowUserToAddRows = false;
            this.dgv_Busca.AllowUserToDeleteRows = false;
            this.dgv_Busca.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Busca.ColumnHeadersHeight = 30;
            this.dgv_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Busca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRegistro,
            this.ColDisciplina,
            this.ColAutor,
            this.ColEnsino,
            this.ColVolume,
            this.ColDataRegistro});
            this.dgv_Busca.Location = new System.Drawing.Point(36, 76);
            this.dgv_Busca.Name = "dgv_Busca";
            this.dgv_Busca.ReadOnly = true;
            this.dgv_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Busca.Size = new System.Drawing.Size(732, 242);
            this.dgv_Busca.TabIndex = 15;
            this.dgv_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Busca_CellClick);
            this.dgv_Busca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Busca_CellDoubleClick);
            this.dgv_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_Busca_DataBindingComplete);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.Location = new System.Drawing.Point(669, 6);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(99, 39);
            this.btn_Pesquisar.TabIndex = 14;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // cb_Opcao
            // 
            this.cb_Opcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Opcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Opcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Opcao.FormattingEnabled = true;
            this.cb_Opcao.Items.AddRange(new object[] {
            "Disciplina",
            "Autor",
            "Volume"});
            this.cb_Opcao.Location = new System.Drawing.Point(527, 13);
            this.cb_Opcao.Name = "cb_Opcao";
            this.cb_Opcao.Size = new System.Drawing.Size(136, 27);
            this.cb_Opcao.TabIndex = 13;
            // 
            // txt_Dados
            // 
            this.txt_Dados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dados.Location = new System.Drawing.Point(36, 13);
            this.txt_Dados.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Dados.Name = "txt_Dados";
            this.txt_Dados.Size = new System.Drawing.Size(484, 26);
            this.txt_Dados.TabIndex = 12;
            this.txt_Dados.TextChanged += new System.EventHandler(this.txt_Dados_TextChanged);
            this.txt_Dados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Dados_KeyDown);
            // 
            // ColRegistro
            // 
            this.ColRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRegistro.DataPropertyName = "N_Registro";
            this.ColRegistro.HeaderText = "Nº Registro";
            this.ColRegistro.Name = "ColRegistro";
            this.ColRegistro.ReadOnly = true;
            this.ColRegistro.Width = 105;
            // 
            // ColDisciplina
            // 
            this.ColDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDisciplina.DataPropertyName = "Disciplina";
            this.ColDisciplina.HeaderText = "Disciplina";
            this.ColDisciplina.Name = "ColDisciplina";
            this.ColDisciplina.ReadOnly = true;
            this.ColDisciplina.Width = 92;
            // 
            // ColAutor
            // 
            this.ColAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColAutor.DataPropertyName = "Autor";
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            this.ColAutor.Width = 69;
            // 
            // ColEnsino
            // 
            this.ColEnsino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEnsino.DataPropertyName = "Ensino";
            this.ColEnsino.HeaderText = "Ensino";
            this.ColEnsino.Name = "ColEnsino";
            this.ColEnsino.ReadOnly = true;
            this.ColEnsino.Width = 74;
            // 
            // ColVolume
            // 
            this.ColVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColVolume.DataPropertyName = "Volume";
            this.ColVolume.HeaderText = "Volume";
            this.ColVolume.Name = "ColVolume";
            this.ColVolume.ReadOnly = true;
            this.ColVolume.Width = 79;
            // 
            // ColDataRegistro
            // 
            this.ColDataRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDataRegistro.DataPropertyName = "Data_Registro";
            this.ColDataRegistro.HeaderText = "Data do Registro";
            this.ColDataRegistro.Name = "ColDataRegistro";
            this.ColDataRegistro.ReadOnly = true;
            this.ColDataRegistro.Width = 137;
            // 
            // FrmBuscarLivroDidatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 369);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgv_Busca);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.cb_Opcao);
            this.Controls.Add(this.txt_Dados);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarLivroDidatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Livro Didático";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBuscarLivroDidatico_FormClosed);
            this.Load += new System.EventHandler(this.FrmPesquisarLivroDidatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgv_Busca;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.ComboBox cb_Opcao;
        private System.Windows.Forms.TextBox txt_Dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEnsino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataRegistro;
    }
}