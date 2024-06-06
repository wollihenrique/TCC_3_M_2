
namespace TCC_3_M
{
    partial class frm_RegistroLote
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
            this.btnCloseFrmCadastroLote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFornecedorLote = new System.Windows.Forms.ComboBox();
            this.txtDataRecebimentoLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeLote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarcaLote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModeloLote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatusLote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroSerieLote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObsLote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecoLote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimparCadLote = new System.Windows.Forms.Button();
            this.btnSalvarCadLote = new System.Windows.Forms.Button();
            this.pnlCadastroP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroP
            // 
            this.pnlCadastroP.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCadastroP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroP.Controls.Add(this.btnCloseFrmCadastroLote);
            this.pnlCadastroP.Controls.Add(this.label1);
            this.pnlCadastroP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadastroP.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroP.Name = "pnlCadastroP";
            this.pnlCadastroP.Size = new System.Drawing.Size(800, 42);
            this.pnlCadastroP.TabIndex = 30;
            // 
            // btnCloseFrmCadastroLote
            // 
            this.btnCloseFrmCadastroLote.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCloseFrmCadastroLote.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseFrmCadastroLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFrmCadastroLote.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFrmCadastroLote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseFrmCadastroLote.Location = new System.Drawing.Point(0, 0);
            this.btnCloseFrmCadastroLote.Name = "btnCloseFrmCadastroLote";
            this.btnCloseFrmCadastroLote.Size = new System.Drawing.Size(52, 40);
            this.btnCloseFrmCadastroLote.TabIndex = 50;
            this.btnCloseFrmCadastroLote.Text = "X";
            this.btnCloseFrmCadastroLote.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de lote";
            // 
            // txtNomeF
            // 
            this.txtNomeF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeF.Location = new System.Drawing.Point(16, 80);
            this.txtNomeF.Name = "txtNomeF";
            this.txtNomeF.Size = new System.Drawing.Size(184, 22);
            this.txtNomeF.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome do Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fornecedor:";
            // 
            // cmbFornecedorLote
            // 
            this.cmbFornecedorLote.FormattingEnabled = true;
            this.cmbFornecedorLote.Location = new System.Drawing.Point(235, 80);
            this.cmbFornecedorLote.Name = "cmbFornecedorLote";
            this.cmbFornecedorLote.Size = new System.Drawing.Size(167, 21);
            this.cmbFornecedorLote.TabIndex = 38;
            // 
            // txtDataRecebimentoLote
            // 
            this.txtDataRecebimentoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataRecebimentoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRecebimentoLote.Location = new System.Drawing.Point(16, 128);
            this.txtDataRecebimentoLote.Name = "txtDataRecebimentoLote";
            this.txtDataRecebimentoLote.Size = new System.Drawing.Size(184, 22);
            this.txtDataRecebimentoLote.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data de Recebimento:";
            // 
            // txtQuantidadeLote
            // 
            this.txtQuantidadeLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeLote.Location = new System.Drawing.Point(235, 128);
            this.txtQuantidadeLote.Name = "txtQuantidadeLote";
            this.txtQuantidadeLote.Size = new System.Drawing.Size(184, 22);
            this.txtQuantidadeLote.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Quantidade:";
            // 
            // txtMarcaLote
            // 
            this.txtMarcaLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaLote.Location = new System.Drawing.Point(16, 184);
            this.txtMarcaLote.Name = "txtMarcaLote";
            this.txtMarcaLote.Size = new System.Drawing.Size(184, 22);
            this.txtMarcaLote.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Marca:";
            // 
            // txtModeloLote
            // 
            this.txtModeloLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModeloLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloLote.Location = new System.Drawing.Point(244, 187);
            this.txtModeloLote.Name = "txtModeloLote";
            this.txtModeloLote.Size = new System.Drawing.Size(184, 22);
            this.txtModeloLote.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Modelo:";
            // 
            // txtStatusLote
            // 
            this.txtStatusLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusLote.Location = new System.Drawing.Point(16, 232);
            this.txtStatusLote.Name = "txtStatusLote";
            this.txtStatusLote.Size = new System.Drawing.Size(184, 22);
            this.txtStatusLote.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Status do Lote:";
            // 
            // txtNumeroSerieLote
            // 
            this.txtNumeroSerieLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroSerieLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerieLote.Location = new System.Drawing.Point(461, 184);
            this.txtNumeroSerieLote.Name = "txtNumeroSerieLote";
            this.txtNumeroSerieLote.Size = new System.Drawing.Size(184, 22);
            this.txtNumeroSerieLote.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(457, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Número de Série:";
            // 
            // txtObsLote
            // 
            this.txtObsLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObsLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsLote.Location = new System.Drawing.Point(13, 280);
            this.txtObsLote.Name = "txtObsLote";
            this.txtObsLote.Size = new System.Drawing.Size(184, 22);
            this.txtObsLote.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Observações:";
            // 
            // txtPrecoLote
            // 
            this.txtPrecoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoLote.Location = new System.Drawing.Point(440, 128);
            this.txtPrecoLote.Name = "txtPrecoLote";
            this.txtPrecoLote.Size = new System.Drawing.Size(184, 22);
            this.txtPrecoLote.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(436, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Preço Unitário:";
            // 
            // btnLimparCadLote
            // 
            this.btnLimparCadLote.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLimparCadLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCadLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCadLote.Location = new System.Drawing.Point(621, 323);
            this.btnLimparCadLote.Name = "btnLimparCadLote";
            this.btnLimparCadLote.Size = new System.Drawing.Size(76, 31);
            this.btnLimparCadLote.TabIndex = 60;
            this.btnLimparCadLote.Text = "Limpar";
            this.btnLimparCadLote.UseVisualStyleBackColor = false;
            // 
            // btnSalvarCadLote
            // 
            this.btnSalvarCadLote.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarCadLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCadLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadLote.Location = new System.Drawing.Point(712, 323);
            this.btnSalvarCadLote.Name = "btnSalvarCadLote";
            this.btnSalvarCadLote.Size = new System.Drawing.Size(76, 31);
            this.btnSalvarCadLote.TabIndex = 59;
            this.btnSalvarCadLote.Text = "Salvar";
            this.btnSalvarCadLote.UseVisualStyleBackColor = false;
            // 
            // frm_RegistroLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.btnLimparCadLote);
            this.Controls.Add(this.btnSalvarCadLote);
            this.Controls.Add(this.txtPrecoLote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtObsLote);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumeroSerieLote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStatusLote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtModeloLote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMarcaLote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantidadeLote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDataRecebimentoLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFornecedorLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlCadastroP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RegistroLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroLote";
            this.pnlCadastroP.ResumeLayout(false);
            this.pnlCadastroP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroP;
        private System.Windows.Forms.Button btnCloseFrmCadastroLote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFornecedorLote;
        private System.Windows.Forms.TextBox txtDataRecebimentoLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidadeLote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarcaLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModeloLote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatusLote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroSerieLote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObsLote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecoLote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLimparCadLote;
        private System.Windows.Forms.Button btnSalvarCadLote;
    }
}