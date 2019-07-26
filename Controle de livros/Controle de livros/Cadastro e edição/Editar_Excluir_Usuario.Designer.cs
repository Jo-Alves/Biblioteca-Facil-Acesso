namespace Controle_de_livros
{
    partial class Editar_Excluir_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Excluir_Usuario));
            this.rb_Outros = new System.Windows.Forms.RadioButton();
            this.rb_Funcionario = new System.Windows.Forms.RadioButton();
            this.rb_Aluno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Turma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Ano = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Tel_Cel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_BuscaUsuario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BuscaUsuario)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_Outros
            // 
            this.rb_Outros.AutoSize = true;
            this.rb_Outros.Enabled = false;
            this.rb_Outros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Outros.Location = new System.Drawing.Point(365, 41);
            this.rb_Outros.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Outros.Name = "rb_Outros";
            this.rb_Outros.Size = new System.Drawing.Size(73, 23);
            this.rb_Outros.TabIndex = 2;
            this.rb_Outros.Text = "Outros";
            this.rb_Outros.UseVisualStyleBackColor = true;
            this.rb_Outros.CheckedChanged += new System.EventHandler(this.rb_Outros_CheckedChanged);
            // 
            // rb_Funcionario
            // 
            this.rb_Funcionario.AutoSize = true;
            this.rb_Funcionario.Enabled = false;
            this.rb_Funcionario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Funcionario.Location = new System.Drawing.Point(223, 41);
            this.rb_Funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Funcionario.Name = "rb_Funcionario";
            this.rb_Funcionario.Size = new System.Drawing.Size(105, 23);
            this.rb_Funcionario.TabIndex = 1;
            this.rb_Funcionario.Text = "Funcionário";
            this.rb_Funcionario.UseVisualStyleBackColor = true;
            this.rb_Funcionario.CheckedChanged += new System.EventHandler(this.rb_Funcionario_CheckedChanged);
            // 
            // rb_Aluno
            // 
            this.rb_Aluno.AutoSize = true;
            this.rb_Aluno.Enabled = false;
            this.rb_Aluno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Aluno.Location = new System.Drawing.Point(90, 41);
            this.rb_Aluno.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Aluno.Name = "rb_Aluno";
            this.rb_Aluno.Size = new System.Drawing.Size(66, 23);
            this.rb_Aluno.TabIndex = 0;
            this.rb_Aluno.Text = "Aluno";
            this.rb_Aluno.UseVisualStyleBackColor = true;
            this.rb_Aluno.CheckedChanged += new System.EventHandler(this.rb_Aluno_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código Usuário:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(206, 50);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.MaxLength = 100;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(308, 26);
            this.txt_Nome.TabIndex = 2;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Turma);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cb_Ano);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Nome);
            this.groupBox2.Controls.Add(this.txt_Codigo);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(617, 157);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do usuário:";
            // 
            // cb_Turma
            // 
            this.cb_Turma.AccessibleDescription = "";
            this.cb_Turma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Turma.Enabled = false;
            this.cb_Turma.FormattingEnabled = true;
            this.cb_Turma.Location = new System.Drawing.Point(206, 116);
            this.cb_Turma.Name = "cb_Turma";
            this.cb_Turma.Size = new System.Drawing.Size(121, 27);
            this.cb_Turma.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ano:";
            // 
            // cb_Ano
            // 
            this.cb_Ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Ano.Enabled = false;
            this.cb_Ano.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ano.FormattingEnabled = true;
            this.cb_Ano.Items.AddRange(new object[] {
            "",
            "1º - ENSINO FUNDAMENTAL",
            "2º - ENSINO FUNDAMENTAL",
            "3º - ENSINO FUNDAMENTAL",
            "4º - ENSINO FUNDAMENTAL",
            "5º - ENSINO FUNDAMENTAL",
            "6º - ENSINO FUNDAMENTAL",
            "7º - ENSINO FUNDAMENTAL",
            "8º - ENSINO FUNDAMENTAL",
            "9º - ENSINO FUNDAMENTAL",
            "1º - ENSINO MÉDIO",
            "2º - ENSINO MÉDIO",
            "3º - ENSINO MÉDIO",
            "EJA (ENSINO DE JOVENS E ADULTOS)"});
            this.cb_Ano.Location = new System.Drawing.Point(206, 83);
            this.cb_Ano.Name = "cb_Ano";
            this.cb_Ano.Size = new System.Drawing.Size(274, 27);
            this.cb_Ano.TabIndex = 3;
            this.cb_Ano.SelectedIndexChanged += new System.EventHandler(this.cb_Ano_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.White;
            this.txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(206, 20);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo.MaxLength = 5;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(133, 26);
            this.txt_Codigo.TabIndex = 1;
            this.txt_Codigo.TextChanged += new System.EventHandler(this.txt_Codigo_TextChanged);
            // 
            // txt_Tel_Cel
            // 
            this.txt_Tel_Cel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Tel_Cel.Enabled = false;
            this.txt_Tel_Cel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tel_Cel.Location = new System.Drawing.Point(164, 87);
            this.txt_Tel_Cel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tel_Cel.MaxLength = 14;
            this.txt_Tel_Cel.Name = "txt_Tel_Cel";
            this.txt_Tel_Cel.Size = new System.Drawing.Size(116, 26);
            this.txt_Tel_Cel.TabIndex = 7;
            this.txt_Tel_Cel.TextChanged += new System.EventHandler(this.txt_Telefone_TextChanged);
            this.txt_Tel_Cel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Telefone_KeyDown);
            this.txt_Tel_Cel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefone_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tel/Cel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Endereco.Enabled = false;
            this.txt_Endereco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(164, 20);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Endereco.MaxLength = 30;
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(316, 26);
            this.txt_Endereco.TabIndex = 5;
            this.txt_Endereco.TextChanged += new System.EventHandler(this.txt_Endereco_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Outros);
            this.groupBox1.Controls.Add(this.rb_Funcionario);
            this.groupBox1.Controls.Add(this.rb_Aluno);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(619, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a ocupação do usuário:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Numero.Enabled = false;
            this.txt_Numero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(164, 54);
            this.txt_Numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(92, 26);
            this.txt_Numero.TabIndex = 6;
            this.txt_Numero.TextChanged += new System.EventHandler(this.txt_Numero_TextChanged);
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_BuscaUsuario);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_Buscar);
            this.groupBox4.Controls.Add(this.btn_Buscar);
            this.groupBox4.Location = new System.Drawing.Point(17, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 230);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView_BuscaUsuario
            // 
            this.dataGridView_BuscaUsuario.AllowUserToAddRows = false;
            this.dataGridView_BuscaUsuario.AllowUserToDeleteRows = false;
            this.dataGridView_BuscaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_BuscaUsuario.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_BuscaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_BuscaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BuscaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_BuscaUsuario.Location = new System.Drawing.Point(6, 68);
            this.dataGridView_BuscaUsuario.Name = "dataGridView_BuscaUsuario";
            this.dataGridView_BuscaUsuario.ReadOnly = true;
            this.dataGridView_BuscaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BuscaUsuario.Size = new System.Drawing.Size(600, 150);
            this.dataGridView_BuscaUsuario.TabIndex = 11;
            this.dataGridView_BuscaUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BuscaUsuario_CellClick);
            this.dataGridView_BuscaUsuario.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_BuscaUsuario_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Cod_Usuario";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 79;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Nome_USuario";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 72;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Ano";
            this.Column3.HeaderText = "Ano";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Turma";
            this.Column4.HeaderText = "Turma";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 72;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Endereco";
            this.Column5.HeaderText = "Endereço";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 92;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "Numero";
            this.Column6.HeaderText = "Número";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 84;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Telefone";
            this.Column7.HeaderText = "Tel/Cel";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 77;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "Ocupacao";
            this.Column8.HeaderText = "Ocupação";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Buscar.Location = new System.Drawing.Point(101, 31);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(353, 26);
            this.txt_Buscar.TabIndex = 0;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            this.txt_Buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Buscar_KeyDown);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(460, 25);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(146, 36);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Tel_Cel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_Endereco);
            this.groupBox3.Controls.Add(this.txt_Numero);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 281);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(617, 134);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Localização:";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Excluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Button_Button_Delete;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.Location = new System.Drawing.Point(505, 423);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(125, 41);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Soft_Scraps_Edit_Document;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(365, 423);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(132, 41);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // error_Provider
            // 
            this.error_Provider.ContainerControl = this;
            // 
            // Editar_Excluir_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 713);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Editar_Excluir_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar/Excluir Usuário";
            this.Load += new System.EventHandler(this.Editar_Excluir_Usuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BuscaUsuario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Outros;
        private System.Windows.Forms.RadioButton rb_Funcionario;
        private System.Windows.Forms.RadioButton rb_Aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Tel_Cel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private System.Windows.Forms.DataGridView dataGridView_BuscaUsuario;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.ComboBox cb_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}