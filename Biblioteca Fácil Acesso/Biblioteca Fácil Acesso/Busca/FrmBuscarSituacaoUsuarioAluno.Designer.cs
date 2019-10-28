namespace Controle_de_livros
{
    partial class FrmBuscarSituacaoUsuarioAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarSituacaoUsuarioAluno));
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_QuantidadeLivroDidaticoEmprestado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_VerificarLivrosDidaticosEmprestados = new System.Windows.Forms.Button();
            this.txt_decisaoLivroDidatico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_VerificarLivrosLiterariosEmprestados = new System.Windows.Forms.Button();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QuantidadeLivroLiterarioEmprestado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Turma = new System.Windows.Forms.TextBox();
            this.lbl_Turma = new System.Windows.Forms.Label();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Nome = new System.Windows.Forms.DataGridView();
            this.cb_Nome = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Controle_de_livros.DataSet_s.DataSet1();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter1 = new Controle_de_livros.DataSet_s.DataSet1TableAdapters.UsuarioTableAdapter();
            this.dataSet_Usuario = new Controle_de_livros.DataSet_s.DataSet_Usuario();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.Image = global::Controle_de_livros.Properties.Resources.Blackvariant_Button_Ui_Requests_2_CleanMyMac_1;
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Location = new System.Drawing.Point(839, 532);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(122, 47);
            this.btn_Limpar.TabIndex = 12;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_QuantidadeLivroDidaticoEmprestado);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn_VerificarLivrosDidaticosEmprestados);
            this.groupBox4.Controls.Add(this.txt_decisaoLivroDidatico);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox4.Location = new System.Drawing.Point(515, 421);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 105);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Livros didáticos:";
            // 
            // txt_QuantidadeLivroDidaticoEmprestado
            // 
            this.txt_QuantidadeLivroDidaticoEmprestado.BackColor = System.Drawing.Color.White;
            this.txt_QuantidadeLivroDidaticoEmprestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_QuantidadeLivroDidaticoEmprestado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantidadeLivroDidaticoEmprestado.Location = new System.Drawing.Point(217, 65);
            this.txt_QuantidadeLivroDidaticoEmprestado.Name = "txt_QuantidadeLivroDidaticoEmprestado";
            this.txt_QuantidadeLivroDidaticoEmprestado.ReadOnly = true;
            this.txt_QuantidadeLivroDidaticoEmprestado.Size = new System.Drawing.Size(51, 26);
            this.txt_QuantidadeLivroDidaticoEmprestado.TabIndex = 22;
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
            // btn_VerificarLivrosDidaticosEmprestados
            // 
            this.btn_VerificarLivrosDidaticosEmprestados.Enabled = false;
            this.btn_VerificarLivrosDidaticosEmprestados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VerificarLivrosDidaticosEmprestados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerificarLivrosDidaticosEmprestados.Location = new System.Drawing.Point(274, 25);
            this.btn_VerificarLivrosDidaticosEmprestados.Name = "btn_VerificarLivrosDidaticosEmprestados";
            this.btn_VerificarLivrosDidaticosEmprestados.Size = new System.Drawing.Size(118, 41);
            this.btn_VerificarLivrosDidaticosEmprestados.TabIndex = 20;
            this.btn_VerificarLivrosDidaticosEmprestados.Text = "Verificar";
            this.btn_VerificarLivrosDidaticosEmprestados.UseVisualStyleBackColor = true;
            this.btn_VerificarLivrosDidaticosEmprestados.Click += new System.EventHandler(this.btn_VerificarLivrosDidaticosEmprestados_Click);
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
            this.groupBox3.Controls.Add(this.btn_VerificarLivrosLiterariosEmprestados);
            this.groupBox3.Controls.Add(this.txtSituacao);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_QuantidadeLivroLiterarioEmprestado);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox3.Location = new System.Drawing.Point(515, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 131);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obras literárias:";
            // 
            // btn_VerificarLivrosLiterariosEmprestados
            // 
            this.btn_VerificarLivrosLiterariosEmprestados.Enabled = false;
            this.btn_VerificarLivrosLiterariosEmprestados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VerificarLivrosLiterariosEmprestados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerificarLivrosLiterariosEmprestados.Location = new System.Drawing.Point(25, 61);
            this.btn_VerificarLivrosLiterariosEmprestados.Name = "btn_VerificarLivrosLiterariosEmprestados";
            this.btn_VerificarLivrosLiterariosEmprestados.Size = new System.Drawing.Size(543, 47);
            this.btn_VerificarLivrosLiterariosEmprestados.TabIndex = 37;
            this.btn_VerificarLivrosLiterariosEmprestados.Text = "Verificar";
            this.btn_VerificarLivrosLiterariosEmprestados.UseVisualStyleBackColor = true;
            this.btn_VerificarLivrosLiterariosEmprestados.Click += new System.EventHandler(this.btn_VerificarLivrosLiterariosEmprestados_Click);
            // 
            // txtSituacao
            // 
            this.txtSituacao.BackColor = System.Drawing.Color.White;
            this.txtSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSituacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(392, 20);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(176, 26);
            this.txtSituacao.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Situação:";
            // 
            // txt_QuantidadeLivroLiterarioEmprestado
            // 
            this.txt_QuantidadeLivroLiterarioEmprestado.BackColor = System.Drawing.Color.White;
            this.txt_QuantidadeLivroLiterarioEmprestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_QuantidadeLivroLiterarioEmprestado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantidadeLivroLiterarioEmprestado.Location = new System.Drawing.Point(258, 20);
            this.txt_QuantidadeLivroLiterarioEmprestado.Name = "txt_QuantidadeLivroLiterarioEmprestado";
            this.txt_QuantidadeLivroLiterarioEmprestado.ReadOnly = true;
            this.txt_QuantidadeLivroLiterarioEmprestado.Size = new System.Drawing.Size(51, 26);
            this.txt_QuantidadeLivroLiterarioEmprestado.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade de livros emprestados:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Telefone);
            this.groupBox1.Controls.Add(this.txt_Numero);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_Endereco);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Turma);
            this.groupBox1.Controls.Add(this.lbl_Turma);
            this.groupBox1.Controls.Add(this.lbl_Ano);
            this.groupBox1.Controls.Add(this.txt_Ano);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(515, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 266);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Usuário:";
            // 
            // txtUF
            // 
            this.txtUF.BackColor = System.Drawing.Color.White;
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUF.Location = new System.Drawing.Point(486, 189);
            this.txtUF.Name = "txtUF";
            this.txtUF.ReadOnly = true;
            this.txtUF.Size = new System.Drawing.Size(65, 26);
            this.txtUF.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(446, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 71;
            this.label8.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(94, 189);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(346, 26);
            this.txtCidade.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(27, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(195, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(258, 124);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(293, 26);
            this.txtBairro.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.White;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(94, 122);
            this.txtCep.Name = "txtCep";
            this.txtCep.ReadOnly = true;
            this.txtCep.Size = new System.Drawing.Size(87, 26);
            this.txtCep.TabIndex = 66;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(16, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 61;
            this.label11.Text = "Telefone:";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BackColor = System.Drawing.Color.White;
            this.txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefone.Location = new System.Drawing.Point(94, 221);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.ReadOnly = true;
            this.txt_Telefone.Size = new System.Drawing.Size(115, 26);
            this.txt_Telefone.TabIndex = 62;
            // 
            // txt_Numero
            // 
            this.txt_Numero.BackColor = System.Drawing.Color.White;
            this.txt_Numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Numero.Location = new System.Drawing.Point(486, 157);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.ReadOnly = true;
            this.txt_Numero.Size = new System.Drawing.Size(65, 26);
            this.txt_Numero.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(412, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 57;
            this.label13.Text = "Número:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(12, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 19);
            this.label14.TabIndex = 58;
            this.label14.Text = "Endereço:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.BackColor = System.Drawing.Color.White;
            this.txt_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Endereco.Location = new System.Drawing.Point(94, 156);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.ReadOnly = true;
            this.txt_Endereco.Size = new System.Drawing.Size(312, 26);
            this.txt_Endereco.TabIndex = 59;
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
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código:";
            // 
            // txt_Turma
            // 
            this.txt_Turma.BackColor = System.Drawing.Color.White;
            this.txt_Turma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Turma.Location = new System.Drawing.Point(94, 90);
            this.txt_Turma.Name = "txt_Turma";
            this.txt_Turma.ReadOnly = true;
            this.txt_Turma.Size = new System.Drawing.Size(457, 26);
            this.txt_Turma.TabIndex = 38;
            // 
            // lbl_Turma
            // 
            this.lbl_Turma.AutoSize = true;
            this.lbl_Turma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Turma.Location = new System.Drawing.Point(31, 93);
            this.lbl_Turma.Name = "lbl_Turma";
            this.lbl_Turma.Size = new System.Drawing.Size(57, 19);
            this.lbl_Turma.TabIndex = 30;
            this.lbl_Turma.Text = "Turma:";
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Ano.Location = new System.Drawing.Point(47, 58);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(41, 19);
            this.lbl_Ano.TabIndex = 36;
            this.lbl_Ano.Text = "Ano:";
            // 
            // txt_Ano
            // 
            this.txt_Ano.BackColor = System.Drawing.Color.White;
            this.txt_Ano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ano.Location = new System.Drawing.Point(94, 58);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.ReadOnly = true;
            this.txt_Ano.Size = new System.Drawing.Size(457, 26);
            this.txt_Ano.TabIndex = 37;
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout1;
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.Location = new System.Drawing.Point(967, 532);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(122, 47);
            this.btn_Sair.TabIndex = 35;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Nome);
            this.groupBox2.Controls.Add(this.cb_Nome);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 514);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_Nome
            // 
            this.dataGridView_Nome.AllowUserToAddRows = false;
            this.dataGridView_Nome.AllowUserToDeleteRows = false;
            this.dataGridView_Nome.AllowUserToOrderColumns = true;
            this.dataGridView_Nome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Nome.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
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
            this.dataGridView_Nome.Size = new System.Drawing.Size(478, 314);
            this.dataGridView_Nome.TabIndex = 29;
            this.dataGridView_Nome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Nome_CellClick);
            this.dataGridView_Nome.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Nome_DataBindingComplete);
            // 
            // cb_Nome
            // 
            this.cb_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Nome.DataSource = this.usuarioBindingSource2;
            this.cb_Nome.DisplayMember = "Nome_Usuario";
            this.cb_Nome.FormattingEnabled = true;
            this.cb_Nome.Location = new System.Drawing.Point(87, 21);
            this.cb_Nome.Name = "cb_Nome";
            this.cb_Nome.Size = new System.Drawing.Size(263, 27);
            this.cb_Nome.TabIndex = 26;
            this.cb_Nome.SelectedIndexChanged += new System.EventHandler(this.cb_Nome_SelectedIndexChanged);
            this.cb_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Nome_KeyDown);
            this.cb_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Nome_KeyPress);
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "Usuario";
            this.usuarioBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(356, 17);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(98, 36);
            this.btn_Buscar.TabIndex = 28;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet_Usuario
            // 
            this.dataSet_Usuario.DataSetName = "DataSet_Usuario";
            this.dataSet_Usuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmBuscarSituacaoUsuarioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Limpar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarSituacaoUsuarioAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERIFICAR SITUAÇÃO DO ALUNO";
            this.Load += new System.EventHandler(this.Buscar_Situacao_Usuario_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_VerificarLivrosDidaticosEmprestados;
        private System.Windows.Forms.TextBox txt_decisaoLivroDidatico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_QuantidadeLivroDidaticoEmprestado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_QuantidadeLivroLiterarioEmprestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Turma;
        private System.Windows.Forms.Label lbl_Turma;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cb_Nome;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label1;
        private DataSet_s.DataSet1 dataSet1;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private DataSet_s.DataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private DataSet_s.DataSet_Usuario dataSet_Usuario;
        private System.Windows.Forms.Button btn_VerificarLivrosLiterariosEmprestados;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Endereco;
    }
}