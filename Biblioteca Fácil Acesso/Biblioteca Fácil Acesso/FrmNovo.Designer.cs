namespace Controle_de_livros
{
    partial class FrmNovo
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
            this.btn_Cadastrar_Livro = new System.Windows.Forms.Button();
            this.btn_Cadastrar_Usuario = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_CadastrarLivroDidatico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cadastrar_Livro
            // 
            this.btn_Cadastrar_Livro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cadastrar_Livro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cadastrar_Livro.Image = global::Controle_de_livros.Properties.Resources.Book_icon;
            this.btn_Cadastrar_Livro.Location = new System.Drawing.Point(278, 153);
            this.btn_Cadastrar_Livro.Name = "btn_Cadastrar_Livro";
            this.btn_Cadastrar_Livro.Size = new System.Drawing.Size(109, 96);
            this.btn_Cadastrar_Livro.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Cadastrar_Livro, "Cadastrar Livro");
            this.btn_Cadastrar_Livro.UseVisualStyleBackColor = true;
            this.btn_Cadastrar_Livro.Click += new System.EventHandler(this.Btn_Cadastrar_Livro_Click);
            // 
            // btn_Cadastrar_Usuario
            // 
            this.btn_Cadastrar_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cadastrar_Usuario.BackgroundImage = global::Controle_de_livros.Properties.Resources.User_Group_icon1;
            this.btn_Cadastrar_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cadastrar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cadastrar_Usuario.Image = global::Controle_de_livros.Properties.Resources.User_Group_icon;
            this.btn_Cadastrar_Usuario.Location = new System.Drawing.Point(128, 153);
            this.btn_Cadastrar_Usuario.Name = "btn_Cadastrar_Usuario";
            this.btn_Cadastrar_Usuario.Size = new System.Drawing.Size(109, 96);
            this.btn_Cadastrar_Usuario.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Cadastrar_Usuario, "Cadastrar Aluno/Funcionario/Outros");
            this.btn_Cadastrar_Usuario.UseVisualStyleBackColor = true;
            this.btn_Cadastrar_Usuario.Click += new System.EventHandler(this.Btn_Cadastrar_Usuario_Click);
            // 
            // btn_CadastrarLivroDidatico
            // 
            this.btn_CadastrarLivroDidatico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CadastrarLivroDidatico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CadastrarLivroDidatico.Image = global::Controle_de_livros.Properties.Resources.logout_icon2;
            this.btn_CadastrarLivroDidatico.Location = new System.Drawing.Point(427, 153);
            this.btn_CadastrarLivroDidatico.Name = "btn_CadastrarLivroDidatico";
            this.btn_CadastrarLivroDidatico.Size = new System.Drawing.Size(109, 96);
            this.btn_CadastrarLivroDidatico.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_CadastrarLivroDidatico, "Sair");
            this.btn_CadastrarLivroDidatico.UseVisualStyleBackColor = true;
            this.btn_CadastrarLivroDidatico.Click += new System.EventHandler(this.Btn_CadastrarLivroDidatico_Click);
            // 
            // FrmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btn_CadastrarLivroDidatico);
            this.Controls.Add(this.btn_Cadastrar_Livro);
            this.Controls.Add(this.btn_Cadastrar_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Cadastrar_Livro;
        private System.Windows.Forms.Button btn_Cadastrar_Usuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_CadastrarLivroDidatico;
    }
}