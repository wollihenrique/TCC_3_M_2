
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
            this.txtLoteF = new System.Windows.Forms.TextBox();
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
            this.pnlCadastroP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCadastroP.Name = "pnlCadastroP";
            this.pnlCadastroP.Size = new System.Drawing.Size(555, 51);
            this.pnlCadastroP.TabIndex = 30;
            // 
            // btnCloseFrmCadastroLote
            // 
            this.btnCloseFrmCadastroLote.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCloseFrmCadastroLote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFrmCadastroLote.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseFrmCadastroLote.FlatAppearance.BorderSize = 0;
            this.btnCloseFrmCadastroLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFrmCadastroLote.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFrmCadastroLote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseFrmCadastroLote.Location = new System.Drawing.Point(0, 0);
            this.btnCloseFrmCadastroLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseFrmCadastroLote.Name = "btnCloseFrmCadastroLote";
            this.btnCloseFrmCadastroLote.Size = new System.Drawing.Size(69, 49);
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
            this.label1.Location = new System.Drawing.Point(77, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de lote";
            // 
            // txtLoteF
            // 
            this.txtLoteF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoteF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoteF.Location = new System.Drawing.Point(21, 98);
            this.txtLoteF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoteF.Name = "txtLoteF";
            this.txtLoteF.Size = new System.Drawing.Size(245, 32);
            this.txtLoteF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lote / Nota Fiscal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fornecedor:";
            // 
            // cmbFornecedorLote
            // 
            this.cmbFornecedorLote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedorLote.FormattingEnabled = true;
            this.cmbFornecedorLote.Location = new System.Drawing.Point(301, 96);
            this.cmbFornecedorLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFornecedorLote.Name = "cmbFornecedorLote";
            this.cmbFornecedorLote.Size = new System.Drawing.Size(233, 31);
            this.cmbFornecedorLote.TabIndex = 2;
            // 
            // txtDataRecebimentoLote
            // 
            this.txtDataRecebimentoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataRecebimentoLote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRecebimentoLote.Location = new System.Drawing.Point(21, 174);
            this.txtDataRecebimentoLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataRecebimentoLote.Name = "txtDataRecebimentoLote";
            this.txtDataRecebimentoLote.Size = new System.Drawing.Size(245, 32);
            this.txtDataRecebimentoLote.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data de Recebimento:";
            // 
            // btnLimparCadLote
            // 
            this.btnLimparCadLote.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLimparCadLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCadLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCadLote.Location = new System.Drawing.Point(276, 212);
            this.btnLimparCadLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparCadLote.Name = "btnLimparCadLote";
            this.btnLimparCadLote.Size = new System.Drawing.Size(118, 53);
            this.btnLimparCadLote.TabIndex = 4;
            this.btnLimparCadLote.Text = "Limpar";
            this.btnLimparCadLote.UseVisualStyleBackColor = false;
            this.btnLimparCadLote.Click += new System.EventHandler(this.btnLimparCadLote_Click);
            // 
            // btnSalvarCadLote
            // 
            this.btnSalvarCadLote.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarCadLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCadLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadLote.Location = new System.Drawing.Point(409, 212);
            this.btnSalvarCadLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvarCadLote.Name = "btnSalvarCadLote";
            this.btnSalvarCadLote.Size = new System.Drawing.Size(113, 53);
            this.btnSalvarCadLote.TabIndex = 5;
            this.btnSalvarCadLote.Text = "Salvar";
            this.btnSalvarCadLote.UseVisualStyleBackColor = false;
            this.btnSalvarCadLote.Click += new System.EventHandler(this.btnSalvarCadLote_Click);
            // 
            // frm_RegistroLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 291);
            this.Controls.Add(this.btnLimparCadLote);
            this.Controls.Add(this.btnSalvarCadLote);
            this.Controls.Add(this.txtDataRecebimentoLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFornecedorLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoteF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlCadastroP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtLoteF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFornecedorLote;
        private System.Windows.Forms.TextBox txtDataRecebimentoLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimparCadLote;
        private System.Windows.Forms.Button btnSalvarCadLote;
    }
}