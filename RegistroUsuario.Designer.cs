﻿
namespace TCC_3_M
{
    partial class frm_RegistroUsuario
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
            this.btnCloseFrmCadastroU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCompletoCadU = new System.Windows.Forms.TextBox();
            this.txtEmailCadU = new System.Windows.Forms.TextBox();
            this.txtSenhaCadU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimparFrmCadastroU = new System.Windows.Forms.Button();
            this.btnSalvarFrmCadastroU = new System.Windows.Forms.Button();
            this.txtConfirmSenhaCadU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.masktxtTelefoneCadU = new System.Windows.Forms.MaskedTextBox();
            this.masktxtCpfCadU = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCloseFrmCadastroU);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseFrmCadastroU
            // 
            this.btnCloseFrmCadastroU.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseFrmCadastroU.FlatAppearance.BorderSize = 0;
            this.btnCloseFrmCadastroU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFrmCadastroU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFrmCadastroU.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseFrmCadastroU.Location = new System.Drawing.Point(0, 0);
            this.btnCloseFrmCadastroU.Name = "btnCloseFrmCadastroU";
            this.btnCloseFrmCadastroU.Size = new System.Drawing.Size(47, 44);
            this.btnCloseFrmCadastroU.TabIndex = 43;
            this.btnCloseFrmCadastroU.Text = "X";
            this.btnCloseFrmCadastroU.UseVisualStyleBackColor = true;
            this.btnCloseFrmCadastroU.Click += new System.EventHandler(this.btnCloseFrmCadsatroU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Completo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            // 
            // txtNomeCompletoCadU
            // 
            this.txtNomeCompletoCadU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCompletoCadU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompletoCadU.Location = new System.Drawing.Point(20, 74);
            this.txtNomeCompletoCadU.Name = "txtNomeCompletoCadU";
            this.txtNomeCompletoCadU.Size = new System.Drawing.Size(428, 27);
            this.txtNomeCompletoCadU.TabIndex = 1;
            // 
            // txtEmailCadU
            // 
            this.txtEmailCadU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailCadU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCadU.Location = new System.Drawing.Point(23, 176);
            this.txtEmailCadU.Name = "txtEmailCadU";
            this.txtEmailCadU.Size = new System.Drawing.Size(425, 27);
            this.txtEmailCadU.TabIndex = 4;
            // 
            // txtSenhaCadU
            // 
            this.txtSenhaCadU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaCadU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadU.Location = new System.Drawing.Point(22, 238);
            this.txtSenhaCadU.Name = "txtSenhaCadU";
            this.txtSenhaCadU.Size = new System.Drawing.Size(426, 27);
            this.txtSenhaCadU.TabIndex = 5;
            this.txtSenhaCadU.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Senha:";
            // 
            // btnLimparFrmCadastroU
            // 
            this.btnLimparFrmCadastroU.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimparFrmCadastroU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFrmCadastroU.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFrmCadastroU.Location = new System.Drawing.Point(259, 345);
            this.btnLimparFrmCadastroU.Name = "btnLimparFrmCadastroU";
            this.btnLimparFrmCadastroU.Size = new System.Drawing.Size(88, 38);
            this.btnLimparFrmCadastroU.TabIndex = 7;
            this.btnLimparFrmCadastroU.Text = "Limpar";
            this.btnLimparFrmCadastroU.UseVisualStyleBackColor = false;
            this.btnLimparFrmCadastroU.Click += new System.EventHandler(this.btnLimparFrmCadastroU_Click);
            // 
            // btnSalvarFrmCadastroU
            // 
            this.btnSalvarFrmCadastroU.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarFrmCadastroU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFrmCadastroU.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFrmCadastroU.Location = new System.Drawing.Point(366, 345);
            this.btnSalvarFrmCadastroU.Name = "btnSalvarFrmCadastroU";
            this.btnSalvarFrmCadastroU.Size = new System.Drawing.Size(82, 38);
            this.btnSalvarFrmCadastroU.TabIndex = 8;
            this.btnSalvarFrmCadastroU.Text = "Salvar";
            this.btnSalvarFrmCadastroU.UseVisualStyleBackColor = false;
            this.btnSalvarFrmCadastroU.Click += new System.EventHandler(this.btnSalvarFrmCadastroU_Click);
            // 
            // txtConfirmSenhaCadU
            // 
            this.txtConfirmSenhaCadU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmSenhaCadU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmSenhaCadU.Location = new System.Drawing.Point(22, 297);
            this.txtConfirmSenhaCadU.Name = "txtConfirmSenhaCadU";
            this.txtConfirmSenhaCadU.Size = new System.Drawing.Size(426, 27);
            this.txtConfirmSenhaCadU.TabIndex = 6;
            this.txtConfirmSenhaCadU.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "Confirmação de Senha:";
            // 
            // masktxtTelefoneCadU
            // 
            this.masktxtTelefoneCadU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masktxtTelefoneCadU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtTelefoneCadU.Location = new System.Drawing.Point(294, 123);
            this.masktxtTelefoneCadU.Mask = "(00) 00000-0000";
            this.masktxtTelefoneCadU.Name = "masktxtTelefoneCadU";
            this.masktxtTelefoneCadU.Size = new System.Drawing.Size(154, 27);
            this.masktxtTelefoneCadU.TabIndex = 3;
            // 
            // masktxtCpfCadU
            // 
            this.masktxtCpfCadU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masktxtCpfCadU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtCpfCadU.Location = new System.Drawing.Point(24, 122);
            this.masktxtCpfCadU.Mask = "000.000.000-00";
            this.masktxtCpfCadU.Name = "masktxtCpfCadU";
            this.masktxtCpfCadU.Size = new System.Drawing.Size(125, 27);
            this.masktxtCpfCadU.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "CPF:";
            // 
            // frm_RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 406);
            this.Controls.Add(this.masktxtTelefoneCadU);
            this.Controls.Add(this.masktxtCpfCadU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmSenhaCadU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimparFrmCadastroU);
            this.Controls.Add(this.btnSalvarFrmCadastroU);
            this.Controls.Add(this.txtSenhaCadU);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmailCadU);
            this.Controls.Add(this.txtNomeCompletoCadU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseFrmCadastroU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCompletoCadU;
        private System.Windows.Forms.TextBox txtEmailCadU;
        private System.Windows.Forms.TextBox txtSenhaCadU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparFrmCadastroU;
        private System.Windows.Forms.Button btnSalvarFrmCadastroU;
        private System.Windows.Forms.TextBox txtConfirmSenhaCadU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox masktxtTelefoneCadU;
        private System.Windows.Forms.MaskedTextBox masktxtCpfCadU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}