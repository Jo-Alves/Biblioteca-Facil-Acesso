namespace Controle_de_livros
{
    partial class Devolucao_livro_didatico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucao_livro_didatico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Opcao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Ensino = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Ocupacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Disciplina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Turma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DataSolicitacao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn_EfetuarDevolucao = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.txt_Buscar);
            this.groupBox1.Controls.Add(this.lbl_Opcao);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 86);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(232, 25);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(125, 38);
            this.btn_Buscar.TabIndex = 19;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Buscar.Location = new System.Drawing.Point(99, 32);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(127, 26);
            this.txt_Buscar.TabIndex = 10;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            this.txt_Buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Buscar_KeyDown);
            this.txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscar_KeyPress);
            // 
            // lbl_Opcao
            // 
            this.lbl_Opcao.AutoSize = true;
            this.lbl_Opcao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Opcao.Location = new System.Drawing.Point(0, 35);
            this.lbl_Opcao.Name = "lbl_Opcao";
            this.lbl_Opcao.Size = new System.Drawing.Size(93, 19);
            this.lbl_Opcao.TabIndex = 9;
            this.lbl_Opcao.Text = "Nº Registro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Ensino);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_Ano);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_Ocupacao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_Disciplina);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_Turma);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_Nome);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_DataSolicitacao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(16, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 256);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informação da transação do empréstimo:";
            // 
            // lbl_Ensino
            // 
            this.lbl_Ensino.AutoSize = true;
            this.lbl_Ensino.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Ensino.Location = new System.Drawing.Point(71, 189);
            this.lbl_Ensino.Name = "lbl_Ensino";
            this.lbl_Ensino.Size = new System.Drawing.Size(0, 19);
            this.lbl_Ensino.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ensino:";
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Ano.Location = new System.Drawing.Point(53, 93);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(0, 19);
            this.lbl_Ano.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ano:";
            // 
            // lbl_Ocupacao
            // 
            this.lbl_Ocupacao.AutoSize = true;
            this.lbl_Ocupacao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Ocupacao.Location = new System.Drawing.Point(92, 220);
            this.lbl_Ocupacao.Name = "lbl_Ocupacao";
            this.lbl_Ocupacao.Size = new System.Drawing.Size(0, 19);
            this.lbl_Ocupacao.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ocupação:";
            // 
            // lbl_Disciplina
            // 
            this.lbl_Disciplina.AutoSize = true;
            this.lbl_Disciplina.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Disciplina.Location = new System.Drawing.Point(92, 154);
            this.lbl_Disciplina.Name = "lbl_Disciplina";
            this.lbl_Disciplina.Size = new System.Drawing.Size(0, 19);
            this.lbl_Disciplina.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Disciplina:";
            // 
            // lbl_Turma
            // 
            this.lbl_Turma.AutoSize = true;
            this.lbl_Turma.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Turma.Location = new System.Drawing.Point(69, 121);
            this.lbl_Turma.Name = "lbl_Turma";
            this.lbl_Turma.Size = new System.Drawing.Size(0, 19);
            this.lbl_Turma.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Turma:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Nome.Location = new System.Drawing.Point(139, 65);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(0, 19);
            this.lbl_Nome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do usuário:";
            // 
            // lbl_DataSolicitacao
            // 
            this.lbl_DataSolicitacao.AutoSize = true;
            this.lbl_DataSolicitacao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_DataSolicitacao.Location = new System.Drawing.Point(153, 35);
            this.lbl_DataSolicitacao.Name = "lbl_DataSolicitacao";
            this.lbl_DataSolicitacao.Size = new System.Drawing.Size(0, 19);
            this.lbl_DataSolicitacao.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data da solicitação:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(406, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 46);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_EfetuarDevolucao
            // 
            this.btn_EfetuarDevolucao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EfetuarDevolucao.Image = global::Controle_de_livros.Properties.Resources._8WUJ2XuE_400x4001;
            this.btn_EfetuarDevolucao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EfetuarDevolucao.Location = new System.Drawing.Point(223, 375);
            this.btn_EfetuarDevolucao.Name = "btn_EfetuarDevolucao";
            this.btn_EfetuarDevolucao.Size = new System.Drawing.Size(177, 46);
            this.btn_EfetuarDevolucao.TabIndex = 20;
            this.btn_EfetuarDevolucao.Text = "Efetuar Devolução";
            this.btn_EfetuarDevolucao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EfetuarDevolucao.UseVisualStyleBackColor = true;
            this.btn_EfetuarDevolucao.Click += new System.EventHandler(this.btn_EfetuarDevolucao_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Image = global::Controle_de_livros.Properties.Resources.Blackvariant_Button_Ui_Requests_2_CleanMyMac_1;
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Location = new System.Drawing.Point(123, 375);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(94, 46);
            this.btn_Limpar.TabIndex = 23;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Devolucao_livro_didatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 433);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_EfetuarDevolucao);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Devolucao_livro_didatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEVOLUÇÃO LIVRO DIDÁTICO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Opcao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Ocupacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Disciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Turma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DataSolicitacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btn_EfetuarDevolucao;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Ensino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Limpar;
    }
}