namespace Controle_de_livros
{
    partial class FrmBuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarUsuario));
            this.txt_Dados = new System.Windows.Forms.TextBox();
            this.cb_Opcao = new System.Windows.Forms.ComboBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.dgv_Busca = new System.Windows.Forms.DataGridView();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOcupacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Dados
            // 
            this.txt_Dados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dados.Location = new System.Drawing.Point(25, 29);
            this.txt_Dados.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Dados.Name = "txt_Dados";
            this.txt_Dados.Size = new System.Drawing.Size(497, 26);
            this.txt_Dados.TabIndex = 0;
            this.txt_Dados.TextChanged += new System.EventHandler(this.txt_Dados_TextChanged);
            this.txt_Dados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Dados_KeyDown);
            // 
            // cb_Opcao
            // 
            this.cb_Opcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Opcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Opcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Opcao.FormattingEnabled = true;
            this.cb_Opcao.Items.AddRange(new object[] {
            "Nome",
            "Turma",
            "Ano",
            "Ocupação"});
            this.cb_Opcao.Location = new System.Drawing.Point(529, 29);
            this.cb_Opcao.Name = "cb_Opcao";
            this.cb_Opcao.Size = new System.Drawing.Size(136, 27);
            this.cb_Opcao.TabIndex = 1;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pesquisar.Location = new System.Drawing.Point(671, 22);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(99, 39);
            this.btn_Pesquisar.TabIndex = 2;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // dgv_Busca
            // 
            this.dgv_Busca.AllowUserToAddRows = false;
            this.dgv_Busca.AllowUserToDeleteRows = false;
            this.dgv_Busca.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Busca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColNome,
            this.ColAno,
            this.ColTurma,
            this.ColCep,
            this.ColBairro,
            this.ColEndereco,
            this.ColNumero,
            this.ColCidade,
            this.ColEstado,
            this.ColFone,
            this.ColOcupacao});
            this.dgv_Busca.Location = new System.Drawing.Point(25, 92);
            this.dgv_Busca.Name = "dgv_Busca";
            this.dgv_Busca.ReadOnly = true;
            this.dgv_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Busca.Size = new System.Drawing.Size(762, 242);
            this.dgv_Busca.TabIndex = 3;
            this.dgv_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Busca_CellClick);
            this.dgv_Busca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Busca_CellDoubleClick);
            this.dgv_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_Busca_DataBindingComplete);
            // 
            // ColCod
            // 
            this.ColCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCod.DataPropertyName = "Cod_Usuario";
            this.ColCod.HeaderText = "Cód";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            this.ColCod.Width = 61;
            // 
            // ColNome
            // 
            this.ColNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNome.DataPropertyName = "Nome_Usuario";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 74;
            // 
            // ColAno
            // 
            this.ColAno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColAno.DataPropertyName = "Ano";
            this.ColAno.HeaderText = "Ano";
            this.ColAno.Name = "ColAno";
            this.ColAno.ReadOnly = true;
            this.ColAno.Width = 61;
            // 
            // ColTurma
            // 
            this.ColTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTurma.DataPropertyName = "Turma";
            this.ColTurma.HeaderText = "Turma";
            this.ColTurma.Name = "ColTurma";
            this.ColTurma.ReadOnly = true;
            this.ColTurma.Width = 77;
            // 
            // ColCep
            // 
            this.ColCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCep.DataPropertyName = "Cep";
            this.ColCep.HeaderText = "Cep";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
            this.ColCep.Width = 61;
            // 
            // ColBairro
            // 
            this.ColBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBairro.DataPropertyName = "Bairro";
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            this.ColBairro.Width = 77;
            // 
            // ColEndereco
            // 
            this.ColEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEndereco.DataPropertyName = "Endereco";
            this.ColEndereco.HeaderText = "Endereço";
            this.ColEndereco.Name = "ColEndereco";
            this.ColEndereco.ReadOnly = true;
            this.ColEndereco.Width = 97;
            // 
            // ColNumero
            // 
            this.ColNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNumero.DataPropertyName = "Numero";
            this.ColNumero.HeaderText = "Número";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 88;
            // 
            // ColCidade
            // 
            this.ColCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCidade.DataPropertyName = "Cidade";
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.ReadOnly = true;
            this.ColCidade.Width = 81;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEstado.DataPropertyName = "Estado";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 80;
            // 
            // ColFone
            // 
            this.ColFone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColFone.DataPropertyName = "Telefone";
            this.ColFone.HeaderText = "Tel/Cel";
            this.ColFone.Name = "ColFone";
            this.ColFone.ReadOnly = true;
            this.ColFone.Width = 82;
            // 
            // ColOcupacao
            // 
            this.ColOcupacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColOcupacao.DataPropertyName = "Ocupacao";
            this.ColOcupacao.HeaderText = "Ocupação";
            this.ColOcupacao.Name = "ColOcupacao";
            this.ColOcupacao.ReadOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(688, 340);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 39);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(583, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 383);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgv_Busca);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.cb_Opcao);
            this.Controls.Add(this.txt_Dados);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBuscarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FrmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Dados;
        private System.Windows.Forms.ComboBox cb_Opcao;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.DataGridView dgv_Busca;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOcupacao;
    }
}