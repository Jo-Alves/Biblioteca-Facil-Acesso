namespace Controle_de_livros
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.rb_EscolherLocal = new System.Windows.Forms.RadioButton();
            this.rb_LocalPadrao = new System.Windows.Forms.RadioButton();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rb_EscolherLocal
            // 
            this.rb_EscolherLocal.AutoSize = true;
            this.rb_EscolherLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EscolherLocal.Location = new System.Drawing.Point(246, 24);
            this.rb_EscolherLocal.Name = "rb_EscolherLocal";
            this.rb_EscolherLocal.Size = new System.Drawing.Size(192, 23);
            this.rb_EscolherLocal.TabIndex = 45;
            this.rb_EscolherLocal.TabStop = true;
            this.rb_EscolherLocal.Text = "Escolher local de backup";
            this.rb_EscolherLocal.UseVisualStyleBackColor = true;
            // 
            // rb_LocalPadrao
            // 
            this.rb_LocalPadrao.AutoSize = true;
            this.rb_LocalPadrao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_LocalPadrao.Location = new System.Drawing.Point(12, 24);
            this.rb_LocalPadrao.Name = "rb_LocalPadrao";
            this.rb_LocalPadrao.Size = new System.Drawing.Size(232, 23);
            this.rb_LocalPadrao.TabIndex = 44;
            this.rb_LocalPadrao.TabStop = true;
            this.rb_LocalPadrao.Text = "Gerar Backup em local Padrão";
            this.rb_LocalPadrao.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Image = global::Controle_de_livros.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_Cancelar.Location = new System.Drawing.Point(45, 73);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(179, 45);
            this.btn_Cancelar.TabIndex = 47;
            this.toolTip1.SetToolTip(this.btn_Cancelar, "Cancelar");
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Backup.Image = global::Controle_de_livros.Properties.Resources.Icons8_Windows_8_Database_Backup1;
            this.btn_Backup.Location = new System.Drawing.Point(230, 73);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(179, 45);
            this.btn_Backup.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_Backup, "Gerar Backup");
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 140);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.rb_EscolherLocal);
            this.Controls.Add(this.rb_LocalPadrao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BACKUP PARA RESTAURAÇÃO DOS SISTEMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.RadioButton rb_EscolherLocal;
        private System.Windows.Forms.RadioButton rb_LocalPadrao;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}