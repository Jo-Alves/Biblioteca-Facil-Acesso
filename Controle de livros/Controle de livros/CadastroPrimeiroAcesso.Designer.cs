namespace Controle_de_livros
{
    partial class CadastroPrimeiroAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPrimeiroAcesso));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bibliotecário(a):";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(130, 50);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Senha.MaxLength = 10;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(195, 26);
            this.txt_Senha.TabIndex = 15;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(130, 14);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Usuario.MaxLength = 50;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(195, 26);
            this.txt_Usuario.TabIndex = 14;
            this.txt_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Usuario_KeyDown);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout1;
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.Location = new System.Drawing.Point(213, 86);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(77, 42);
            this.Btn_Sair.TabIndex = 13;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Soft_Scraps_Text_Edit;
            this.Btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(93, 86);
            this.Btn_Cadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(112, 42);
            this.Btn_Cadastrar.TabIndex = 12;
            this.Btn_Cadastrar.Text = "&Cadastrar";
            this.Btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // error_Provider
            // 
            this.error_Provider.ContainerControl = this;
            // 
            // CadastroPrimeiroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroPrimeiroAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário e Senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPrimeiroAcesso_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.ErrorProvider error_Provider;
    }
}