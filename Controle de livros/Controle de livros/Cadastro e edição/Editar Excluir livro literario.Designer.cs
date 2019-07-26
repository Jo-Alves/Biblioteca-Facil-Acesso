namespace Controle_de_livros
{
    partial class Editar_Excluir_livro_literario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Excluir_livro_literario));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Busca = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Titulo = new System.Windows.Forms.RadioButton();
            this.rb_Registro = new System.Windows.Forms.RadioButton();
            this.lbl_Busca = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Estante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Genero = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_Registro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_Provider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_Busca);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.lbl_Busca);
            this.groupBox4.Controls.Add(this.txt_Buscar);
            this.groupBox4.Controls.Add(this.btn_Buscar);
            this.groupBox4.Location = new System.Drawing.Point(12, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 277);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView_Busca
            // 
            this.dataGridView_Busca.AllowUserToAddRows = false;
            this.dataGridView_Busca.AllowUserToDeleteRows = false;
            this.dataGridView_Busca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView_Busca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_Busca.Location = new System.Drawing.Point(6, 135);
            this.dataGridView_Busca.Name = "dataGridView_Busca";
            this.dataGridView_Busca.ReadOnly = true;
            this.dataGridView_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Busca.Size = new System.Drawing.Size(559, 142);
            this.dataGridView_Busca.TabIndex = 7;
            this.dataGridView_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Busca_CellClick);
            this.dataGridView_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Busca_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "N_Registro";
            this.Column1.HeaderText = "Nº Registro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 113;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Titulo";
            this.Column2.HeaderText = "Título";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Autor";
            this.Column3.HeaderText = "Autor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 72;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Genero";
            this.Column4.HeaderText = "Gênero";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 84;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Estante";
            this.Column5.HeaderText = "Estante";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 85;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Titulo);
            this.groupBox2.Controls.Add(this.rb_Registro);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(27, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por:";
            // 
            // rb_Titulo
            // 
            this.rb_Titulo.AutoSize = true;
            this.rb_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rb_Titulo.Location = new System.Drawing.Point(203, 22);
            this.rb_Titulo.Name = "rb_Titulo";
            this.rb_Titulo.Size = new System.Drawing.Size(66, 23);
            this.rb_Titulo.TabIndex = 1;
            this.rb_Titulo.TabStop = true;
            this.rb_Titulo.Text = "Título";
            this.rb_Titulo.UseVisualStyleBackColor = true;
            this.rb_Titulo.CheckedChanged += new System.EventHandler(this.rb_Titulo_CheckedChanged);
            // 
            // rb_Registro
            // 
            this.rb_Registro.AutoSize = true;
            this.rb_Registro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rb_Registro.Location = new System.Drawing.Point(37, 22);
            this.rb_Registro.Name = "rb_Registro";
            this.rb_Registro.Size = new System.Drawing.Size(106, 23);
            this.rb_Registro.TabIndex = 0;
            this.rb_Registro.TabStop = true;
            this.rb_Registro.Text = "Nº Registro";
            this.rb_Registro.UseVisualStyleBackColor = true;
            this.rb_Registro.CheckedChanged += new System.EventHandler(this.rb_Registro_CheckedChanged);
            // 
            // lbl_Busca
            // 
            this.lbl_Busca.AutoSize = true;
            this.lbl_Busca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Busca.Location = new System.Drawing.Point(30, 96);
            this.lbl_Busca.Name = "lbl_Busca";
            this.lbl_Busca.Size = new System.Drawing.Size(93, 19);
            this.lbl_Busca.TabIndex = 2;
            this.lbl_Busca.Text = "Nº Registro:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Buscar.Enabled = false;
            this.txt_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(129, 96);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(280, 26);
            this.txt_Buscar.TabIndex = 6;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Busca_TextChanged);
            this.txt_Buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Busca_KeyDown);
            this.txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Busca_KeyPress);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(415, 90);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(137, 36);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Excluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Button_Button_Delete;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.Location = new System.Drawing.Point(458, 208);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(125, 41);
            this.btn_Excluir.TabIndex = 5;
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
            this.btn_Editar.Location = new System.Drawing.Point(318, 208);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(132, 41);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 189);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Livro:";
            // 
            // cb_Estante
            // 
            this.cb_Estante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Estante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Estante.Enabled = false;
            this.cb_Estante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.cb_Estante.Location = new System.Drawing.Point(131, 157);
            this.cb_Estante.Name = "cb_Estante";
            this.cb_Estante.Size = new System.Drawing.Size(98, 27);
            this.cb_Estante.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estante:";
            // 
            // txt_Genero
            // 
            this.txt_Genero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Genero.Enabled = false;
            this.txt_Genero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Genero.Location = new System.Drawing.Point(131, 125);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.Size = new System.Drawing.Size(188, 26);
            this.txt_Genero.TabIndex = 3;
            this.txt_Genero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Genero_KeyPress);
            // 
            // txt_Autor
            // 
            this.txt_Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autor.Enabled = false;
            this.txt_Autor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Autor.Location = new System.Drawing.Point(129, 93);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(360, 26);
            this.txt_Autor.TabIndex = 2;
            this.txt_Autor.TextChanged += new System.EventHandler(this.txt_Autor_TextChanged);
            this.txt_Autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Autor_KeyPress);
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Titulo.Enabled = false;
            this.txt_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.Location = new System.Drawing.Point(129, 61);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(360, 26);
            this.txt_Titulo.TabIndex = 1;
            this.txt_Titulo.TextChanged += new System.EventHandler(this.txt_Titulo_TextChanged);
            // 
            // txt_Registro
            // 
            this.txt_Registro.BackColor = System.Drawing.Color.White;
            this.txt_Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Registro.Enabled = false;
            this.txt_Registro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Registro.Location = new System.Drawing.Point(129, 29);
            this.txt_Registro.Name = "txt_Registro";
            this.txt_Registro.ReadOnly = true;
            this.txt_Registro.Size = new System.Drawing.Size(100, 26);
            this.txt_Registro.TabIndex = 0;
            this.txt_Registro.TextChanged += new System.EventHandler(this.txt_Registro_TextChanged);
            this.txt_Registro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Registro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Registro:";
            // 
            // error_Provider1
            // 
            this.error_Provider1.ContainerControl = this;
            // 
            // Editar_Excluir_livro_literario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Editar_Excluir_livro_literario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR/EXCLUIR LIVRO LITERÁRIO";
            this.Load += new System.EventHandler(this.Editar_Excluir_livro_literario_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Busca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Titulo;
        private System.Windows.Forms.RadioButton rb_Registro;
        private System.Windows.Forms.Label lbl_Busca;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Genero;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txt_Registro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private System.Windows.Forms.ErrorProvider error_Provider1;
        private System.Windows.Forms.DataGridView dataGridView_Busca;
        private System.Windows.Forms.ComboBox cb_Estante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}