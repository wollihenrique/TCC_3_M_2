namespace TCC_3_M
{
    partial class frm_CadastroAdmin
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
            this.txt_Usuario_Cad = new System.Windows.Forms.TextBox();
            this.txt_Senha_Cad = new System.Windows.Forms.TextBox();
            this.btn_Caldastrar_Cad = new System.Windows.Forms.Button();
            this.txt_Email_Cad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Voltar_Cad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Usuario_Cad
            // 
            this.txt_Usuario_Cad.Location = new System.Drawing.Point(246, 98);
            this.txt_Usuario_Cad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Usuario_Cad.Name = "txt_Usuario_Cad";
            this.txt_Usuario_Cad.Size = new System.Drawing.Size(117, 20);
            this.txt_Usuario_Cad.TabIndex = 0;
            // 
            // txt_Senha_Cad
            // 
            this.txt_Senha_Cad.Location = new System.Drawing.Point(246, 149);
            this.txt_Senha_Cad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Senha_Cad.Name = "txt_Senha_Cad";
            this.txt_Senha_Cad.Size = new System.Drawing.Size(117, 20);
            this.txt_Senha_Cad.TabIndex = 1;
            // 
            // btn_Caldastrar_Cad
            // 
            this.btn_Caldastrar_Cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Caldastrar_Cad.Location = new System.Drawing.Point(245, 223);
            this.btn_Caldastrar_Cad.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Caldastrar_Cad.Name = "btn_Caldastrar_Cad";
            this.btn_Caldastrar_Cad.Size = new System.Drawing.Size(56, 19);
            this.btn_Caldastrar_Cad.TabIndex = 2;
            this.btn_Caldastrar_Cad.Text = "Salvar";
            this.btn_Caldastrar_Cad.UseVisualStyleBackColor = true;
            // 
            // txt_Email_Cad
            // 
            this.txt_Email_Cad.Location = new System.Drawing.Point(246, 191);
            this.txt_Email_Cad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email_Cad.Name = "txt_Email_Cad";
            this.txt_Email_Cad.Size = new System.Drawing.Size(117, 20);
            this.txt_Email_Cad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // btn_Voltar_Cad
            // 
            this.btn_Voltar_Cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_Cad.Location = new System.Drawing.Point(306, 223);
            this.btn_Voltar_Cad.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Voltar_Cad.Name = "btn_Voltar_Cad";
            this.btn_Voltar_Cad.Size = new System.Drawing.Size(56, 19);
            this.btn_Voltar_Cad.TabIndex = 7;
            this.btn_Voltar_Cad.Text = "Inicio";
            this.btn_Voltar_Cad.UseVisualStyleBackColor = true;
            this.btn_Voltar_Cad.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_CadastroAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Voltar_Cad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email_Cad);
            this.Controls.Add(this.btn_Caldastrar_Cad);
            this.Controls.Add(this.txt_Senha_Cad);
            this.Controls.Add(this.txt_Usuario_Cad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_CadastroAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario_Cad;
        private System.Windows.Forms.TextBox txt_Senha_Cad;
        private System.Windows.Forms.Button btn_Caldastrar_Cad;
        private System.Windows.Forms.TextBox txt_Email_Cad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Voltar_Cad;
    }
}