namespace Controle_de_livros
{
    partial class FrmInstituicao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstituicao = new System.Windows.Forms.TextBox();
            this.txtNomeBiblioteca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRede = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instituição:";
            // 
            // txtInstituicao
            // 
            this.txtInstituicao.Location = new System.Drawing.Point(34, 49);
            this.txtInstituicao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInstituicao.Name = "txtInstituicao";
            this.txtInstituicao.Size = new System.Drawing.Size(531, 26);
            this.txtInstituicao.TabIndex = 1;
            // 
            // txtNomeBiblioteca
            // 
            this.txtNomeBiblioteca.Location = new System.Drawing.Point(35, 116);
            this.txtNomeBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeBiblioteca.Name = "txtNomeBiblioteca";
            this.txtNomeBiblioteca.Size = new System.Drawing.Size(531, 26);
            this.txtNomeBiblioteca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da biblioteca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rede:";
            // 
            // cbRede
            // 
            this.cbRede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRede.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRede.FormattingEnabled = true;
            this.cbRede.Items.AddRange(new object[] {
            "Estadual",
            "Municipal"});
            this.cbRede.Location = new System.Drawing.Point(35, 183);
            this.cbRede.Name = "cbRede";
            this.cbRede.Size = new System.Drawing.Size(203, 27);
            this.cbRede.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(454, 253);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 46);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FrmInstituicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 311);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbRede);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeBiblioteca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInstituicao);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInstituicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instituição";
            this.Load += new System.EventHandler(this.FrmInstituicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstituicao;
        private System.Windows.Forms.TextBox txtNomeBiblioteca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRede;
        private System.Windows.Forms.Button btnSalvar;
    }
}