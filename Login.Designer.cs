namespace TCC_3_M
{
    partial class frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Entrar_Log = new System.Windows.Forms.Button();
            this.pnl_Cadastro_Cad = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome_CadstroAdmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha_CadastroAdmin = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Entrar_Log
            // 
            this.btn_Entrar_Log.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Entrar_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar_Log.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar_Log.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar_Log.Location = new System.Drawing.Point(608, 433);
            this.btn_Entrar_Log.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Entrar_Log.Name = "btn_Entrar_Log";
            this.btn_Entrar_Log.Size = new System.Drawing.Size(71, 33);
            this.btn_Entrar_Log.TabIndex = 4;
            this.btn_Entrar_Log.Text = "Entrar";
            this.btn_Entrar_Log.UseVisualStyleBackColor = false;
            this.btn_Entrar_Log.Click += new System.EventHandler(this.btn_Entrar_Log_Click);
            // 
            // pnl_Cadastro_Cad
            // 
            this.pnl_Cadastro_Cad.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Cadastro_Cad.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Cadastro_Cad.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cadastro_Cad.Name = "pnl_Cadastro_Cad";
            this.pnl_Cadastro_Cad.Size = new System.Drawing.Size(300, 530);
            this.pnl_Cadastro_Cad.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(449, 326);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastre-se aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Não tem uma conta?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome de Usuário:";
            // 
            // txtNome_CadstroAdmin
            // 
            this.txtNome_CadstroAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome_CadstroAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_CadstroAdmin.Location = new System.Drawing.Point(335, 220);
            this.txtNome_CadstroAdmin.Name = "txtNome_CadstroAdmin";
            this.txtNome_CadstroAdmin.Size = new System.Drawing.Size(290, 31);
            this.txtNome_CadstroAdmin.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Senha:";
            // 
            // txtSenha_CadastroAdmin
            // 
            this.txtSenha_CadastroAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha_CadastroAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha_CadastroAdmin.Location = new System.Drawing.Point(335, 284);
            this.txtSenha_CadastroAdmin.Name = "txtSenha_CadastroAdmin";
            this.txtSenha_CadastroAdmin.Size = new System.Drawing.Size(290, 31);
            this.txtSenha_CadastroAdmin.TabIndex = 15;
            this.txtSenha_CadastroAdmin.UseSystemPasswordChar = true;
            this.txtSenha_CadastroAdmin.TextChanged += new System.EventHandler(this.txtSenha_CadastroAdmin_TextChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnFechar.Location = new System.Drawing.Point(710, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSenha_CadastroAdmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNome_CadstroAdmin);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 530);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(333, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(333, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bem vindo!";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.pnl_Cadastro_Cad);
            this.Controls.Add(this.btn_Entrar_Log);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Entrar_Log;
        private System.Windows.Forms.Panel pnl_Cadastro_Cad;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome_CadstroAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha_CadastroAdmin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

