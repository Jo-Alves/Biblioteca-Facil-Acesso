namespace Controle_de_livros
{
    partial class FORMULARIO_AUTENTICACAO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMULARIO_AUTENTICACAO));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_OcultarMostrar = new System.Windows.Forms.Button();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAutenticacao = new Controle_de_livros.Autenticação.DataSetAutenticacao();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginTableAdapter = new Controle_de_livros.Autenticação.DataSetAutenticacaoTableAdapters.LoginTableAdapter();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutenticacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bibliotecário(a):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(58, 83);
            this.txt_Senha.MaxLength = 10;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(196, 26);
            this.txt_Senha.TabIndex = 3;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = global::Controle_de_livros.Properties.Resources.cancelar1;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(208, 127);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 52);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Tag = "";
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Entrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Image = global::Controle_de_livros.Properties.Resources.logar;
            this.btn_Entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Entrar.Location = new System.Drawing.Point(108, 127);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(94, 52);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_OcultarMostrar
            // 
            this.btn_OcultarMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OcultarMostrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OcultarMostrar.Image = global::Controle_de_livros.Properties.Resources.ver_32x32;
            this.btn_OcultarMostrar.Location = new System.Drawing.Point(260, 77);
            this.btn_OcultarMostrar.Name = "btn_OcultarMostrar";
            this.btn_OcultarMostrar.Size = new System.Drawing.Size(85, 37);
            this.btn_OcultarMostrar.TabIndex = 41;
            this.btn_OcultarMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.btn_OcultarMostrar, "Mostrar");
            this.btn_OcultarMostrar.UseVisualStyleBackColor = true;
            this.btn_OcultarMostrar.Click += new System.EventHandler(this.btn_OcultarMostrar_Click);
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Usuario.DataSource = this.loginBindingSource;
            this.cb_Usuario.DisplayMember = "Usuario";
            this.cb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(58, 31);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(287, 27);
            this.cb_Usuario.TabIndex = 42;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.dataSetAutenticacao;
            // 
            // dataSetAutenticacao
            // 
            this.dataSetAutenticacao.DataSetName = "DataSetAutenticacao";
            this.dataSetAutenticacao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Algum Problema no sistema? Perdeu todos os dados? ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(116, 207);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 13);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique aqui para restaurar o sistema.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // FORMULARIO_AUTENTICACAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 227);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Usuario);
            this.Controls.Add(this.btn_OcultarMostrar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORMULARIO_AUTENTICACAO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE AUTENTICAÇÃO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORMULARIO_AUTENTICACAO_FormClosed);
            this.Load += new System.EventHandler(this.FORMULARIO_AUTENTICACAO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutenticacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_OcultarMostrar;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Autenticação.DataSetAutenticacao dataSetAutenticacao;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Autenticação.DataSetAutenticacaoTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.ToolTip toolTip;
    }
}