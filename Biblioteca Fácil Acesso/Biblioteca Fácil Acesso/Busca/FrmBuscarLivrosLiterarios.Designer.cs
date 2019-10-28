namespace Controle_de_livros
{
    partial class FrmBuscarLivrosLiterarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarLivrosLiterarios));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Titulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_QuantidadeDisponivel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Estante = new System.Windows.Forms.Label();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Estante = new System.Windows.Forms.TextBox();
            this.num_QuantidadeTotalCadastrado = new System.Windows.Forms.NumericUpDown();
            this.num_QuantidadeDisponivel = new System.Windows.Forms.NumericUpDown();
            this.num_QuantidadeEmprestadas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeTotalCadastrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeDisponivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeEmprestadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Autor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Titulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 81);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // cb_Titulo
            // 
            this.cb_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Titulo.FormattingEnabled = true;
            this.cb_Titulo.Location = new System.Drawing.Point(86, 37);
            this.cb_Titulo.Name = "cb_Titulo";
            this.cb_Titulo.Size = new System.Drawing.Size(323, 27);
            this.cb_Titulo.TabIndex = 10;
            this.cb_Titulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Titulo_KeyDown);
            this.cb_Titulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Titulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Título:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.Location = new System.Drawing.Point(423, 25);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 48);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_QuantidadeDisponivel
            // 
            this.lbl_QuantidadeDisponivel.AutoSize = true;
            this.lbl_QuantidadeDisponivel.Location = new System.Drawing.Point(165, 204);
            this.lbl_QuantidadeDisponivel.Name = "lbl_QuantidadeDisponivel";
            this.lbl_QuantidadeDisponivel.Size = new System.Drawing.Size(0, 19);
            this.lbl_QuantidadeDisponivel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantidade disponível para empréstimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantidade de livros cadastrados:";
            // 
            // Estante
            // 
            this.Estante.AutoSize = true;
            this.Estante.Location = new System.Drawing.Point(7, 141);
            this.Estante.Name = "Estante";
            this.Estante.Size = new System.Drawing.Size(65, 19);
            this.Estante.TabIndex = 18;
            this.Estante.Text = "Estante:";
            // 
            // txt_Autor
            // 
            this.txt_Autor.BackColor = System.Drawing.Color.White;
            this.txt_Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autor.Location = new System.Drawing.Point(78, 106);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.ReadOnly = true;
            this.txt_Autor.Size = new System.Drawing.Size(401, 26);
            this.txt_Autor.TabIndex = 25;
            // 
            // txt_Estante
            // 
            this.txt_Estante.BackColor = System.Drawing.Color.White;
            this.txt_Estante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Estante.Location = new System.Drawing.Point(78, 138);
            this.txt_Estante.Name = "txt_Estante";
            this.txt_Estante.ReadOnly = true;
            this.txt_Estante.Size = new System.Drawing.Size(63, 26);
            this.txt_Estante.TabIndex = 26;
            // 
            // num_QuantidadeTotalCadastrado
            // 
            this.num_QuantidadeTotalCadastrado.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeTotalCadastrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_QuantidadeTotalCadastrado.Location = new System.Drawing.Point(410, 138);
            this.num_QuantidadeTotalCadastrado.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_QuantidadeTotalCadastrado.Name = "num_QuantidadeTotalCadastrado";
            this.num_QuantidadeTotalCadastrado.ReadOnly = true;
            this.num_QuantidadeTotalCadastrado.Size = new System.Drawing.Size(120, 26);
            this.num_QuantidadeTotalCadastrado.TabIndex = 27;
            // 
            // num_QuantidadeDisponivel
            // 
            this.num_QuantidadeDisponivel.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_QuantidadeDisponivel.Location = new System.Drawing.Point(410, 170);
            this.num_QuantidadeDisponivel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_QuantidadeDisponivel.Name = "num_QuantidadeDisponivel";
            this.num_QuantidadeDisponivel.ReadOnly = true;
            this.num_QuantidadeDisponivel.Size = new System.Drawing.Size(120, 26);
            this.num_QuantidadeDisponivel.TabIndex = 28;
            // 
            // num_QuantidadeEmprestadas
            // 
            this.num_QuantidadeEmprestadas.BackColor = System.Drawing.Color.White;
            this.num_QuantidadeEmprestadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_QuantidadeEmprestadas.Location = new System.Drawing.Point(410, 204);
            this.num_QuantidadeEmprestadas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_QuantidadeEmprestadas.Name = "num_QuantidadeEmprestadas";
            this.num_QuantidadeEmprestadas.ReadOnly = true;
            this.num_QuantidadeEmprestadas.Size = new System.Drawing.Size(120, 26);
            this.num_QuantidadeEmprestadas.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quantidade  de livros emprestadas:";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Enabled = false;
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Verificar.Location = new System.Drawing.Point(11, 245);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(522, 50);
            this.btn_Verificar.TabIndex = 31;
            this.btn_Verificar.Text = "Verificar com quem o livro está emprestado";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.Image = global::Controle_de_livros.Properties.Resources.CleanMyMac_1_icon;
            this.btn_Limpar.Location = new System.Drawing.Point(11, 302);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(519, 67);
            this.btn_Limpar.TabIndex = 41;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // FrmBuscarLivrosLiterarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 378);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.num_QuantidadeEmprestadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_QuantidadeDisponivel);
            this.Controls.Add(this.num_QuantidadeTotalCadastrado);
            this.Controls.Add(this.txt_Estante);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_QuantidadeDisponivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Estante);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarLivrosLiterarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR LÍVROS LITERÁRIOS";
            this.Load += new System.EventHandler(this.Buscar_livros_Literarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeTotalCadastrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeDisponivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QuantidadeEmprestadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_QuantidadeDisponivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Estante;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txt_Estante;
        private System.Windows.Forms.NumericUpDown num_QuantidadeTotalCadastrado;
        private System.Windows.Forms.NumericUpDown num_QuantidadeDisponivel;
        private System.Windows.Forms.NumericUpDown num_QuantidadeEmprestadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.ComboBox cb_Titulo;
        private System.Windows.Forms.Button btn_Limpar;
    }
}