
namespace TCC_3_M
{
    partial class frm_EditarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseFrmCadastroU = new System.Windows.Forms.Button();
            this.btnLimparFrmU = new System.Windows.Forms.Button();
            this.btnSalvarFrmU = new System.Windows.Forms.Button();
            this.txtEmailU = new System.Windows.Forms.TextBox();
            this.masktxtTelefoneU = new System.Windows.Forms.MaskedTextBox();
            this.masktxtCpfU = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCompletoU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseFrmCadastroU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 44);
            this.panel1.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Editar Registro de Usuário";
            // 
            // btnCloseFrmCadastroU
            // 
            this.btnCloseFrmCadastroU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFrmCadastroU.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseFrmCadastroU.FlatAppearance.BorderSize = 0;
            this.btnCloseFrmCadastroU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFrmCadastroU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFrmCadastroU.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseFrmCadastroU.Location = new System.Drawing.Point(0, 0);
            this.btnCloseFrmCadastroU.Name = "btnCloseFrmCadastroU";
            this.btnCloseFrmCadastroU.Size = new System.Drawing.Size(60, 44);
            this.btnCloseFrmCadastroU.TabIndex = 43;
            this.btnCloseFrmCadastroU.Text = "X";
            this.btnCloseFrmCadastroU.UseVisualStyleBackColor = true;
            this.btnCloseFrmCadastroU.Click += new System.EventHandler(this.btnCloseFrmCadastroU_Click);
            // 
            // btnLimparFrmU
            // 
            this.btnLimparFrmU.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimparFrmU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFrmU.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFrmU.Location = new System.Drawing.Point(403, 138);
            this.btnLimparFrmU.Name = "btnLimparFrmU";
            this.btnLimparFrmU.Size = new System.Drawing.Size(76, 31);
            this.btnLimparFrmU.TabIndex = 121;
            this.btnLimparFrmU.Text = "Limpar";
            this.btnLimparFrmU.UseVisualStyleBackColor = false;
            this.btnLimparFrmU.Click += new System.EventHandler(this.btnLimparFrmU_Click);
            // 
            // btnSalvarFrmU
            // 
            this.btnSalvarFrmU.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarFrmU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFrmU.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFrmU.Location = new System.Drawing.Point(505, 138);
            this.btnSalvarFrmU.Name = "btnSalvarFrmU";
            this.btnSalvarFrmU.Size = new System.Drawing.Size(76, 31);
            this.btnSalvarFrmU.TabIndex = 120;
            this.btnSalvarFrmU.Text = "Salvar";
            this.btnSalvarFrmU.UseVisualStyleBackColor = false;
            this.btnSalvarFrmU.Click += new System.EventHandler(this.btnSalvarFrmU_Click);
            // 
            // txtEmailU
            // 
            this.txtEmailU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailU.Location = new System.Drawing.Point(21, 141);
            this.txtEmailU.Name = "txtEmailU";
            this.txtEmailU.Size = new System.Drawing.Size(300, 26);
            this.txtEmailU.TabIndex = 117;
            // 
            // masktxtTelefoneU
            // 
            this.masktxtTelefoneU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masktxtTelefoneU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtTelefoneU.Location = new System.Drawing.Point(503, 88);
            this.masktxtTelefoneU.Mask = "(00) 00000-0000";
            this.masktxtTelefoneU.Name = "masktxtTelefoneU";
            this.masktxtTelefoneU.Size = new System.Drawing.Size(154, 26);
            this.masktxtTelefoneU.TabIndex = 116;
            // 
            // masktxtCpfU
            // 
            this.masktxtCpfU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masktxtCpfU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtCpfU.Location = new System.Drawing.Point(358, 88);
            this.masktxtCpfU.Mask = "000.000.000-00";
            this.masktxtCpfU.Name = "masktxtCpfU";
            this.masktxtCpfU.Size = new System.Drawing.Size(125, 26);
            this.masktxtCpfU.TabIndex = 115;
            // 
            // txtNomeCompletoU
            // 
            this.txtNomeCompletoU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCompletoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompletoU.Location = new System.Drawing.Point(22, 88);
            this.txtNomeCompletoU.Name = "txtNomeCompletoU";
            this.txtNomeCompletoU.Size = new System.Drawing.Size(300, 26);
            this.txtNomeCompletoU.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 113;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 112;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 111;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 110;
            this.label3.Text = "Nome Completo:";
            // 
            // frm_EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 192);
            this.Controls.Add(this.btnLimparFrmU);
            this.Controls.Add(this.btnSalvarFrmU);
            this.Controls.Add(this.txtEmailU);
            this.Controls.Add(this.masktxtTelefoneU);
            this.Controls.Add(this.masktxtCpfU);
            this.Controls.Add(this.txtNomeCompletoU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseFrmCadastroU;
        private System.Windows.Forms.Button btnLimparFrmU;
        private System.Windows.Forms.Button btnSalvarFrmU;
        private System.Windows.Forms.TextBox txtEmailU;
        private System.Windows.Forms.MaskedTextBox masktxtTelefoneU;
        private System.Windows.Forms.MaskedTextBox masktxtCpfU;
        private System.Windows.Forms.TextBox txtNomeCompletoU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}