namespace Controle_de_livros
{
    partial class FrmLivroDidatico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivroDidatico));
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Registro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDataRegistro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Disciplina = new System.Windows.Forms.ComboBox();
            this.cb_Volume = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Ensino = new System.Windows.Forms.ComboBox();
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salvar.Image = global::Controle_de_livros.Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salvar.Location = new System.Drawing.Point(9, 224);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(152, 41);
            this.btn_Salvar.TabIndex = 6;
            this.btn_Salvar.Text = "Salvar - F1";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txt_Autor
            // 
            this.txt_Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autor.Location = new System.Drawing.Point(258, 102);
            this.txt_Autor.MaxLength = 100;
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(360, 26);
            this.txt_Autor.TabIndex = 2;
            this.txt_Autor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Autor_KeyDown);
            this.txt_Autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Autor_KeyPress);
            // 
            // txt_Registro
            // 
            this.txt_Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Registro.Location = new System.Drawing.Point(29, 50);
            this.txt_Registro.MaxLength = 9;
            this.txt_Registro.Name = "txt_Registro";
            this.txt_Registro.Size = new System.Drawing.Size(100, 26);
            this.txt_Registro.TabIndex = 0;
            this.txt_Registro.TextChanged += new System.EventHandler(this.txt_Registro_TextChanged);
            this.txt_Registro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Registro_KeyDown);
            this.txt_Registro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Registro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ensino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disciplina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Registro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDataRegistro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_Disciplina);
            this.groupBox1.Controls.Add(this.cb_Volume);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_Ensino);
            this.groupBox1.Controls.Add(this.txt_Autor);
            this.groupBox1.Controls.Add(this.txt_Registro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Livro:";
            // 
            // dtDataRegistro
            // 
            this.dtDataRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataRegistro.Location = new System.Drawing.Point(453, 165);
            this.dtDataRegistro.Name = "dtDataRegistro";
            this.dtDataRegistro.Size = new System.Drawing.Size(111, 26);
            this.dtDataRegistro.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data de Registro:";
            // 
            // cb_Disciplina
            // 
            this.cb_Disciplina.FormattingEnabled = true;
            this.cb_Disciplina.Items.AddRange(new object[] {
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
            this.cb_Disciplina.Location = new System.Drawing.Point(29, 101);
            this.cb_Disciplina.MaxLength = 300;
            this.cb_Disciplina.Name = "cb_Disciplina";
            this.cb_Disciplina.Size = new System.Drawing.Size(212, 27);
            this.cb_Disciplina.TabIndex = 1;
            this.cb_Disciplina.SelectedIndexChanged += new System.EventHandler(this.cb_Disciplina_SelectedIndexChanged);
            // 
            // cb_Volume
            // 
            this.cb_Volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Volume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Volume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Volume.FormattingEnabled = true;
            this.cb_Volume.Items.AddRange(new object[] {
            "Volume 1 - 1º Ano",
            "Volume 2 - 2º Ano",
            "Volume 3 - 3º Ano",
            "Volume 4 - 4º Ano",
            "Volume 5 - 5º Ano",
            "Volume 6 - 6º Ano",
            "Volume 7 - 7º Ano",
            "Volume 8 - 8º Ano",
            "Volume 9 - 9º Ano",
            "Volume único"});
            this.cb_Volume.Location = new System.Drawing.Point(277, 159);
            this.cb_Volume.Name = "cb_Volume";
            this.cb_Volume.Size = new System.Drawing.Size(165, 27);
            this.cb_Volume.TabIndex = 4;
            this.cb_Volume.SelectedIndexChanged += new System.EventHandler(this.cb_Volume_SelectedIndexChanged);
            this.cb_Volume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Volume_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Volume:";
            // 
            // cb_Ensino
            // 
            this.cb_Ensino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Ensino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ensino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Ensino.FormattingEnabled = true;
            this.cb_Ensino.Items.AddRange(new object[] {
            "ENSINO FUNDAMENTAL",
            "ENSINO MÉDIO"});
            this.cb_Ensino.Location = new System.Drawing.Point(29, 159);
            this.cb_Ensino.Name = "cb_Ensino";
            this.cb_Ensino.Size = new System.Drawing.Size(237, 27);
            this.cb_Ensino.TabIndex = 3;
            this.cb_Ensino.SelectedIndexChanged += new System.EventHandler(this.cb_Ensino_SelectedIndexChanged);
            this.cb_Ensino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Ensino_KeyDown);
            // 
            // error_Provider
            // 
            this.error_Provider.ContainerControl = this;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = global::Controle_de_livros.Properties.Resources.Button_Delete_icon_32x32;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(489, 222);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(155, 41);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir - F4";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Image = global::Controle_de_livros.Properties.Resources.Edit_Document_icon_32x32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(334, 224);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 41);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar - F3";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Image = global::Controle_de_livros.Properties.Resources.Jommans_Briefness_Search__1_;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(168, 224);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(158, 41);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar - F2";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmLivroDidatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 278);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLivroDidatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADATRO LIVRO DIDÁTICO";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLivroDidatico_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txt_Registro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Ensino;
        private System.Windows.Forms.ComboBox cb_Volume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private System.Windows.Forms.ComboBox cb_Disciplina;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtDataRegistro;
        private System.Windows.Forms.Label label6;
    }
}