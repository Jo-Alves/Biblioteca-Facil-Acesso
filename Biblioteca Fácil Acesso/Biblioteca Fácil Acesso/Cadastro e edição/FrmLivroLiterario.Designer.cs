namespace Controle_de_livros
{
    partial class FrmLivroLiterario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivroLiterario));
            this.txt_Genero = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_Registro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDataRegistro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Estante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Genero
            // 
            this.txt_Genero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Genero.Location = new System.Drawing.Point(29, 204);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.Size = new System.Drawing.Size(188, 26);
            this.txt_Genero.TabIndex = 7;
            this.txt_Genero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Genero_KeyDown);
            this.txt_Genero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Genero_KeyPress);
            // 
            // txt_Autor
            // 
            this.txt_Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autor.Location = new System.Drawing.Point(29, 152);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(627, 26);
            this.txt_Autor.TabIndex = 6;
            this.txt_Autor.TextChanged += new System.EventHandler(this.txt_Autor_TextChanged);
            this.txt_Autor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Autor_KeyDown);
            this.txt_Autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Autor_KeyPress);
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Titulo.Location = new System.Drawing.Point(29, 101);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(627, 26);
            this.txt_Titulo.TabIndex = 5;
            this.txt_Titulo.TextChanged += new System.EventHandler(this.txt_Titulo_TextChanged);
            this.txt_Titulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Titulo_KeyDown);
            // 
            // txt_Registro
            // 
            this.txt_Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Registro.Location = new System.Drawing.Point(26, 50);
            this.txt_Registro.Name = "txt_Registro";
            this.txt_Registro.Size = new System.Drawing.Size(100, 26);
            this.txt_Registro.TabIndex = 4;
            this.txt_Registro.TextChanged += new System.EventHandler(this.txt_Registro_TextChanged);
            this.txt_Registro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Registro_KeyDown);
            this.txt_Registro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Registro_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDataRegistro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_Estante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Genero);
            this.groupBox1.Controls.Add(this.txt_Autor);
            this.groupBox1.Controls.Add(this.txt_Titulo);
            this.groupBox1.Controls.Add(this.txt_Registro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 247);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Livro:";
            // 
            // dtDataRegistro
            // 
            this.dtDataRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataRegistro.Location = new System.Drawing.Point(370, 200);
            this.dtDataRegistro.Name = "dtDataRegistro";
            this.dtDataRegistro.Size = new System.Drawing.Size(111, 26);
            this.dtDataRegistro.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data de Registro:";
            // 
            // cb_Estante
            // 
            this.cb_Estante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Estante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Estante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Estante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Estante.FormattingEnabled = true;
            this.cb_Estante.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cb_Estante.Location = new System.Drawing.Point(243, 203);
            this.cb_Estante.Name = "cb_Estante";
            this.cb_Estante.Size = new System.Drawing.Size(111, 27);
            this.cb_Estante.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Registro:";
            // 
            // error_Provider
            // 
            this.error_Provider.ContainerControl = this;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Image = global::Controle_de_livros.Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salvar.Location = new System.Drawing.Point(14, 269);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(166, 41);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar - F1";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Controle_de_livros.Properties.Resources.Button_Delete_icon_32x32;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(519, 269);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(163, 41);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir - F4";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Controle_de_livros.Properties.Resources.Edit_Document_icon_32x32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(360, 269);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(151, 41);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar - F3";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::Controle_de_livros.Properties.Resources.Jommans_Briefness_Search__1_;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(188, 269);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(164, 41);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar - F2";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmLivroLiterario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 321);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLivroLiterario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar livro literário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLivroLiterario_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_Genero;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txt_Registro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private System.Windows.Forms.ComboBox cb_Estante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtDataRegistro;
        private System.Windows.Forms.Label label5;
    }
}