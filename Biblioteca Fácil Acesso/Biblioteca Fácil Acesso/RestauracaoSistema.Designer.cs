namespace Controle_de_livros
{
    partial class RestauracaoSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestauracaoSistema));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AbrirArquivo = new System.Windows.Forms.Button();
            this.txt_ReceberFile = new System.Windows.Forms.TextBox();
            this.btn_BackupRestaurar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AbrirArquivo);
            this.groupBox1.Controls.Add(this.txt_ReceberFile);
            this.groupBox1.Controls.Add(this.btn_BackupRestaurar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_AbrirArquivo
            // 
            this.btn_AbrirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AbrirArquivo.Image = global::Controle_de_livros.Properties.Resources.Hopstarter_Mac_Folders_Documents;
            this.btn_AbrirArquivo.Location = new System.Drawing.Point(447, 25);
            this.btn_AbrirArquivo.Name = "btn_AbrirArquivo";
            this.btn_AbrirArquivo.Size = new System.Drawing.Size(75, 36);
            this.btn_AbrirArquivo.TabIndex = 11;
            this.btn_AbrirArquivo.UseVisualStyleBackColor = true;
            this.btn_AbrirArquivo.Click += new System.EventHandler(this.btn_AbrirArquivo_Click);
            // 
            // txt_ReceberFile
            // 
            this.txt_ReceberFile.BackColor = System.Drawing.Color.White;
            this.txt_ReceberFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReceberFile.Location = new System.Drawing.Point(9, 31);
            this.txt_ReceberFile.Name = "txt_ReceberFile";
            this.txt_ReceberFile.ReadOnly = true;
            this.txt_ReceberFile.Size = new System.Drawing.Size(432, 26);
            this.txt_ReceberFile.TabIndex = 10;
            // 
            // btn_BackupRestaurar
            // 
            this.btn_BackupRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BackupRestaurar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackupRestaurar.Image = global::Controle_de_livros.Properties.Resources.Custom_Icon_Design_Pretty_Office_6_Backup_restore;
            this.btn_BackupRestaurar.Location = new System.Drawing.Point(9, 67);
            this.btn_BackupRestaurar.Name = "btn_BackupRestaurar";
            this.btn_BackupRestaurar.Size = new System.Drawing.Size(513, 55);
            this.btn_BackupRestaurar.TabIndex = 9;
            this.btn_BackupRestaurar.UseVisualStyleBackColor = true;
            this.btn_BackupRestaurar.Click += new System.EventHandler(this.btn_BackupRestaurar_Click);
            // 
            // RestauracaoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 160);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestauracaoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTAURAÇÃO DO SISTEMA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestauracaoSistema_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AbrirArquivo;
        private System.Windows.Forms.TextBox txt_ReceberFile;
        private System.Windows.Forms.Button btn_BackupRestaurar;
    }
}