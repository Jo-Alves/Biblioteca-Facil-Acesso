﻿namespace Controle_de_livros
{
    partial class FrmBuscarLivrosGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarLivrosGenero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuantidadeLivroAutor = new System.Windows.Forms.Label();
            this.dataGridView_Busca = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Genero = new System.Windows.Forms.TextBox();
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
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).BeginInit();
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblQuantidadeLivroAutor);
            this.groupBox1.Controls.Add(this.dataGridView_Busca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Genero);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(542, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblQuantidadeLivroAutor
            // 
            this.lblQuantidadeLivroAutor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblQuantidadeLivroAutor.AutoSize = true;
            this.lblQuantidadeLivroAutor.Location = new System.Drawing.Point(302, 540);
            this.lblQuantidadeLivroAutor.Name = "lblQuantidadeLivroAutor";
            this.lblQuantidadeLivroAutor.Size = new System.Drawing.Size(0, 19);
            this.lblQuantidadeLivroAutor.TabIndex = 11;
            // 
            // dataGridView_Busca
            // 
            this.dataGridView_Busca.AllowUserToAddRows = false;
            this.dataGridView_Busca.AllowUserToDeleteRows = false;
            this.dataGridView_Busca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 540);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade do livro do gênero procurado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gênero:";
            // 
            // txt_Genero
            // 
            this.txt_Genero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Genero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Genero.Location = new System.Drawing.Point(13, 46);
            this.txt_Genero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.Size = new System.Drawing.Size(401, 26);
            this.txt_Genero.TabIndex = 5;
            this.txt_Genero.TextChanged += new System.EventHandler(this.txt_Autor_TextChanged);
            this.txt_Genero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Autor_KeyDown);
            this.txt_Genero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Autor_KeyPress);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.Location = new System.Drawing.Point(422, 36);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(112, 44);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Titulo.BackColor = System.Drawing.Color.White;
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Titulo.Location = new System.Drawing.Point(583, 50);
            this.txt_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.ReadOnly = true;
            this.txt_Titulo.Size = new System.Drawing.Size(396, 26);
            this.txt_Titulo.TabIndex = 2;
            this.txt_Titulo.TextChanged += new System.EventHandler(this.txt_Titulo_TextChanged);
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenero.BackColor = System.Drawing.Color.White;
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenero.Location = new System.Drawing.Point(585, 156);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(394, 26);
            this.txtGenero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero:";
            // 
            // txt_Estante
            // 
            this.txt_Estante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Estante.BackColor = System.Drawing.Color.White;
            this.txt_Estante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Estante.Location = new System.Drawing.Point(585, 209);
            this.txt_Estante.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Estante.Name = "txt_Estante";
            this.txt_Estante.ReadOnly = true;
            this.txt_Estante.Size = new System.Drawing.Size(97, 26);
            this.txt_Estante.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estante:";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Verificar.Enabled = false;
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Verificar.Location = new System.Drawing.Point(570, 402);
            this.btn_Verificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(484, 62);
            this.btn_Verificar.TabIndex = 32;
            this.btn_Verificar.Text = "Verificar com quem o livro está emprestado";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // num_QuantidadeEmprestadas
            // 
            this.num_QuantidadeEmprestadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_QuantidadeEmprestadas.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeEmprestadas.Location = new System.Drawing.Point(584, 368);
            this.num_QuantidadeEmprestadas.Margin = new System.Windows.Forms.Padding(4);
            this.num_QuantidadeEmprestadas.Name = "num_QuantidadeEmprestadas";
            this.num_QuantidadeEmprestadas.ReadOnly = true;
            this.num_QuantidadeEmprestadas.Size = new System.Drawing.Size(180, 26);
            this.num_QuantidadeEmprestadas.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Quantidade  de livros emprestadas:";
            // 
            // num_QuantidadeDisponivel
            // 
            this.num_QuantidadeDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_QuantidadeDisponivel.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeDisponivel.Location = new System.Drawing.Point(585, 315);
            this.num_QuantidadeDisponivel.Margin = new System.Windows.Forms.Padding(4);
            this.num_QuantidadeDisponivel.Name = "num_QuantidadeDisponivel";
            this.num_QuantidadeDisponivel.ReadOnly = true;
            this.num_QuantidadeDisponivel.Size = new System.Drawing.Size(180, 26);
            this.num_QuantidadeDisponivel.TabIndex = 36;
            // 
            // num_QuantidadeTotalCadastrado
            // 
            this.num_QuantidadeTotalCadastrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_QuantidadeTotalCadastrado.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeTotalCadastrado.Location = new System.Drawing.Point(585, 262);
            this.num_QuantidadeTotalCadastrado.Margin = new System.Windows.Forms.Padding(4);
            this.num_QuantidadeTotalCadastrado.Name = "num_QuantidadeTotalCadastrado";
            this.num_QuantidadeTotalCadastrado.ReadOnly = true;
            this.num_QuantidadeTotalCadastrado.Size = new System.Drawing.Size(180, 26);
            this.num_QuantidadeTotalCadastrado.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantidade disponível para empréstimo:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Quantidade de livros cadastrados:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.Image = global::Controle_de_livros.Properties.Resources.CleanMyMac_1_icon;
            this.btn_Limpar.Location = new System.Drawing.Point(570, 472);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(484, 62);
            this.btn_Limpar.TabIndex = 40;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.logout_icon2;
            this.btn_Sair.Location = new System.Drawing.Point(570, 542);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(484, 67);
            this.btn_Sair.TabIndex = 39;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Location = new System.Drawing.Point(584, 103);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(395, 26);
            this.txtAutor.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "Autor:";
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
            // FrmBuscarLivrosGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 625);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarLivrosGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR LIVRO POR GÊNERO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Buscar_livros_por_Genero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).EndInit();
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
        private System.Windows.Forms.TextBox txt_Genero;
        private System.Windows.Forms.Label lblQuantidadeLivroAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label9;
    }
}