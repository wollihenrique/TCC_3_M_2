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
            this.txt_Usuario_Log = new System.Windows.Forms.TextBox();
            this.txt_Senha_Log = new System.Windows.Forms.TextBox();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Entrar_Log = new System.Windows.Forms.Button();
            this.btn_Cadastro_Log = new System.Windows.Forms.Button();
            this.pnl_Cadastro_Cad = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Cadastro_Cad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Usuario_Log
            // 
            this.txt_Usuario_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario_Log.Location = new System.Drawing.Point(60, 88);
            this.txt_Usuario_Log.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Usuario_Log.Name = "txt_Usuario_Log";
            this.txt_Usuario_Log.Size = new System.Drawing.Size(218, 13);
            this.txt_Usuario_Log.TabIndex = 0;
            // 
            // txt_Senha_Log
            // 
            this.txt_Senha_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Senha_Log.Location = new System.Drawing.Point(60, 135);
            this.txt_Senha_Log.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Senha_Log.Name = "txt_Senha_Log";
            this.txt_Senha_Log.Size = new System.Drawing.Size(218, 13);
            this.txt_Senha_Log.TabIndex = 1;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(57, 68);
            this.lblUser1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(72, 18);
            this.lblUser1.TabIndex = 2;
            this.lblUser1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // btn_Entrar_Log
            // 
            this.btn_Entrar_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar_Log.Location = new System.Drawing.Point(60, 188);
            this.btn_Entrar_Log.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Entrar_Log.Name = "btn_Entrar_Log";
            this.btn_Entrar_Log.Size = new System.Drawing.Size(67, 31);
            this.btn_Entrar_Log.TabIndex = 4;
            this.btn_Entrar_Log.Text = "Entrar";
            this.btn_Entrar_Log.UseVisualStyleBackColor = true;
            this.btn_Entrar_Log.Click += new System.EventHandler(this.btn_Entrar_Log_Click);
            // 
            // btn_Cadastro_Log
            // 
            this.btn_Cadastro_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastro_Log.Location = new System.Drawing.Point(172, 188);
            this.btn_Cadastro_Log.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastro_Log.Name = "btn_Cadastro_Log";
            this.btn_Cadastro_Log.Size = new System.Drawing.Size(87, 31);
            this.btn_Cadastro_Log.TabIndex = 5;
            this.btn_Cadastro_Log.Text = "Cadastrar";
            this.btn_Cadastro_Log.UseVisualStyleBackColor = true;
            this.btn_Cadastro_Log.Click += new System.EventHandler(this.btn_Cadastro_Log_Click);
            // 
            // pnl_Cadastro_Cad
            // 
            this.pnl_Cadastro_Cad.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Cadastro_Cad.Controls.Add(this.label1);
            this.pnl_Cadastro_Cad.Controls.Add(this.pictureBox1);
            this.pnl_Cadastro_Cad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Cadastro_Cad.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cadastro_Cad.Name = "pnl_Cadastro_Cad";
            this.pnl_Cadastro_Cad.Size = new System.Drawing.Size(396, 46);
            this.pnl_Cadastro_Cad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TCC_3_M.Properties.Resources.cadastrar_32px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 249);
            this.Controls.Add(this.pnl_Cadastro_Cad);
            this.Controls.Add(this.btn_Cadastro_Log);
            this.Controls.Add(this.btn_Entrar_Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.txt_Senha_Log);
            this.Controls.Add(this.txt_Usuario_Log);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_Cadastro_Cad.ResumeLayout(false);
            this.pnl_Cadastro_Cad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario_Log;
        private System.Windows.Forms.TextBox txt_Senha_Log;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Entrar_Log;
        private System.Windows.Forms.Button btn_Cadastro_Log;
        private System.Windows.Forms.Panel pnl_Cadastro_Cad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

