namespace Controle_de_livros
{
    partial class Emprestimo_Livro_DidaticoTemporaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emprestimo_Livro_DidaticoTemporaria));
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_EfetuaEmprestimo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_FazerDevolucao = new System.Windows.Forms.RadioButton();
            this.rb_EfetuarEmprestimo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Professora = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cb_Livros = new System.Windows.Forms.ComboBox();
            this.num_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.txt_Turma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout;
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.Location = new System.Drawing.Point(344, 279);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(114, 41);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_EfetuaEmprestimo
            // 
            this.btn_EfetuaEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EfetuaEmprestimo.Image = global::Controle_de_livros.Properties.Resources._8WUJ2XuE_400x4001;
            this.btn_EfetuaEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EfetuaEmprestimo.Location = new System.Drawing.Point(154, 279);
            this.btn_EfetuaEmprestimo.Name = "btn_EfetuaEmprestimo";
            this.btn_EfetuaEmprestimo.Size = new System.Drawing.Size(183, 41);
            this.btn_EfetuaEmprestimo.TabIndex = 4;
            this.btn_EfetuaEmprestimo.Text = "Efetuar empréstimo";
            this.btn_EfetuaEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EfetuaEmprestimo.Click += new System.EventHandler(this.btn_EfetuaEmprestimo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_FazerDevolucao);
            this.groupBox1.Controls.Add(this.rb_EfetuarEmprestimo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 260);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a opção";
            // 
            // rb_FazerDevolucao
            // 
            this.rb_FazerDevolucao.AutoSize = true;
            this.rb_FazerDevolucao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_FazerDevolucao.Location = new System.Drawing.Point(200, 45);
            this.rb_FazerDevolucao.Name = "rb_FazerDevolucao";
            this.rb_FazerDevolucao.Size = new System.Drawing.Size(139, 23);
            this.rb_FazerDevolucao.TabIndex = 3;
            this.rb_FazerDevolucao.Text = "Fazer Devolução";
            this.rb_FazerDevolucao.UseVisualStyleBackColor = true;
            this.rb_FazerDevolucao.CheckedChanged += new System.EventHandler(this.rb_FazerDevolucao_CheckedChanged);
            // 
            // rb_EfetuarEmprestimo
            // 
            this.rb_EfetuarEmprestimo.AutoSize = true;
            this.rb_EfetuarEmprestimo.Checked = true;
            this.rb_EfetuarEmprestimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EfetuarEmprestimo.Location = new System.Drawing.Point(26, 45);
            this.rb_EfetuarEmprestimo.Name = "rb_EfetuarEmprestimo";
            this.rb_EfetuarEmprestimo.Size = new System.Drawing.Size(159, 23);
            this.rb_EfetuarEmprestimo.TabIndex = 2;
            this.rb_EfetuarEmprestimo.TabStop = true;
            this.rb_EfetuarEmprestimo.Text = "Efetuar emprestimo";
            this.rb_EfetuarEmprestimo.UseVisualStyleBackColor = true;
            this.rb_EfetuarEmprestimo.CheckedChanged += new System.EventHandler(this.rb_EfetuarEmprestimo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Professora);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.cb_Livros);
            this.groupBox2.Controls.Add(this.num_Quantidade);
            this.groupBox2.Controls.Add(this.txt_Turma);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cb_Professora
            // 
            this.cb_Professora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Professora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_Professora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Professora.FormattingEnabled = true;
            this.cb_Professora.Location = new System.Drawing.Point(118, 34);
            this.cb_Professora.Name = "cb_Professora";
            this.cb_Professora.Size = new System.Drawing.Size(212, 21);
            this.cb_Professora.TabIndex = 14;
            this.cb_Professora.SelectedIndexChanged += new System.EventHandler(this.cb_Professora_SelectedIndexChanged);
            this.cb_Professora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Professora_KeyDown);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.Location = new System.Drawing.Point(341, 22);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 49);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Visible = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cb_Livros
            // 
            this.cb_Livros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Livros.FormattingEnabled = true;
            this.cb_Livros.Items.AddRange(new object[] {
            "",
            "ARTES",
            "BIOLOGIA",
            "CIÊNCIAS",
            "ESTUDOS SOCIAIS",
            "FILOSOFIA",
            "FÍSICA",
            "GEOGRAFIA",
            "GEOMETRIA",
            "HISTÓRIA",
            "INFORMÁTICA",
            "INGLÊS",
            "LITERATURA",
            "MATEMÁTICA",
            "PORTUGUÊS",
            "QUÍMICA",
            "RELIGIÃO",
            "SOCIOLOGIA"});
            this.cb_Livros.Location = new System.Drawing.Point(119, 98);
            this.cb_Livros.Name = "cb_Livros";
            this.cb_Livros.Size = new System.Drawing.Size(212, 27);
            this.cb_Livros.TabIndex = 2;
            this.cb_Livros.SelectedIndexChanged += new System.EventHandler(this.cb_Livros_SelectedIndexChanged);
            this.cb_Livros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Livros_KeyDown);
            // 
            // num_Quantidade
            // 
            this.num_Quantidade.Location = new System.Drawing.Point(120, 130);
            this.num_Quantidade.Name = "num_Quantidade";
            this.num_Quantidade.Size = new System.Drawing.Size(94, 26);
            this.num_Quantidade.TabIndex = 3;
            this.num_Quantidade.ValueChanged += new System.EventHandler(this.num_Quantidade_ValueChanged);
            this.num_Quantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Quantidade_KeyDown);
            // 
            // txt_Turma
            // 
            this.txt_Turma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Turma.Location = new System.Drawing.Point(119, 66);
            this.txt_Turma.MaxLength = 14;
            this.txt_Turma.Name = "txt_Turma";
            this.txt_Turma.Size = new System.Drawing.Size(116, 26);
            this.txt_Turma.TabIndex = 1;
            this.txt_Turma.TextChanged += new System.EventHandler(this.txt_Turma_TextChanged);
            this.txt_Turma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Turma_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Professor (a):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Livro:";
            // 
            // error_Provider
            // 
            this.error_Provider.ContainerControl = this;
            // 
            // Emprestimo_Livro_DidaticoTemporaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_EfetuaEmprestimo);
            this.Controls.Add(this.btn_Sair);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Emprestimo_Livro_DidaticoTemporaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPRÉSTIMO LIVRO DIDÁTICO TEMPORARIAMENTE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_EfetuaEmprestimo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_Quantidade;
        private System.Windows.Forms.TextBox txt_Turma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Livros;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private System.Windows.Forms.RadioButton rb_FazerDevolucao;
        private System.Windows.Forms.RadioButton rb_EfetuarEmprestimo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cb_Professora;
    }
}