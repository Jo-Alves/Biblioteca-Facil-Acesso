namespace Controle_de_livros
{
    partial class FrmBuscarLivrosAutor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarLivrosAutor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Busca = new System.Windows.Forms.DataGridView();
            this.numQuantidadeLivroAutor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Estante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.num_QuantidadeEmprestadas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_QuantidadeDisponivel = new System.Windows.Forms.NumericUpDown();
            this.num_QuantidadeTotalCadastrado = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.livroLiterarioBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Usuario1 = new Controle_de_livros.DataSet_s.DataSet_Usuario();
            this.livroLiterarioBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.livroLiterarioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Usuario = new Controle_de_livros.DataSet_s.DataSet_Usuario();
            this.livroLiterarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.livroLiterarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livroLiterarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livro_LiterarioTableAdapter = new Controle_de_livros.DataSet_s.DataSet_UsuarioTableAdapters.Livro_LiterarioTableAdapter();
            this.livroLiterarioBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeLivroAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeEmprestadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeDisponivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeTotalCadastrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Usuario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Busca);
            this.groupBox1.Controls.Add(this.numQuantidadeLivroAutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Autor);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(542, 604);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView_Busca
            // 
            this.dataGridView_Busca.AllowUserToAddRows = false;
            this.dataGridView_Busca.AllowUserToDeleteRows = false;
            this.dataGridView_Busca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Busca.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Busca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Busca.Location = new System.Drawing.Point(7, 92);
            this.dataGridView_Busca.Name = "dataGridView_Busca";
            this.dataGridView_Busca.ReadOnly = true;
            this.dataGridView_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Busca.Size = new System.Drawing.Size(528, 419);
            this.dataGridView_Busca.TabIndex = 9;
            this.dataGridView_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Busca_CellClick);
            this.dataGridView_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Busca_DataBindingComplete);
            // 
            // numQuantidadeLivroAutor
            // 
            this.numQuantidadeLivroAutor.Enabled = false;
            this.numQuantidadeLivroAutor.Location = new System.Drawing.Point(310, 537);
            this.numQuantidadeLivroAutor.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantidadeLivroAutor.Name = "numQuantidadeLivroAutor";
            this.numQuantidadeLivroAutor.Size = new System.Drawing.Size(128, 26);
            this.numQuantidadeLivroAutor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 540);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade do livro do autor procurado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Autor:";
            // 
            // txt_Autor
            // 
            this.txt_Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autor.Location = new System.Drawing.Point(42, 50);
            this.txt_Autor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(359, 26);
            this.txt_Autor.TabIndex = 5;
            this.txt_Autor.TextChanged += new System.EventHandler(this.txt_Autor_TextChanged);
            this.txt_Autor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Autor_KeyDown);
            this.txt_Autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Autor_KeyPress);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.Location = new System.Drawing.Point(409, 41);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(112, 44);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BackColor = System.Drawing.Color.White;
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Titulo.Location = new System.Drawing.Point(568, 71);
            this.txt_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.ReadOnly = true;
            this.txt_Titulo.Size = new System.Drawing.Size(396, 26);
            this.txt_Titulo.TabIndex = 2;
            this.txt_Titulo.TextChanged += new System.EventHandler(this.txt_Titulo_TextChanged);
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.White;
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenero.Location = new System.Drawing.Point(570, 177);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(394, 26);
            this.txtGenero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero:";
            // 
            // txt_Estante
            // 
            this.txt_Estante.BackColor = System.Drawing.Color.White;
            this.txt_Estante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Estante.Location = new System.Drawing.Point(570, 230);
            this.txt_Estante.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Estante.Name = "txt_Estante";
            this.txt_Estante.ReadOnly = true;
            this.txt_Estante.Size = new System.Drawing.Size(125, 26);
            this.txt_Estante.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estante:";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Enabled = false;
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Verificar.Location = new System.Drawing.Point(570, 423);
            this.btn_Verificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(394, 58);
            this.btn_Verificar.TabIndex = 32;
            this.btn_Verificar.Text = "Verificar com quem o livro está emprestado";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // num_QuantidadeEmprestadas
            // 
            this.num_QuantidadeEmprestadas.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeEmprestadas.Location = new System.Drawing.Point(570, 389);
            this.num_QuantidadeEmprestadas.Margin = new System.Windows.Forms.Padding(4);
            this.num_QuantidadeEmprestadas.Name = "num_QuantidadeEmprestadas";
            this.num_QuantidadeEmprestadas.ReadOnly = true;
            this.num_QuantidadeEmprestadas.Size = new System.Drawing.Size(180, 26);
            this.num_QuantidadeEmprestadas.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Quantidade  de livros emprestadas:";
            // 
            // num_QuantidadeDisponivel
            // 
            this.num_QuantidadeDisponivel.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeDisponivel.Location = new System.Drawing.Point(570, 336);
            this.num_QuantidadeDisponivel.Margin = new System.Windows.Forms.Padding(4);
            this.num_QuantidadeDisponivel.Name = "num_QuantidadeDisponivel";
            this.num_QuantidadeDisponivel.ReadOnly = true;
            this.num_QuantidadeDisponivel.Size = new System.Drawing.Size(180, 26);
            this.num_QuantidadeDisponivel.TabIndex = 36;
            // 
            // num_QuantidadeTotalCadastrado
            // 
            this.num_QuantidadeTotalCadastrado.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeTotalCadastrado.Location = new System.Drawing.Point(570, 283);
            this.num_QuantidadeTotalCadastrado.Margin = new System.Windows.Forms.Padding(4);
            this.num_QuantidadeTotalCadastrado.Name = "num_QuantidadeTotalCadastrado";
            this.num_QuantidadeTotalCadastrado.ReadOnly = true;
            this.num_QuantidadeTotalCadastrado.Size = new System.Drawing.Size(180, 26);
            this.num_QuantidadeTotalCadastrado.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantidade disponível para empréstimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Quantidade de livros cadastrados:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.Image = global::Controle_de_livros.Properties.Resources.CleanMyMac_1_icon;
            this.btn_Limpar.Location = new System.Drawing.Point(570, 489);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(394, 58);
            this.btn_Limpar.TabIndex = 40;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.logout_icon2;
            this.btn_Sair.Location = new System.Drawing.Point(570, 555);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(394, 65);
            this.btn_Sair.TabIndex = 39;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // livroLiterarioBindingSource6
            // 
            this.livroLiterarioBindingSource6.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource6.DataSource = this.dataSet_Usuario1;
            // 
            // dataSet_Usuario1
            // 
            this.dataSet_Usuario1.DataSetName = "DataSet_Usuario";
            this.dataSet_Usuario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroLiterarioBindingSource5
            // 
            this.livroLiterarioBindingSource5.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource5.DataSource = this.dataSet_Usuario1;
            // 
            // livroLiterarioBindingSource3
            // 
            this.livroLiterarioBindingSource3.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource3.DataSource = this.dataSet_Usuario;
            // 
            // dataSet_Usuario
            // 
            this.dataSet_Usuario.DataSetName = "DataSet_Usuario";
            this.dataSet_Usuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroLiterarioBindingSource2
            // 
            this.livroLiterarioBindingSource2.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource2.DataSource = this.dataSet_Usuario;
            // 
            // livroLiterarioBindingSource1
            // 
            this.livroLiterarioBindingSource1.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource1.DataSource = this.dataSet_Usuario;
            // 
            // livroLiterarioBindingSource
            // 
            this.livroLiterarioBindingSource.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource.DataSource = this.dataSet_Usuario;
            // 
            // livro_LiterarioTableAdapter
            // 
            this.livro_LiterarioTableAdapter.ClearBeforeFill = true;
            // 
            // livroLiterarioBindingSource4
            // 
            this.livroLiterarioBindingSource4.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource4.DataSource = this.dataSet_Usuario;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Location = new System.Drawing.Point(570, 124);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(394, 26);
            this.txtAutor.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "Autor:";
            // 
            // Buscar_livros_por_autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 639);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.num_QuantidadeEmprestadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_QuantidadeDisponivel);
            this.Controls.Add(this.num_QuantidadeTotalCadastrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.txt_Estante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Buscar_livros_por_autor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR LIVRO POR AUTOR";
            this.Load += new System.EventHandler(this.Buscar_livros_por_autor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeLivroAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeEmprestadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeDisponivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeTotalCadastrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Usuario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet_s.DataSet_Usuario dataSet_Usuario;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource;
        private DataSet_s.DataSet_UsuarioTableAdapters.Livro_LiterarioTableAdapter livro_LiterarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantidadeLivroAutor;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource3;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Estante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.NumericUpDown num_QuantidadeEmprestadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_QuantidadeDisponivel;
        private System.Windows.Forms.NumericUpDown num_QuantidadeTotalCadastrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn tÍTULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gÊNERODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource4;
        private DataSet_s.DataSet_Usuario dataSet_Usuario1;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource5;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource6;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.DataGridView dataGridView_Busca;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label9;
    }
}