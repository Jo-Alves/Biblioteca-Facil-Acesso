namespace Controle_de_livros
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDiretorio = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbQuantidadeLimite = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ndTempoLimite = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbRedefinir = new System.Windows.Forms.CheckBox();
            this.cbBloquear = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndTempoLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDiretorio);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(434, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local do disco para backup padrão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local do disco ";
            // 
            // cbDiretorio
            // 
            this.cbDiretorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbDiretorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiretorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDiretorio.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbDiretorio.FormattingEnabled = true;
            this.cbDiretorio.Items.AddRange(new object[] {
            "C:\\",
            "D:\\",
            "E:\\"});
            this.cbDiretorio.Location = new System.Drawing.Point(20, 47);
            this.cbDiretorio.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiretorio.Name = "cbDiretorio";
            this.cbDiretorio.Size = new System.Drawing.Size(181, 27);
            this.cbDiretorio.TabIndex = 2;
            this.cbDiretorio.SelectedIndexChanged += new System.EventHandler(this.CbDiretorio_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbQuantidadeLimite);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(19, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe a quantidade de livros que podem ser emprestados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade Limite";
            // 
            // cbQuantidadeLimite
            // 
            this.cbQuantidadeLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbQuantidadeLimite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidadeLimite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbQuantidadeLimite.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbQuantidadeLimite.FormattingEnabled = true;
            this.cbQuantidadeLimite.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "20",
            "25",
            "30",
            "35",
            "45"});
            this.cbQuantidadeLimite.Location = new System.Drawing.Point(19, 55);
            this.cbQuantidadeLimite.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuantidadeLimite.Name = "cbQuantidadeLimite";
            this.cbQuantidadeLimite.Size = new System.Drawing.Size(181, 27);
            this.cbQuantidadeLimite.TabIndex = 4;
            this.cbQuantidadeLimite.SelectedIndexChanged += new System.EventHandler(this.CbQuantidadeLimite_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ndTempoLimite);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 106);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informe o tempo limite do empréstimo:";
            // 
            // ndTempoLimite
            // 
            this.ndTempoLimite.Location = new System.Drawing.Point(19, 65);
            this.ndTempoLimite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndTempoLimite.Name = "ndTempoLimite";
            this.ndTempoLimite.Size = new System.Drawing.Size(120, 26);
            this.ndTempoLimite.TabIndex = 6;
            this.ndTempoLimite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndTempoLimite.ValueChanged += new System.EventHandler(this.NdTempoLimite_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tempo Limite (dias)";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAplicar.Location = new System.Drawing.Point(292, 402);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(121, 42);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(165, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(38, 402);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 42);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // cbRedefinir
            // 
            this.cbRedefinir.AutoSize = true;
            this.cbRedefinir.Location = new System.Drawing.Point(7, 373);
            this.cbRedefinir.Name = "cbRedefinir";
            this.cbRedefinir.Size = new System.Drawing.Size(210, 23);
            this.cbRedefinir.TabIndex = 10;
            this.cbRedefinir.Text = "Redefinir configuração padrão";
            this.cbRedefinir.UseVisualStyleBackColor = true;
            this.cbRedefinir.CheckedChanged += new System.EventHandler(this.cbRedefinir_CheckedChanged);
            // 
            // cbBloquear
            // 
            this.cbBloquear.AutoSize = true;
            this.cbBloquear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbBloquear.Location = new System.Drawing.Point(9, 334);
            this.cbBloquear.Name = "cbBloquear";
            this.cbBloquear.Size = new System.Drawing.Size(420, 23);
            this.cbBloquear.TabIndex = 11;
            this.cbBloquear.Text = "Bloquear Aluno/Funcionario/Outro com livro(s) pendente(s)";
            this.cbBloquear.UseVisualStyleBackColor = true;
            this.cbBloquear.CheckedChanged += new System.EventHandler(this.cbBloquear_CheckedChanged);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 456);
            this.Controls.Add(this.cbBloquear);
            this.Controls.Add(this.cbRedefinir);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndTempoLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDiretorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbQuantidadeLimite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown ndTempoLimite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbRedefinir;
        private System.Windows.Forms.CheckBox cbBloquear;
    }
}