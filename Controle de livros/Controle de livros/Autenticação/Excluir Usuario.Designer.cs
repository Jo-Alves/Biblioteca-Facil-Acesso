namespace Controle_de_livros
{
    partial class Excluir_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir_Usuario));
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SenhaAtual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Verificar = new System.Windows.Forms.Label();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_Controle_LivrosDataSet1 = new Controle_de_livros.Sistema_Controle_LivrosDataSet1();
            this.loginTableAdapter = new Controle_de_livros.Sistema_Controle_LivrosDataSet1TableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Controle_LivrosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Button_Button_Delete;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.Location = new System.Drawing.Point(83, 145);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(102, 48);
            this.btn_Excluir.TabIndex = 7;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout1;
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.Location = new System.Drawing.Point(197, 145);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(77, 48);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Senha:";
            // 
            // txt_SenhaAtual
            // 
            this.txt_SenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaAtual.Location = new System.Drawing.Point(126, 40);
            this.txt_SenhaAtual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SenhaAtual.MaxLength = 10;
            this.txt_SenhaAtual.Name = "txt_SenhaAtual";
            this.txt_SenhaAtual.Size = new System.Drawing.Size(148, 26);
            this.txt_SenhaAtual.TabIndex = 35;
            this.txt_SenhaAtual.UseSystemPasswordChar = true;
            this.txt_SenhaAtual.TextChanged += new System.EventHandler(this.txt_SenhaAtual_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Bibliotecário(a):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Confimar senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(125, 106);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Senha.MaxLength = 10;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(148, 26);
            this.txt_Senha.TabIndex = 42;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // error_Provider
            // 
            this.error_Provider.ContainerControl = this;
            // 
            // lbl_Verificar
            // 
            this.lbl_Verificar.AutoSize = true;
            this.lbl_Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Verificar.Location = new System.Drawing.Point(132, 78);
            this.lbl_Verificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Verificar.Name = "lbl_Verificar";
            this.lbl_Verificar.Size = new System.Drawing.Size(0, 17);
            this.lbl_Verificar.TabIndex = 44;
            this.lbl_Verificar.Visible = false;
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.DataSource = this.loginBindingSource;
            this.cb_Usuario.DisplayMember = "Usuario";
            this.cb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(125, 5);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(195, 28);
            this.cb_Usuario.TabIndex = 45;
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
            // Excluir_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 200);
            this.Controls.Add(this.cb_Usuario);
            this.Controls.Add(this.lbl_Verificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SenhaAtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Excluir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Excluir_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXCLUIR USUÁRIO";
            this.Load += new System.EventHandler(this.Excluir_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Controle_LivrosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SenhaAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private System.Windows.Forms.Label lbl_Verificar;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private Sistema_Controle_LivrosDataSet1 sistema_Controle_LivrosDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Sistema_Controle_LivrosDataSet1TableAdapters.LoginTableAdapter loginTableAdapter;
    }
}