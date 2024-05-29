
namespace TCC_3_M
{
    partial class frm_Perifericos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnExcluirPeriferico = new System.Windows.Forms.Button();
            this.btnAtualizarPerifericos = new System.Windows.Forms.Button();
            this.btnEditarRegistroPeriferico = new System.Windows.Forms.Button();
            this.btnNovoPeriferico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 288);
            this.dataGridView1.TabIndex = 22;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFilter.Controls.Add(this.button3);
            this.pnlFilter.Controls.Add(this.textBox1);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.cmbStatus);
            this.pnlFilter.Controls.Add(this.lblOrderBy);
            this.pnlFilter.Controls.Add(this.cmbOrderBy);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(740, 84);
            this.pnlFilter.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Em uso",
            "Em manutenção",
            "Em estoque",
            "Indisponível",
            "Quebrado"});
            this.cmbStatus.Location = new System.Drawing.Point(618, 50);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 25);
            this.cmbStatus.TabIndex = 6;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.Location = new System.Drawing.Point(431, 31);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(91, 17);
            this.lblOrderBy.TabIndex = 3;
            this.lblOrderBy.Text = "Ordenar por:";
            // 
            // cmbOrderBy
            // 
            this.cmbOrderBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderBy.FormattingEnabled = true;
            this.cmbOrderBy.Items.AddRange(new object[] {
            "Ultima hora",
            "Hoje",
            "Esta semana",
            "Este mês",
            "Este ano"});
            this.cmbOrderBy.Location = new System.Drawing.Point(434, 51);
            this.cmbOrderBy.Name = "cmbOrderBy";
            this.cmbOrderBy.Size = new System.Drawing.Size(165, 25);
            this.cmbOrderBy.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(615, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(133, 50);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 24);
            this.txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(130, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Procurar:";
            // 
            // btnExcluirPeriferico
            // 
            this.btnExcluirPeriferico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPeriferico.Location = new System.Drawing.Point(513, 441);
            this.btnExcluirPeriferico.Name = "btnExcluirPeriferico";
            this.btnExcluirPeriferico.Size = new System.Drawing.Size(100, 50);
            this.btnExcluirPeriferico.TabIndex = 37;
            this.btnExcluirPeriferico.Text = "Excluir Periferico";
            this.btnExcluirPeriferico.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarPerifericos
            // 
            this.btnAtualizarPerifericos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPerifericos.Location = new System.Drawing.Point(296, 441);
            this.btnAtualizarPerifericos.Name = "btnAtualizarPerifericos";
            this.btnAtualizarPerifericos.Size = new System.Drawing.Size(100, 50);
            this.btnAtualizarPerifericos.TabIndex = 36;
            this.btnAtualizarPerifericos.Text = "Atualizar";
            this.btnAtualizarPerifericos.UseVisualStyleBackColor = true;
            // 
            // btnEditarRegistroPeriferico
            // 
            this.btnEditarRegistroPeriferico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistroPeriferico.Location = new System.Drawing.Point(622, 441);
            this.btnEditarRegistroPeriferico.Name = "btnEditarRegistroPeriferico";
            this.btnEditarRegistroPeriferico.Size = new System.Drawing.Size(100, 50);
            this.btnEditarRegistroPeriferico.TabIndex = 35;
            this.btnEditarRegistroPeriferico.Text = "Editar Registro";
            this.btnEditarRegistroPeriferico.UseVisualStyleBackColor = true;
            // 
            // btnNovoPeriferico
            // 
            this.btnNovoPeriferico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPeriferico.Location = new System.Drawing.Point(402, 441);
            this.btnNovoPeriferico.Name = "btnNovoPeriferico";
            this.btnNovoPeriferico.Size = new System.Drawing.Size(100, 50);
            this.btnNovoPeriferico.TabIndex = 34;
            this.btnNovoPeriferico.Text = "Novo Periferico";
            this.btnNovoPeriferico.UseVisualStyleBackColor = true;
            // 
            // frm_Perifericos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.btnExcluirPeriferico);
            this.Controls.Add(this.btnAtualizarPerifericos);
            this.Controls.Add(this.btnEditarRegistroPeriferico);
            this.Controls.Add(this.btnNovoPeriferico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Perifericos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPerifericos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderBy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnExcluirPeriferico;
        private System.Windows.Forms.Button btnAtualizarPerifericos;
        private System.Windows.Forms.Button btnEditarRegistroPeriferico;
        private System.Windows.Forms.Button btnNovoPeriferico;
    }
}