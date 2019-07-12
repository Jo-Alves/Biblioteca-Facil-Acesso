namespace Controle_de_livros
{
    partial class Emprestimo_livro_literario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emprestimo_livro_literario));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BuscarRegistro = new System.Windows.Forms.Button();
            this.btn_LimparLivro = new System.Windows.Forms.Button();
            this.lbl_DataSolicitacao = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Registro = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarUsuario = new System.Windows.Forms.Button();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_LimparUsu = new System.Windows.Forms.Button();
            this.lbl_Ocupacao = new System.Windows.Forms.Label();
            this.lbl_Turma = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn_EfetuaEmprestimo = new System.Windows.Forms.Button();
            this.lbl_Prazo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data da solicitação:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Prazo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_Autor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_BuscarRegistro);
            this.groupBox2.Controls.Add(this.btn_LimparLivro);
            this.groupBox2.Controls.Add(this.lbl_DataSolicitacao);
            this.groupBox2.Controls.Add(this.lbl_Titulo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_Registro);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(420, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 283);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Livro:";
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Autor.Location = new System.Drawing.Point(65, 111);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(0, 19);
            this.lbl_Autor.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Autor:";
            // 
            // btn_BuscarRegistro
            // 
            this.btn_BuscarRegistro.Image = global::Controle_de_livros.Properties.Resources.Jommans_Briefness_Search__1_;
            this.btn_BuscarRegistro.Location = new System.Drawing.Point(220, 18);
            this.btn_BuscarRegistro.Name = "btn_BuscarRegistro";
            this.btn_BuscarRegistro.Size = new System.Drawing.Size(75, 36);
            this.btn_BuscarRegistro.TabIndex = 22;
            this.btn_BuscarRegistro.UseVisualStyleBackColor = true;
            this.btn_BuscarRegistro.Click += new System.EventHandler(this.btn_BuscarRegistro_Click);
            // 
            // btn_LimparLivro
            // 
            this.btn_LimparLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimparLivro.Image = global::Controle_de_livros.Properties.Resources.Blackvariant_Button_Ui_Requests_2_CleanMyMac_1;
            this.btn_LimparLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LimparLivro.Location = new System.Drawing.Point(6, 235);
            this.btn_LimparLivro.Name = "btn_LimparLivro";
            this.btn_LimparLivro.Size = new System.Drawing.Size(94, 41);
            this.btn_LimparLivro.TabIndex = 4;
            this.btn_LimparLivro.Text = "Limpar";
            this.btn_LimparLivro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LimparLivro.Click += new System.EventHandler(this.btn_LimparLivro_Click);
            // 
            // lbl_DataSolicitacao
            // 
            this.lbl_DataSolicitacao.AutoSize = true;
            this.lbl_DataSolicitacao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_DataSolicitacao.Location = new System.Drawing.Point(153, 156);
            this.lbl_DataSolicitacao.Name = "lbl_DataSolicitacao";
            this.lbl_DataSolicitacao.Size = new System.Drawing.Size(0, 19);
            this.lbl_DataSolicitacao.TabIndex = 6;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Titulo.Location = new System.Drawing.Point(65, 66);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(0, 19);
            this.lbl_Titulo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Título:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nº Registro:";
            // 
            // txt_Registro
            // 
            this.txt_Registro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Registro.Location = new System.Drawing.Point(106, 24);
            this.txt_Registro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Registro.Name = "txt_Registro";
            this.txt_Registro.Size = new System.Drawing.Size(107, 26);
            this.txt_Registro.TabIndex = 1;
            this.txt_Registro.TextChanged += new System.EventHandler(this.txt_Registro_TextChanged);
            this.txt_Registro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Registro_KeyDown);
            this.txt_Registro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Registro_KeyPress);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(132, 24);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 26);
            this.txt_Codigo.TabIndex = 0;
            this.txt_Codigo.TextChanged += new System.EventHandler(this.txt_Codigo_TextChanged);
            this.txt_Codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Codigo_KeyDown);
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_BuscarUsuario);
            this.groupBox3.Controls.Add(this.lbl_Ano);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_LimparUsu);
            this.groupBox3.Controls.Add(this.txt_Codigo);
            this.groupBox3.Controls.Add(this.lbl_Ocupacao);
            this.groupBox3.Controls.Add(this.lbl_Turma);
            this.groupBox3.Controls.Add(this.lbl_Nome);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(400, 290);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do usuário:";
            // 
            // btn_BuscarUsuario
            // 
            this.btn_BuscarUsuario.Image = global::Controle_de_livros.Properties.Resources.Jommans_Briefness_Search__1_;
            this.btn_BuscarUsuario.Location = new System.Drawing.Point(238, 18);
            this.btn_BuscarUsuario.Name = "btn_BuscarUsuario";
            this.btn_BuscarUsuario.Size = new System.Drawing.Size(75, 36);
            this.btn_BuscarUsuario.TabIndex = 21;
            this.btn_BuscarUsuario.UseVisualStyleBackColor = true;
            this.btn_BuscarUsuario.Click += new System.EventHandler(this.btn_BuscarUsuario_Click);
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Ano.Location = new System.Drawing.Point(50, 94);
            this.lbl_Ano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(0, 19);
            this.lbl_Ano.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ano:";
            // 
            // btn_LimparUsu
            // 
            this.btn_LimparUsu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimparUsu.Image = global::Controle_de_livros.Properties.Resources.Blackvariant_Button_Ui_Requests_2_CleanMyMac_1;
            this.btn_LimparUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LimparUsu.Location = new System.Drawing.Point(299, 242);
            this.btn_LimparUsu.Name = "btn_LimparUsu";
            this.btn_LimparUsu.Size = new System.Drawing.Size(94, 41);
            this.btn_LimparUsu.TabIndex = 2;
            this.btn_LimparUsu.Text = "Limpar";
            this.btn_LimparUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LimparUsu.UseVisualStyleBackColor = true;
            this.btn_LimparUsu.Click += new System.EventHandler(this.btn_LimparUsu_Click);
            // 
            // lbl_Ocupacao
            // 
            this.lbl_Ocupacao.AutoSize = true;
            this.lbl_Ocupacao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Ocupacao.Location = new System.Drawing.Point(91, 166);
            this.lbl_Ocupacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ocupacao.Name = "lbl_Ocupacao";
            this.lbl_Ocupacao.Size = new System.Drawing.Size(0, 19);
            this.lbl_Ocupacao.TabIndex = 15;
            // 
            // lbl_Turma
            // 
            this.lbl_Turma.AutoSize = true;
            this.lbl_Turma.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Turma.Location = new System.Drawing.Point(73, 133);
            this.lbl_Turma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Turma.Name = "lbl_Turma";
            this.lbl_Turma.Size = new System.Drawing.Size(0, 19);
            this.lbl_Turma.TabIndex = 14;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Nome.Location = new System.Drawing.Point(65, 60);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(0, 19);
            this.lbl_Nome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ocupação:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Turma:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Código Usuário:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Controle_de_livros.Properties.Resources.cancelar1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(419, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar empréstimo";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_EfetuaEmprestimo
            // 
            this.btn_EfetuaEmprestimo.Image = global::Controle_de_livros.Properties.Resources._8WUJ2XuE_400x4001;
            this.btn_EfetuaEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EfetuaEmprestimo.Location = new System.Drawing.Point(230, 308);
            this.btn_EfetuaEmprestimo.Name = "btn_EfetuaEmprestimo";
            this.btn_EfetuaEmprestimo.Size = new System.Drawing.Size(183, 41);
            this.btn_EfetuaEmprestimo.TabIndex = 3;
            this.btn_EfetuaEmprestimo.Text = "Efetuar empréstimo";
            this.btn_EfetuaEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EfetuaEmprestimo.Click += new System.EventHandler(this.btn_EfetuaEmprestimo_Click);
            // 
            // lbl_Prazo
            // 
            this.lbl_Prazo.AutoSize = true;
            this.lbl_Prazo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Prazo.Location = new System.Drawing.Point(138, 202);
            this.lbl_Prazo.Name = "lbl_Prazo";
            this.lbl_Prazo.Size = new System.Drawing.Size(0, 19);
            this.lbl_Prazo.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Prazo de entrega:";
            // 
            // Emprestimo_livro_literario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 361);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_EfetuaEmprestimo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Emprestimo_livro_literario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPRÉSTIMO LIVRO LITERÁRIO";
            this.Load += new System.EventHandler(this.Emprestimo_livro_literario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_DataSolicitacao;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Registro;
        private System.Windows.Forms.Button btn_LimparLivro;
        private System.Windows.Forms.Button btn_LimparUsu;
        private System.Windows.Forms.Label lbl_Ocupacao;
        private System.Windows.Forms.Label lbl_Turma;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EfetuaEmprestimo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_BuscarUsuario;
        private System.Windows.Forms.Button btn_BuscarRegistro;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Prazo;
        private System.Windows.Forms.Label label4;
    }
}