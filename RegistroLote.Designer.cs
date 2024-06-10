
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
            this.pnlCadastroP.Size = new System.Drawing.Size(416, 42);
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
            this.btnCloseFrmCadastroLote.Click += new System.EventHandler(this.btnCloseFrmCadastroLote_Click_1);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome do Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fornecedor:";
            // 
            // cmbFornecedorLote
            // 
            this.cmbFornecedorLote.FormattingEnabled = true;
            this.cmbFornecedorLote.Location = new System.Drawing.Point(226, 80);
            this.cmbFornecedorLote.Name = "cmbFornecedorLote";
            this.cmbFornecedorLote.Size = new System.Drawing.Size(176, 21);
            this.cmbFornecedorLote.TabIndex = 38;
            // 
            // txtDataRecebimentoLote
            // 
            this.txtDataRecebimentoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataRecebimentoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRecebimentoLote.Location = new System.Drawing.Point(16, 137);
            this.txtDataRecebimentoLote.Name = "txtDataRecebimentoLote";
            this.txtDataRecebimentoLote.Size = new System.Drawing.Size(184, 22);
            this.txtDataRecebimentoLote.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data de Recebimento:";
            // 
            // btnLimparCadLote
            // 
            this.btnLimparCadLote.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLimparCadLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCadLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCadLote.Location = new System.Drawing.Point(226, 128);
            this.btnLimparCadLote.Name = "btnLimparCadLote";
            this.btnLimparCadLote.Size = new System.Drawing.Size(76, 31);
            this.btnLimparCadLote.TabIndex = 60;
            this.btnLimparCadLote.Text = "Limpar";
            this.btnLimparCadLote.UseVisualStyleBackColor = false;
            this.btnLimparCadLote.Click += new System.EventHandler(this.btnLimparCadLote_Click);
            // 
            // btnSalvarCadLote
            // 
            this.btnSalvarCadLote.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarCadLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCadLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadLote.Location = new System.Drawing.Point(317, 128);
            this.btnSalvarCadLote.Name = "btnSalvarCadLote";
            this.btnSalvarCadLote.Size = new System.Drawing.Size(76, 31);
            this.btnSalvarCadLote.TabIndex = 59;
            this.btnSalvarCadLote.Text = "Salvar";
            this.btnSalvarCadLote.UseVisualStyleBackColor = false;
            this.btnSalvarCadLote.Click += new System.EventHandler(this.btnSalvarCadLote_Click);
            // 
            // frm_RegistroLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 180);
            this.Controls.Add(this.btnLimparCadLote);
            this.Controls.Add(this.btnSalvarCadLote);
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
        private System.Windows.Forms.Button btnLimparCadLote;
        private System.Windows.Forms.Button btnSalvarCadLote;
    }
}