namespace Controle_de_livros
{
    partial class BFrmBuscarUsuáriosLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BFrmBuscarUsuáriosLivros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Busca = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rb_Buscar_Todos_Livros_Didaticos = new System.Windows.Forms.RadioButton();
            this.rb_Buscar_Todos_Livros_Literarios = new System.Windows.Forms.RadioButton();
            this.rb_Livros_Literario_Nao_Entregues = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_Turma_Didatico = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Todos = new System.Windows.Forms.RadioButton();
            this.rb_Turma_Literario = new System.Windows.Forms.RadioButton();
            this.rb_Livros_Didaticos_Nao_Entregues = new System.Windows.Forms.RadioButton();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.rb_Autor = new System.Windows.Forms.RadioButton();
            this.txt_Genero = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Disciplina = new System.Windows.Forms.TextBox();
            this.txt_Ocupacao = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.rb_Genero = new System.Windows.Forms.RadioButton();
            this.rb_Disciplina = new System.Windows.Forms.RadioButton();
            this.rb_Titulo = new System.Windows.Forms.RadioButton();
            this.rb_Ocupacao = new System.Windows.Forms.RadioButton();
            this.rb_Nome = new System.Windows.Forms.RadioButton();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Turma_Literario = new System.Windows.Forms.TextBox();
            this.txt_Turma_Didatico = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Busca);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(534, 590);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView_Busca
            // 
            this.dataGridView_Busca.AllowUserToOrderColumns = true;
            this.dataGridView_Busca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dataGridView_Busca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Busca.Location = new System.Drawing.Point(4, 23);
            this.dataGridView_Busca.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Busca.Name = "dataGridView_Busca";
            this.dataGridView_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Busca.Size = new System.Drawing.Size(526, 563);
            this.dataGridView_Busca.TabIndex = 0;
            this.dataGridView_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Busca_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Turma_Didatico);
            this.groupBox2.Controls.Add(this.txt_Turma_Literario);
            this.groupBox2.Controls.Add(this.rb_Buscar_Todos_Livros_Didaticos);
            this.groupBox2.Controls.Add(this.rb_Buscar_Todos_Livros_Literarios);
            this.groupBox2.Controls.Add(this.rb_Livros_Literario_Nao_Entregues);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rb_Turma_Didatico);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rb_Todos);
            this.groupBox2.Controls.Add(this.rb_Turma_Literario);
            this.groupBox2.Controls.Add(this.rb_Livros_Didaticos_Nao_Entregues);
            this.groupBox2.Controls.Add(this.txt_Autor);
            this.groupBox2.Controls.Add(this.rb_Autor);
            this.groupBox2.Controls.Add(this.txt_Genero);
            this.groupBox2.Controls.Add(this.txt_Titulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Disciplina);
            this.groupBox2.Controls.Add(this.txt_Ocupacao);
            this.groupBox2.Controls.Add(this.txt_Nome);
            this.groupBox2.Controls.Add(this.rb_Genero);
            this.groupBox2.Controls.Add(this.rb_Disciplina);
            this.groupBox2.Controls.Add(this.rb_Titulo);
            this.groupBox2.Controls.Add(this.rb_Ocupacao);
            this.groupBox2.Controls.Add(this.rb_Nome);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(350, 586);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar dados";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            // 
            // rb_Buscar_Todos_Livros_Didaticos
            // 
            this.rb_Buscar_Todos_Livros_Didaticos.AutoSize = true;
            this.rb_Buscar_Todos_Livros_Didaticos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Buscar_Todos_Livros_Didaticos.Location = new System.Drawing.Point(7, 192);
            this.rb_Buscar_Todos_Livros_Didaticos.Name = "rb_Buscar_Todos_Livros_Didaticos";
            this.rb_Buscar_Todos_Livros_Didaticos.Size = new System.Drawing.Size(190, 23);
            this.rb_Buscar_Todos_Livros_Didaticos.TabIndex = 33;
            this.rb_Buscar_Todos_Livros_Didaticos.TabStop = true;
            this.rb_Buscar_Todos_Livros_Didaticos.Text = "Todos os livros didáticos";
            this.rb_Buscar_Todos_Livros_Didaticos.UseVisualStyleBackColor = true;
            // 
            // rb_Buscar_Todos_Livros_Literarios
            // 
            this.rb_Buscar_Todos_Livros_Literarios.AutoSize = true;
            this.rb_Buscar_Todos_Livros_Literarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Buscar_Todos_Livros_Literarios.Location = new System.Drawing.Point(7, 327);
            this.rb_Buscar_Todos_Livros_Literarios.Name = "rb_Buscar_Todos_Livros_Literarios";
            this.rb_Buscar_Todos_Livros_Literarios.Size = new System.Drawing.Size(191, 23);
            this.rb_Buscar_Todos_Livros_Literarios.TabIndex = 31;
            this.rb_Buscar_Todos_Livros_Literarios.TabStop = true;
            this.rb_Buscar_Todos_Livros_Literarios.Text = "Todos os livros literários";
            this.rb_Buscar_Todos_Livros_Literarios.UseVisualStyleBackColor = true;
            // 
            // rb_Livros_Literario_Nao_Entregues
            // 
            this.rb_Livros_Literario_Nao_Entregues.AutoSize = true;
            this.rb_Livros_Literario_Nao_Entregues.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Livros_Literario_Nao_Entregues.Location = new System.Drawing.Point(7, 529);
            this.rb_Livros_Literario_Nao_Entregues.Name = "rb_Livros_Literario_Nao_Entregues";
            this.rb_Livros_Literario_Nao_Entregues.Size = new System.Drawing.Size(168, 23);
            this.rb_Livros_Literario_Nao_Entregues.TabIndex = 26;
            this.rb_Livros_Literario_Nao_Entregues.TabStop = true;
            this.rb_Livros_Literario_Nao_Entregues.Text = "Livros não entregues";
            this.rb_Livros_Literario_Nao_Entregues.UseVisualStyleBackColor = true;
            this.rb_Livros_Literario_Nao_Entregues.CheckedChanged += new System.EventHandler(this.rb_Livros_Literario_Nao_Entregues_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(73, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Livros didáticos não entregues:";
            // 
            // rb_Turma_Didatico
            // 
            this.rb_Turma_Didatico.AutoSize = true;
            this.rb_Turma_Didatico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Turma_Didatico.Location = new System.Drawing.Point(7, 250);
            this.rb_Turma_Didatico.Name = "rb_Turma_Didatico";
            this.rb_Turma_Didatico.Size = new System.Drawing.Size(70, 23);
            this.rb_Turma_Didatico.TabIndex = 23;
            this.rb_Turma_Didatico.TabStop = true;
            this.rb_Turma_Didatico.Text = "Turma";
            this.rb_Turma_Didatico.UseVisualStyleBackColor = true;
            this.rb_Turma_Didatico.CheckedChanged += new System.EventHandler(this.rb_TurmaDidatico_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(73, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Livros literários não entregues:";
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Todos.Location = new System.Drawing.Point(7, 26);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(146, 23);
            this.rb_Todos.TabIndex = 17;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos os usuários";
            this.rb_Todos.UseVisualStyleBackColor = true;
            this.rb_Todos.CheckedChanged += new System.EventHandler(this.rb_Todos_CheckedChanged);
            // 
            // rb_Turma_Literario
            // 
            this.rb_Turma_Literario.AutoSize = true;
            this.rb_Turma_Literario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Turma_Literario.Location = new System.Drawing.Point(7, 497);
            this.rb_Turma_Literario.Name = "rb_Turma_Literario";
            this.rb_Turma_Literario.Size = new System.Drawing.Size(70, 23);
            this.rb_Turma_Literario.TabIndex = 16;
            this.rb_Turma_Literario.TabStop = true;
            this.rb_Turma_Literario.Text = "Turma";
            this.rb_Turma_Literario.UseVisualStyleBackColor = true;
            this.rb_Turma_Literario.CheckedChanged += new System.EventHandler(this.rb_TurmaLiterario_CheckedChanged);
            // 
            // rb_Livros_Didaticos_Nao_Entregues
            // 
            this.rb_Livros_Didaticos_Nao_Entregues.AutoSize = true;
            this.rb_Livros_Didaticos_Nao_Entregues.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Livros_Didaticos_Nao_Entregues.Location = new System.Drawing.Point(7, 279);
            this.rb_Livros_Didaticos_Nao_Entregues.Name = "rb_Livros_Didaticos_Nao_Entregues";
            this.rb_Livros_Didaticos_Nao_Entregues.Size = new System.Drawing.Size(225, 23);
            this.rb_Livros_Didaticos_Nao_Entregues.TabIndex = 18;
            this.rb_Livros_Didaticos_Nao_Entregues.TabStop = true;
            this.rb_Livros_Didaticos_Nao_Entregues.Text = "Todos os livros não entregues";
            this.rb_Livros_Didaticos_Nao_Entregues.UseVisualStyleBackColor = true;
            this.rb_Livros_Didaticos_Nao_Entregues.CheckedChanged += new System.EventHandler(this.rb_Livros_Didaticos_Nao_Entregues_CheckedChanged);
            // 
            // txt_Autor
            // 
            this.txt_Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Autor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Autor.Location = new System.Drawing.Point(78, 438);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(224, 26);
            this.txt_Autor.TabIndex = 15;
            // 
            // rb_Autor
            // 
            this.rb_Autor.AutoSize = true;
            this.rb_Autor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Autor.Location = new System.Drawing.Point(7, 438);
            this.rb_Autor.Name = "rb_Autor";
            this.rb_Autor.Size = new System.Drawing.Size(65, 23);
            this.rb_Autor.TabIndex = 14;
            this.rb_Autor.TabStop = true;
            this.rb_Autor.Text = "Autor";
            this.rb_Autor.UseVisualStyleBackColor = true;
            this.rb_Autor.CheckedChanged += new System.EventHandler(this.rb_Autor_CheckedChanged);
            // 
            // txt_Genero
            // 
            this.txt_Genero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Genero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Genero.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Genero.Location = new System.Drawing.Point(90, 395);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.Size = new System.Drawing.Size(224, 26);
            this.txt_Genero.TabIndex = 13;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Titulo.Location = new System.Drawing.Point(79, 353);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(224, 26);
            this.txt_Titulo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(74, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar livros literários:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar livros didáticos:";
            // 
            // txt_Disciplina
            // 
            this.txt_Disciplina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Disciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Disciplina.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Disciplina.Location = new System.Drawing.Point(106, 162);
            this.txt_Disciplina.MaxLength = 30;
            this.txt_Disciplina.Name = "txt_Disciplina";
            this.txt_Disciplina.Size = new System.Drawing.Size(224, 26);
            this.txt_Disciplina.TabIndex = 9;
            // 
            // txt_Ocupacao
            // 
            this.txt_Ocupacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ocupacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Ocupacao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Ocupacao.Location = new System.Drawing.Point(106, 94);
            this.txt_Ocupacao.MaxLength = 11;
            this.txt_Ocupacao.Name = "txt_Ocupacao";
            this.txt_Ocupacao.Size = new System.Drawing.Size(224, 26);
            this.txt_Ocupacao.TabIndex = 8;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nome.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Nome.Location = new System.Drawing.Point(80, 54);
            this.txt_Nome.MaxLength = 30;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(224, 26);
            this.txt_Nome.TabIndex = 7;
            // 
            // rb_Genero
            // 
            this.rb_Genero.AutoSize = true;
            this.rb_Genero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Genero.Location = new System.Drawing.Point(7, 396);
            this.rb_Genero.Name = "rb_Genero";
            this.rb_Genero.Size = new System.Drawing.Size(77, 23);
            this.rb_Genero.TabIndex = 6;
            this.rb_Genero.TabStop = true;
            this.rb_Genero.Text = "Gênero";
            this.rb_Genero.UseVisualStyleBackColor = true;
            this.rb_Genero.CheckedChanged += new System.EventHandler(this.rb_Genero_CheckedChanged);
            // 
            // rb_Disciplina
            // 
            this.rb_Disciplina.AutoSize = true;
            this.rb_Disciplina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Disciplina.Location = new System.Drawing.Point(7, 163);
            this.rb_Disciplina.Name = "rb_Disciplina";
            this.rb_Disciplina.Size = new System.Drawing.Size(93, 23);
            this.rb_Disciplina.TabIndex = 4;
            this.rb_Disciplina.TabStop = true;
            this.rb_Disciplina.Text = "Disciplina";
            this.rb_Disciplina.UseVisualStyleBackColor = true;
            this.rb_Disciplina.CheckedChanged += new System.EventHandler(this.rb_Disciplina_CheckedChanged);
            // 
            // rb_Titulo
            // 
            this.rb_Titulo.AutoSize = true;
            this.rb_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Titulo.Location = new System.Drawing.Point(7, 353);
            this.rb_Titulo.Name = "rb_Titulo";
            this.rb_Titulo.Size = new System.Drawing.Size(66, 23);
            this.rb_Titulo.TabIndex = 3;
            this.rb_Titulo.TabStop = true;
            this.rb_Titulo.Text = "Titulo";
            this.rb_Titulo.UseVisualStyleBackColor = true;
            this.rb_Titulo.CheckedChanged += new System.EventHandler(this.rb_Titulo_CheckedChanged);
            // 
            // rb_Ocupacao
            // 
            this.rb_Ocupacao.AutoSize = true;
            this.rb_Ocupacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Ocupacao.Location = new System.Drawing.Point(7, 95);
            this.rb_Ocupacao.Name = "rb_Ocupacao";
            this.rb_Ocupacao.Size = new System.Drawing.Size(93, 23);
            this.rb_Ocupacao.TabIndex = 2;
            this.rb_Ocupacao.TabStop = true;
            this.rb_Ocupacao.Text = "Ocupação";
            this.rb_Ocupacao.UseVisualStyleBackColor = true;
            this.rb_Ocupacao.CheckedChanged += new System.EventHandler(this.rb_Ocupacao_CheckedChanged);
            // 
            // rb_Nome
            // 
            this.rb_Nome.AutoSize = true;
            this.rb_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nome.Location = new System.Drawing.Point(7, 55);
            this.rb_Nome.Name = "rb_Nome";
            this.rb_Nome.Size = new System.Drawing.Size(67, 23);
            this.rb_Nome.TabIndex = 1;
            this.rb_Nome.TabStop = true;
            this.rb_Nome.Text = "Nome";
            this.rb_Nome.UseVisualStyleBackColor = true;
            this.rb_Nome.CheckedChanged += new System.EventHandler(this.rb_Nome_CheckedChanged);
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout1;
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.Location = new System.Drawing.Point(792, 597);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(113, 48);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(673, 597);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(113, 48);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Turma_Literario
            // 
            this.txt_Turma_Literario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Turma_Literario.Location = new System.Drawing.Point(80, 499);
            this.txt_Turma_Literario.Name = "txt_Turma_Literario";
            this.txt_Turma_Literario.Size = new System.Drawing.Size(205, 26);
            this.txt_Turma_Literario.TabIndex = 36;
            // 
            // txt_Turma_Didatico
            // 
            this.txt_Turma_Didatico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Turma_Didatico.Location = new System.Drawing.Point(78, 249);
            this.txt_Turma_Didatico.Name = "txt_Turma_Didatico";
            this.txt_Turma_Didatico.Size = new System.Drawing.Size(207, 26);
            this.txt_Turma_Didatico.TabIndex = 37;
            // 
            // Buscar_usuários_e_livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 654);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Buscar_usuários_e_livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR USUARIO E LIVROS";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Busca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Turma_Literario;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.RadioButton rb_Autor;
        private System.Windows.Forms.TextBox txt_Genero;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Disciplina;
        private System.Windows.Forms.TextBox txt_Ocupacao;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.RadioButton rb_Genero;
        private System.Windows.Forms.RadioButton rb_Disciplina;
        private System.Windows.Forms.RadioButton rb_Titulo;
        private System.Windows.Forms.RadioButton rb_Ocupacao;
        private System.Windows.Forms.RadioButton rb_Nome;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.RadioButton rb_Todos;
        private System.Windows.Forms.RadioButton rb_Livros_Didaticos_Nao_Entregues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_Turma_Didatico;
        private System.Windows.Forms.RadioButton rb_Livros_Literario_Nao_Entregues;
        private System.Windows.Forms.RadioButton rb_Buscar_Todos_Livros_Literarios;
        private System.Windows.Forms.RadioButton rb_Buscar_Todos_Livros_Didaticos;
        private System.Windows.Forms.BindingSource usuarioBindingSource;     
        private System.Windows.Forms.TextBox txt_Turma_Literario;
        private System.Windows.Forms.TextBox txt_Turma_Didatico;
    }
}