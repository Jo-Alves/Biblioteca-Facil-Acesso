namespace Controle_de_livros
{
    partial class Alterar_Senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar_Senha));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SenhaRedefinir = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Verificar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SenhaAtual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_Controle_LivrosDataSet1 = new Controle_de_livros.Sistema_Controle_LivrosDataSet1();
            this.loginTableAdapter = new Controle_de_livros.Sistema_Controle_LivrosDataSet1TableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Controle_LivrosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Redefinir Senha:";
            // 
            // txt_SenhaRedefinir
            // 
            this.txt_SenhaRedefinir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SenhaRedefinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaRedefinir.Location = new System.Drawing.Point(39, 161);
            this.txt_SenhaRedefinir.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SenhaRedefinir.MaxLength = 10;
            this.txt_SenhaRedefinir.Name = "txt_SenhaRedefinir";
            this.txt_SenhaRedefinir.Size = new System.Drawing.Size(255, 26);
            this.txt_SenhaRedefinir.TabIndex = 2;
            this.txt_SenhaRedefinir.UseSystemPasswordChar = true;
            this.txt_SenhaRedefinir.TextChanged += new System.EventHandler(this.txt_SenhaRedefinir_TextChanged);
            this.txt_SenhaRedefinir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SenhaRedefinir_KeyDown);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lbl_Verificar
            // 
            this.lbl_Verificar.AutoSize = true;
            this.lbl_Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Verificar.Location = new System.Drawing.Point(52, 77);
            this.lbl_Verificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Verificar.Name = "lbl_Verificar";
            this.lbl_Verificar.Size = new System.Drawing.Size(0, 20);
            this.lbl_Verificar.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Senha Atual:";
            // 
            // txt_SenhaAtual
            // 
            this.txt_SenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaAtual.Location = new System.Drawing.Point(39, 107);
            this.txt_SenhaAtual.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SenhaAtual.MaxLength = 10;
            this.txt_SenhaAtual.Name = "txt_SenhaAtual";
            this.txt_SenhaAtual.Size = new System.Drawing.Size(255, 26);
            this.txt_SenhaAtual.TabIndex = 1;
            this.txt_SenhaAtual.UseSystemPasswordChar = true;
            this.txt_SenhaAtual.TextChanged += new System.EventHandler(this.txt_SenhaAtual_TextChanged_2);
            this.txt_SenhaAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SenhaAtual_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bibliotecário(a):";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout1;
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.Location = new System.Drawing.Point(184, 195);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(110, 39);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click_1);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Soft_Scraps_Text_Edit;
            this.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Alterar.Location = new System.Drawing.Point(56, 195);
            this.Btn_Alterar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(120, 39);
            this.Btn_Alterar.TabIndex = 3;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click_1);
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.BackColor = System.Drawing.Color.Silver;
            this.cb_Usuario.DataSource = this.loginBindingSource;
            this.cb_Usuario.DisplayMember = "Usuario";
            this.cb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(39, 47);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(255, 27);
            this.cb_Usuario.TabIndex = 36;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.sistema_Controle_LivrosDataSet1;
            // 
            // sistema_Controle_LivrosDataSet1
            // 
            this.sistema_Controle_LivrosDataSet1.DataSetName = "Sistema_Controle_LivrosDataSet1";
            this.sistema_Controle_LivrosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // Alterar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 240);
            this.Controls.Add(this.cb_Usuario);
            this.Controls.Add(this.lbl_Verificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SenhaAtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SenhaRedefinir);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alterar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTERAR SENHA";
            this.Load += new System.EventHandler(this.Alterar_Senha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Controle_LivrosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SenhaRedefinir;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Label lbl_Verificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SenhaAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private Sistema_Controle_LivrosDataSet1 sistema_Controle_LivrosDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Sistema_Controle_LivrosDataSet1TableAdapters.LoginTableAdapter loginTableAdapter;
    }
}