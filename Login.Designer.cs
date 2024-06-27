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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btnEntrarLog = new System.Windows.Forms.Button();
            this.pnl_Cadastro_Cad = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkCadastrar = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnl_Cadastro_Cad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrarLog
            // 
            this.btnEntrarLog.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrarLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLog.ForeColor = System.Drawing.Color.White;
            this.btnEntrarLog.Location = new System.Drawing.Point(799, 569);
            this.btnEntrarLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrarLog.Name = "btnEntrarLog";
            this.btnEntrarLog.Size = new System.Drawing.Size(113, 43);
            this.btnEntrarLog.TabIndex = 4;
            this.btnEntrarLog.Text = "Entrar";
            this.btnEntrarLog.UseVisualStyleBackColor = false;
            this.btnEntrarLog.Click += new System.EventHandler(this.btnEntrarLog_Click);
            // 
            // pnl_Cadastro_Cad
            // 
            this.pnl_Cadastro_Cad.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Cadastro_Cad.Controls.Add(this.pictureBox1);
            this.pnl_Cadastro_Cad.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Cadastro_Cad.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cadastro_Cad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Cadastro_Cad.Name = "pnl_Cadastro_Cad";
            this.pnl_Cadastro_Cad.Size = new System.Drawing.Size(400, 652);
            this.pnl_Cadastro_Cad.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 194);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lnkCadastrar
            // 
            this.lnkCadastrar.AutoSize = true;
            this.lnkCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastrar.Location = new System.Drawing.Point(599, 401);
            this.lnkCadastrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkCadastrar.Name = "lnkCadastrar";
            this.lnkCadastrar.Size = new System.Drawing.Size(120, 20);
            this.lnkCadastrar.TabIndex = 3;
            this.lnkCadastrar.TabStop = true;
            this.lnkCadastrar.Text = "Cadastre-se aqui";
            this.lnkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadastrar_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Não tem uma conta?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email:";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.Location = new System.Drawing.Point(447, 265);
            this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(386, 26);
            this.txtUsuarioLogin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Senha:";
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.Location = new System.Drawing.Point(447, 338);
            this.txtSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(386, 26);
            this.txtSenhaLogin.TabIndex = 2;
            this.txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnFechar.Location = new System.Drawing.Point(947, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(53, 49);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.txtSenhaLogin);
            this.panel1.Controls.Add(this.btnEntrarLog);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtUsuarioLogin);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lnkCadastrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 652);
            this.panel1.TabIndex = 17;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLogin.Location = new System.Drawing.Point(447, 111);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(153, 55);
            this.lblLogin.TabIndex = 17;
            this.lblLogin.Text = "Login";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.pnl_Cadastro_Cad);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_Cadastro_Cad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEntrarLog;
        private System.Windows.Forms.Panel pnl_Cadastro_Cad;
        private System.Windows.Forms.LinkLabel lnkCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
    }
}

