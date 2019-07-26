namespace Controle_de_livros
{
    partial class Editar_Excluir_livro_didatico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Excluir_livro_didatico));
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_BuscaLivro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Disciplina = new System.Windows.Forms.RadioButton();
            this.rb_Registro = new System.Windows.Forms.RadioButton();
            this.lbl_RegistroDisciplina = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Disciplina = new System.Windows.Forms.ComboBox();
            this.cb_Volume = new System.Windows.Forms.ComboBox();
            this.cb_Ensino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Registro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BuscaLivro)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Excluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Button_Button_Delete;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.Location = new System.Drawing.Point(447, 214);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(125, 41);
            this.btn_Excluir.TabIndex = 6;
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
            this.btn_Editar.Location = new System.Drawing.Point(307, 214);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(132, 41);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, -194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código Usuário:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_BuscaLivro);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.lbl_RegistroDisciplina);
            this.groupBox4.Controls.Add(this.txt_Buscar);
            this.groupBox4.Controls.Add(this.btn_Buscar);
            this.groupBox4.Location = new System.Drawing.Point(12, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(560, 280);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView_BuscaLivro
            // 
            this.dataGridView_BuscaLivro.AllowUserToAddRows = false;
            this.dataGridView_BuscaLivro.AllowUserToDeleteRows = false;
            this.dataGridView_BuscaLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BuscaLivro.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_BuscaLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_BuscaLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BuscaLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_BuscaLivro.Location = new System.Drawing.Point(10, 138);
            this.dataGridView_BuscaLivro.Name = "dataGridView_BuscaLivro";
            this.dataGridView_BuscaLivro.ReadOnly = true;
            this.dataGridView_BuscaLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BuscaLivro.Size = new System.Drawing.Size(544, 135);
            this.dataGridView_BuscaLivro.TabIndex = 8;
            this.dataGridView_BuscaLivro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BuscaLivro_CellClick);
            this.dataGridView_BuscaLivro.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_BuscaLivro_DataBindingComplete);
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
            this.Column2.DataPropertyName = "Disciplina";
            this.Column2.HeaderText = "Disciplina";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.Column4.DataPropertyName = "Ensino";
            this.Column4.HeaderText = "Ensino";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Volume";
            this.Column5.HeaderText = "Volume";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 84;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Disciplina);
            this.groupBox2.Controls.Add(this.rb_Registro);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por:";
            // 
            // rb_Disciplina
            // 
            this.rb_Disciplina.AutoSize = true;
            this.rb_Disciplina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rb_Disciplina.Location = new System.Drawing.Point(279, 25);
            this.rb_Disciplina.Name = "rb_Disciplina";
            this.rb_Disciplina.Size = new System.Drawing.Size(93, 23);
            this.rb_Disciplina.TabIndex = 1;
            this.rb_Disciplina.TabStop = true;
            this.rb_Disciplina.Text = "Disciplina";
            this.rb_Disciplina.UseVisualStyleBackColor = true;
            this.rb_Disciplina.CheckedChanged += new System.EventHandler(this.rb_Disciplina_CheckedChanged);
            // 
            // rb_Registro
            // 
            this.rb_Registro.AutoSize = true;
            this.rb_Registro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rb_Registro.Location = new System.Drawing.Point(129, 25);
            this.rb_Registro.Name = "rb_Registro";
            this.rb_Registro.Size = new System.Drawing.Size(106, 23);
            this.rb_Registro.TabIndex = 0;
            this.rb_Registro.TabStop = true;
            this.rb_Registro.Text = "Nº Registro";
            this.rb_Registro.UseVisualStyleBackColor = true;
            this.rb_Registro.CheckedChanged += new System.EventHandler(this.rb_Registro_CheckedChanged);
            // 
            // lbl_RegistroDisciplina
            // 
            this.lbl_RegistroDisciplina.AutoSize = true;
            this.lbl_RegistroDisciplina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistroDisciplina.Location = new System.Drawing.Point(6, 97);
            this.lbl_RegistroDisciplina.Name = "lbl_RegistroDisciplina";
            this.lbl_RegistroDisciplina.Size = new System.Drawing.Size(93, 19);
            this.lbl_RegistroDisciplina.TabIndex = 2;
            this.lbl_RegistroDisciplina.Text = "Nº Registro:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Buscar.Enabled = false;
            this.txt_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Buscar.Location = new System.Drawing.Point(101, 94);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(307, 26);
            this.txt_Buscar.TabIndex = 7;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            this.txt_Buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Busca_KeyDown);
            this.txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscar_KeyPress);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(414, 88);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(136, 36);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Disciplina);
            this.groupBox1.Controls.Add(this.cb_Volume);
            this.groupBox1.Controls.Add(this.cb_Ensino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Autor);
            this.groupBox1.Controls.Add(this.txt_Registro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 195);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Livro:";
            // 
            // cb_Disciplina
            // 
            this.cb_Disciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Disciplina.Enabled = false;
            this.cb_Disciplina.FormattingEnabled = true;
            this.cb_Disciplina.Items.AddRange(new object[] {
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
            this.cb_Disciplina.Location = new System.Drawing.Point(155, 50);
            this.cb_Disciplina.MaxLength = 300;
            this.cb_Disciplina.Name = "cb_Disciplina";
            this.cb_Disciplina.Size = new System.Drawing.Size(212, 27);
            this.cb_Disciplina.TabIndex = 1;
            // 
            // cb_Volume
            // 
            this.cb_Volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Volume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Volume.Enabled = false;
            this.cb_Volume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Volume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Volume.FormattingEnabled = true;
            this.cb_Volume.Items.AddRange(new object[] {
            "",
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
            this.cb_Volume.Location = new System.Drawing.Point(155, 148);
            this.cb_Volume.Name = "cb_Volume";
            this.cb_Volume.Size = new System.Drawing.Size(165, 27);
            this.cb_Volume.TabIndex = 4;
            this.cb_Volume.SelectedIndexChanged += new System.EventHandler(this.cb_Volume_SelectedIndexChanged);
            // 
            // cb_Ensino
            // 
            this.cb_Ensino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Ensino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ensino.Enabled = false;
            this.cb_Ensino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Ensino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ensino.FormattingEnabled = true;
            this.cb_Ensino.Items.AddRange(new object[] {
            "",
            "ENSINO FUNDAMENTAL",
            "ENSINO MÉDIO"});
            this.cb_Ensino.Location = new System.Drawing.Point(155, 115);
            this.cb_Ensino.Name = "cb_Ensino";
            this.cb_Ensino.Size = new System.Drawing.Size(237, 27);
            this.cb_Ensino.TabIndex = 3;
            this.cb_Ensino.SelectedIndexChanged += new System.EventHandler(this.cb_Ensino_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Volume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ensino:";
            // 
            // txt_Autor
            // 
            this.txt_Autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autor.Enabled = false;
            this.txt_Autor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Autor.Location = new System.Drawing.Point(155, 83);
            this.txt_Autor.MaxLength = 100;
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(360, 26);
            this.txt_Autor.TabIndex = 2;
            this.txt_Autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Autor_KeyPress);
            // 
            // txt_Registro
            // 
            this.txt_Registro.BackColor = System.Drawing.Color.White;
            this.txt_Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Registro.Enabled = false;
            this.txt_Registro.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Registro.Location = new System.Drawing.Point(155, 19);
            this.txt_Registro.Name = "txt_Registro";
            this.txt_Registro.ReadOnly = true;
            this.txt_Registro.Size = new System.Drawing.Size(100, 26);
            this.txt_Registro.TabIndex = 0;
            this.txt_Registro.TextChanged += new System.EventHandler(this.txt_Registro_TextChanged);
            this.txt_Registro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Registro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disciplina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Registro:";
            // 
            // error_Provider
            // 
            this.error_Provider.ContainerControl = this;
            // 
            // Editar_Excluir_livro_didatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Editar_Excluir_livro_didatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR/ECLUIR LIVRO DIDÁTICO";
            this.Load += new System.EventHandler(this.Editar_Excluir_livro_didatico_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BuscaLivro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Disciplina;
        private System.Windows.Forms.RadioButton rb_Registro;
        private System.Windows.Forms.Label lbl_RegistroDisciplina;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txt_Registro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_BuscaLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Ensino;
        private System.Windows.Forms.ComboBox cb_Volume;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private System.Windows.Forms.ComboBox cb_Disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}