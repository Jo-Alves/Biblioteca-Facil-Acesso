namespace Controle_de_livros
{
    partial class Verificar_Situacao_Funcionarios_Terceiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verificar_Situacao_Funcionarios_Terceiros));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Nome = new System.Windows.Forms.DataGridView();
            this.cb_Nome = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Ocupacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_Turma = new System.Windows.Forms.Label();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.txt_decisaoLivroDidatico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DataEntrega = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DataSolicitacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_decisaoLivroLiterario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Nome);
            this.groupBox2.Controls.Add(this.cb_Nome);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 514);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_Nome
            // 
            this.dataGridView_Nome.AllowUserToAddRows = false;
            this.dataGridView_Nome.AllowUserToDeleteRows = false;
            this.dataGridView_Nome.AllowUserToOrderColumns = true;
            this.dataGridView_Nome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Nome.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Nome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Nome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Nome.Location = new System.Drawing.Point(6, 63);
            this.dataGridView_Nome.Name = "dataGridView_Nome";
            this.dataGridView_Nome.ReadOnly = true;
            this.dataGridView_Nome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Nome.Size = new System.Drawing.Size(478, 437);
            this.dataGridView_Nome.TabIndex = 29;
            this.dataGridView_Nome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Nome_CellClick);
            this.dataGridView_Nome.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Nome_DataBindingComplete);
            // 
            // cb_Nome
            // 
            this.cb_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Nome.FormattingEnabled = true;
            this.cb_Nome.Location = new System.Drawing.Point(87, 23);
            this.cb_Nome.Name = "cb_Nome";
            this.cb_Nome.Size = new System.Drawing.Size(263, 27);
            this.cb_Nome.TabIndex = 26;
            this.cb_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Nome_KeyDown);
            this.cb_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Nome_KeyPress);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(356, 17);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(128, 36);
            this.btn_Buscar.TabIndex = 28;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_Ocupacao);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Telefone);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Numero);
            this.groupBox1.Controls.Add(this.lbl_Turma);
            this.groupBox1.Controls.Add(this.lbl_Ano);
            this.groupBox1.Controls.Add(this.txt_Endereco);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(515, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 228);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Usuário:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(35, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.White;
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Location = new System.Drawing.Point(94, 58);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.ReadOnly = true;
            this.txt_Nome.Size = new System.Drawing.Size(315, 26);
            this.txt_Nome.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(8, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 45;
            this.label12.Text = "Ocupação:";
            // 
            // txt_Ocupacao
            // 
            this.txt_Ocupacao.BackColor = System.Drawing.Color.White;
            this.txt_Ocupacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ocupacao.Location = new System.Drawing.Point(94, 186);
            this.txt_Ocupacao.Name = "txt_Ocupacao";
            this.txt_Ocupacao.ReadOnly = true;
            this.txt_Ocupacao.Size = new System.Drawing.Size(115, 26);
            this.txt_Ocupacao.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(16, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "Telefone:";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BackColor = System.Drawing.Color.White;
            this.txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefone.Location = new System.Drawing.Point(94, 154);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.ReadOnly = true;
            this.txt_Telefone.Size = new System.Drawing.Size(115, 26);
            this.txt_Telefone.TabIndex = 44;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.White;
            this.txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Codigo.Location = new System.Drawing.Point(94, 26);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(109, 26);
            this.txt_Codigo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.BackColor = System.Drawing.Color.White;
            this.txt_Numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Numero.Location = new System.Drawing.Point(94, 122);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.ReadOnly = true;
            this.txt_Numero.Size = new System.Drawing.Size(87, 26);
            this.txt_Numero.TabIndex = 38;
            // 
            // lbl_Turma
            // 
            this.lbl_Turma.AutoSize = true;
            this.lbl_Turma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Turma.Location = new System.Drawing.Point(20, 125);
            this.lbl_Turma.Name = "lbl_Turma";
            this.lbl_Turma.Size = new System.Drawing.Size(68, 19);
            this.lbl_Turma.TabIndex = 30;
            this.lbl_Turma.Text = "Número:";
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Ano.Location = new System.Drawing.Point(12, 93);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(77, 19);
            this.lbl_Ano.TabIndex = 36;
            this.lbl_Ano.Text = "Endereço:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.BackColor = System.Drawing.Color.White;
            this.txt_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Endereco.Location = new System.Drawing.Point(94, 90);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.ReadOnly = true;
            this.txt_Endereco.Size = new System.Drawing.Size(315, 26);
            this.txt_Endereco.TabIndex = 37;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_Quantidade);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn_Verificar);
            this.groupBox4.Controls.Add(this.txt_decisaoLivroDidatico);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox4.Location = new System.Drawing.Point(515, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 105);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Livros didáticos:";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.BackColor = System.Drawing.Color.White;
            this.txt_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantidade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(217, 65);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.ReadOnly = true;
            this.txt_Quantidade.Size = new System.Drawing.Size(51, 26);
            this.txt_Quantidade.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Quantidade:";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Enabled = false;
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Verificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.Location = new System.Drawing.Point(274, 25);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(118, 41);
            this.btn_Verificar.TabIndex = 20;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // txt_decisaoLivroDidatico
            // 
            this.txt_decisaoLivroDidatico.BackColor = System.Drawing.Color.White;
            this.txt_decisaoLivroDidatico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_decisaoLivroDidatico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_decisaoLivroDidatico.Location = new System.Drawing.Point(217, 33);
            this.txt_decisaoLivroDidatico.Name = "txt_decisaoLivroDidatico";
            this.txt_decisaoLivroDidatico.ReadOnly = true;
            this.txt_decisaoLivroDidatico.Size = new System.Drawing.Size(51, 26);
            this.txt_decisaoLivroDidatico.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Livro didático emprestado:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Titulo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_status);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_DataEntrega);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_DataSolicitacao);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_Tempo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_decisaoLivroLiterario);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox3.Location = new System.Drawing.Point(515, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 169);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obras literárias:";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BackColor = System.Drawing.Color.White;
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.Location = new System.Drawing.Point(124, 60);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.ReadOnly = true;
            this.txt_Titulo.Size = new System.Drawing.Size(382, 26);
            this.txt_Titulo.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Título do livro:";
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.White;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(283, 131);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(88, 26);
            this.txt_status.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Status:";
            // 
            // txt_DataEntrega
            // 
            this.txt_DataEntrega.BackColor = System.Drawing.Color.White;
            this.txt_DataEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataEntrega.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataEntrega.Location = new System.Drawing.Point(138, 130);
            this.txt_DataEntrega.Name = "txt_DataEntrega";
            this.txt_DataEntrega.ReadOnly = true;
            this.txt_DataEntrega.Size = new System.Drawing.Size(80, 26);
            this.txt_DataEntrega.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data de Entrega:";
            // 
            // txt_DataSolicitacao
            // 
            this.txt_DataSolicitacao.BackColor = System.Drawing.Color.White;
            this.txt_DataSolicitacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataSolicitacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataSolicitacao.Location = new System.Drawing.Point(155, 94);
            this.txt_DataSolicitacao.Name = "txt_DataSolicitacao";
            this.txt_DataSolicitacao.ReadOnly = true;
            this.txt_DataSolicitacao.Size = new System.Drawing.Size(80, 26);
            this.txt_DataSolicitacao.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data da Solicitação:";
            // 
            // txt_Tempo
            // 
            this.txt_Tempo.BackColor = System.Drawing.Color.White;
            this.txt_Tempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Tempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tempo.Location = new System.Drawing.Point(415, 95);
            this.txt_Tempo.Name = "txt_Tempo";
            this.txt_Tempo.ReadOnly = true;
            this.txt_Tempo.Size = new System.Drawing.Size(148, 26);
            this.txt_Tempo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tempo de empréstimo:";
            // 
            // txt_decisaoLivroLiterario
            // 
            this.txt_decisaoLivroLiterario.BackColor = System.Drawing.Color.White;
            this.txt_decisaoLivroLiterario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_decisaoLivroLiterario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_decisaoLivroLiterario.Location = new System.Drawing.Point(206, 19);
            this.txt_decisaoLivroLiterario.Name = "txt_decisaoLivroLiterario";
            this.txt_decisaoLivroLiterario.ReadOnly = true;
            this.txt_decisaoLivroLiterario.Size = new System.Drawing.Size(51, 26);
            this.txt_decisaoLivroLiterario.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Livro literário emprestado:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout1;
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.Location = new System.Drawing.Point(956, 34);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(122, 47);
            this.btn_Sair.TabIndex = 42;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.Image = global::Controle_de_livros.Properties.Resources.Blackvariant_Button_Ui_Requests_2_CleanMyMac_1;
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Location = new System.Drawing.Point(956, 87);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(122, 47);
            this.btn_Limpar.TabIndex = 41;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Verificar_Situacao_Funcionarios_Terceiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 534);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Verificar_Situacao_Funcionarios_Terceiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERIFICAR SIUAÇÃO DOS FUNCIONÁRIOS E TERCEIROS";
            this.Load += new System.EventHandler(this.Verificar_Situacao_Funcionarios_Terceiros_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Nome;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_Turma;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.TextBox txt_decisaoLivroDidatico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DataEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DataSolicitacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_decisaoLivroLiterario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.ComboBox cb_Nome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Ocupacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Nome;
    }
}