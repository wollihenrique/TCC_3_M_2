
namespace TCC_3_M
{
    partial class frm_RegistroPeriferico
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
            this.pnlCadastroP = new System.Windows.Forms.Panel();
            this.btnCloseFrmRegistroPerifericos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatusFrmCadastroP = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTipoFrmCadastroP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModeloCadastroP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarFrmCadastroP = new System.Windows.Forms.Button();
            this.btnSalvarFrmCadastroP = new System.Windows.Forms.Button();
            this.pnlCadastroP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroP
            // 
            this.pnlCadastroP.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCadastroP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroP.Controls.Add(this.btnCloseFrmRegistroPerifericos);
            this.pnlCadastroP.Controls.Add(this.label1);
            this.pnlCadastroP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadastroP.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroP.Name = "pnlCadastroP";
            this.pnlCadastroP.Size = new System.Drawing.Size(620, 42);
            this.pnlCadastroP.TabIndex = 29;
            // 
            // btnCloseFrmRegistroPerifericos
            // 
            this.btnCloseFrmRegistroPerifericos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCloseFrmRegistroPerifericos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFrmRegistroPerifericos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseFrmRegistroPerifericos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFrmRegistroPerifericos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFrmRegistroPerifericos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseFrmRegistroPerifericos.Location = new System.Drawing.Point(0, 0);
            this.btnCloseFrmRegistroPerifericos.Name = "btnCloseFrmRegistroPerifericos";
            this.btnCloseFrmRegistroPerifericos.Size = new System.Drawing.Size(52, 40);
            this.btnCloseFrmRegistroPerifericos.TabIndex = 50;
            this.btnCloseFrmRegistroPerifericos.Text = "X";
            this.btnCloseFrmRegistroPerifericos.UseVisualStyleBackColor = false;
            this.btnCloseFrmRegistroPerifericos.Click += new System.EventHandler(this.btnCloseFrmRegistroPerifericos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Periféricos";
            // 
            // cmbStatusFrmCadastroP
            // 
            this.cmbStatusFrmCadastroP.FormattingEnabled = true;
            this.cmbStatusFrmCadastroP.Location = new System.Drawing.Point(468, 82);
            this.cmbStatusFrmCadastroP.Name = "cmbStatusFrmCadastroP";
            this.cmbStatusFrmCadastroP.Size = new System.Drawing.Size(137, 21);
            this.cmbStatusFrmCadastroP.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(465, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Status:";
            // 
            // cmbTipoFrmCadastroP
            // 
            this.cmbTipoFrmCadastroP.FormattingEnabled = true;
            this.cmbTipoFrmCadastroP.Items.AddRange(new object[] {
            "Teclado",
            "Mouse",
            "Scanner",
            "Microfone",
            "Impressora",
            "Caixa de Som",
            "Fones de Ouvido",
            "WebCam"});
            this.cmbTipoFrmCadastroP.Location = new System.Drawing.Point(311, 82);
            this.cmbTipoFrmCadastroP.Name = "cmbTipoFrmCadastroP";
            this.cmbTipoFrmCadastroP.Size = new System.Drawing.Size(137, 21);
            this.cmbTipoFrmCadastroP.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tipo:";
            // 
            // txtModeloCadastroP
            // 
            this.txtModeloCadastroP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModeloCadastroP.Location = new System.Drawing.Point(12, 83);
            this.txtModeloCadastroP.Name = "txtModeloCadastroP";
            this.txtModeloCadastroP.Size = new System.Drawing.Size(268, 20);
            this.txtModeloCadastroP.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Modelo:";
            // 
            // btnCancelarFrmCadastroP
            // 
            this.btnCancelarFrmCadastroP.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarFrmCadastroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFrmCadastroP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFrmCadastroP.Location = new System.Drawing.Point(428, 130);
            this.btnCancelarFrmCadastroP.Name = "btnCancelarFrmCadastroP";
            this.btnCancelarFrmCadastroP.Size = new System.Drawing.Size(76, 31);
            this.btnCancelarFrmCadastroP.TabIndex = 58;
            this.btnCancelarFrmCadastroP.Text = "Cancelar";
            this.btnCancelarFrmCadastroP.UseVisualStyleBackColor = false;
            // 
            // btnSalvarFrmCadastroP
            // 
            this.btnSalvarFrmCadastroP.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarFrmCadastroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFrmCadastroP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFrmCadastroP.Location = new System.Drawing.Point(529, 130);
            this.btnSalvarFrmCadastroP.Name = "btnSalvarFrmCadastroP";
            this.btnSalvarFrmCadastroP.Size = new System.Drawing.Size(76, 31);
            this.btnSalvarFrmCadastroP.TabIndex = 57;
            this.btnSalvarFrmCadastroP.Text = "Salvar";
            this.btnSalvarFrmCadastroP.UseVisualStyleBackColor = false;
            // 
            // frm_RegistroPeriferico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 180);
            this.Controls.Add(this.btnCancelarFrmCadastroP);
            this.Controls.Add(this.btnSalvarFrmCadastroP);
            this.Controls.Add(this.txtModeloCadastroP);
            this.Controls.Add(this.cmbTipoFrmCadastroP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatusFrmCadastroP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pnlCadastroP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RegistroPeriferico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPerifericos";
            this.pnlCadastroP.ResumeLayout(false);
            this.pnlCadastroP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroP;
        private System.Windows.Forms.Button btnCloseFrmRegistroPerifericos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatusFrmCadastroP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbTipoFrmCadastroP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModeloCadastroP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarFrmCadastroP;
        private System.Windows.Forms.Button btnSalvarFrmCadastroP;
    }
}