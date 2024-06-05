
namespace TCC_3_M
{
    partial class frm_MenuPerifericos
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
            this.btnExcluirPeriferico = new System.Windows.Forms.Button();
            this.btnAtualizarPeriferico = new System.Windows.Forms.Button();
            this.btnEditarRegistroPerifericos = new System.Windows.Forms.Button();
            this.btnNovoPeriferico = new System.Windows.Forms.Button();
            this.dgvPerifericos = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbOrderByPerifericos = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbStatusPerifericos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPeriferico = new System.Windows.Forms.TextBox();
            this.btnClosePerifericos = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerifericos)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluirPeriferico
            // 
            this.btnExcluirPeriferico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPeriferico.Location = new System.Drawing.Point(499, 472);
            this.btnExcluirPeriferico.Name = "btnExcluirPeriferico";
            this.btnExcluirPeriferico.Size = new System.Drawing.Size(100, 50);
            this.btnExcluirPeriferico.TabIndex = 39;
            this.btnExcluirPeriferico.Text = "Excluir Periferico";
            this.btnExcluirPeriferico.UseVisualStyleBackColor = true;
            this.btnExcluirPeriferico.Click += new System.EventHandler(this.btnExcluirPeriferico_Click);
            // 
            // btnAtualizarPeriferico
            // 
            this.btnAtualizarPeriferico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPeriferico.Location = new System.Drawing.Point(282, 472);
            this.btnAtualizarPeriferico.Name = "btnAtualizarPeriferico";
            this.btnAtualizarPeriferico.Size = new System.Drawing.Size(100, 50);
            this.btnAtualizarPeriferico.TabIndex = 38;
            this.btnAtualizarPeriferico.Text = "Atualizar";
            this.btnAtualizarPeriferico.UseVisualStyleBackColor = true;
            // 
            // btnEditarRegistroPerifericos
            // 
            this.btnEditarRegistroPerifericos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistroPerifericos.Location = new System.Drawing.Point(608, 472);
            this.btnEditarRegistroPerifericos.Name = "btnEditarRegistroPerifericos";
            this.btnEditarRegistroPerifericos.Size = new System.Drawing.Size(100, 50);
            this.btnEditarRegistroPerifericos.TabIndex = 37;
            this.btnEditarRegistroPerifericos.Text = "Editar Registro";
            this.btnEditarRegistroPerifericos.UseVisualStyleBackColor = true;
            this.btnEditarRegistroPerifericos.Click += new System.EventHandler(this.btnEditarRegistroPerifericos_Click);
            // 
            // btnNovoPeriferico
            // 
            this.btnNovoPeriferico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPeriferico.Location = new System.Drawing.Point(388, 472);
            this.btnNovoPeriferico.Name = "btnNovoPeriferico";
            this.btnNovoPeriferico.Size = new System.Drawing.Size(100, 50);
            this.btnNovoPeriferico.TabIndex = 36;
            this.btnNovoPeriferico.Text = "Novo Periferico";
            this.btnNovoPeriferico.UseVisualStyleBackColor = true;
            this.btnNovoPeriferico.Click += new System.EventHandler(this.btnNovoPeriferico_Click);
            // 
            // dgvPerifericos
            // 
            this.dgvPerifericos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerifericos.Location = new System.Drawing.Point(0, 98);
            this.dgvPerifericos.Name = "dgvPerifericos";
            this.dgvPerifericos.Size = new System.Drawing.Size(740, 288);
            this.dgvPerifericos.TabIndex = 35;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(359, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // cmbOrderByPerifericos
            // 
            this.cmbOrderByPerifericos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrderByPerifericos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderByPerifericos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderByPerifericos.FormattingEnabled = true;
            this.cmbOrderByPerifericos.Location = new System.Drawing.Point(142, 47);
            this.cmbOrderByPerifericos.Name = "cmbOrderByPerifericos";
            this.cmbOrderByPerifericos.Size = new System.Drawing.Size(165, 25);
            this.cmbOrderByPerifericos.TabIndex = 5;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.Location = new System.Drawing.Point(139, 30);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(83, 16);
            this.lblOrderBy.TabIndex = 3;
            this.lblOrderBy.Text = "Ordenar por:";
            // 
            // cmbStatusPerifericos
            // 
            this.cmbStatusPerifericos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatusPerifericos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusPerifericos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusPerifericos.FormattingEnabled = true;
            this.cmbStatusPerifericos.Location = new System.Drawing.Point(362, 50);
            this.cmbStatusPerifericos.Name = "cmbStatusPerifericos";
            this.cmbStatusPerifericos.Size = new System.Drawing.Size(100, 25);
            this.cmbStatusPerifericos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtIdPeriferico
            // 
            this.txtIdPeriferico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPeriferico.Location = new System.Drawing.Point(7, 50);
            this.txtIdPeriferico.Multiline = true;
            this.txtIdPeriferico.Name = "txtIdPeriferico";
            this.txtIdPeriferico.Size = new System.Drawing.Size(97, 22);
            this.txtIdPeriferico.TabIndex = 8;
            // 
            // btnClosePerifericos
            // 
            this.btnClosePerifericos.Location = new System.Drawing.Point(0, 0);
            this.btnClosePerifericos.Name = "btnClosePerifericos";
            this.btnClosePerifericos.Size = new System.Drawing.Size(59, 31);
            this.btnClosePerifericos.TabIndex = 14;
            this.btnClosePerifericos.Text = "X";
            this.btnClosePerifericos.UseVisualStyleBackColor = true;
            this.btnClosePerifericos.Click += new System.EventHandler(this.btnClosePerifericos_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFilter.Controls.Add(this.btnClosePerifericos);
            this.pnlFilter.Controls.Add(this.txtIdPeriferico);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.cmbStatusPerifericos);
            this.pnlFilter.Controls.Add(this.lblOrderBy);
            this.pnlFilter.Controls.Add(this.cmbOrderByPerifericos);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(740, 84);
            this.pnlFilter.TabIndex = 34;
            // 
            // frm_MenuPerifericos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.btnExcluirPeriferico);
            this.Controls.Add(this.btnAtualizarPeriferico);
            this.Controls.Add(this.btnEditarRegistroPerifericos);
            this.Controls.Add(this.btnNovoPeriferico);
            this.Controls.Add(this.dgvPerifericos);
            this.Controls.Add(this.pnlFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MenuPerifericos";
            this.Text = "MenuPerifericos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerifericos)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirPeriferico;
        private System.Windows.Forms.Button btnAtualizarPeriferico;
        private System.Windows.Forms.Button btnEditarRegistroPerifericos;
        private System.Windows.Forms.Button btnNovoPeriferico;
        private System.Windows.Forms.DataGridView dgvPerifericos;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbOrderByPerifericos;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbStatusPerifericos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPeriferico;
        private System.Windows.Forms.Button btnClosePerifericos;
        private System.Windows.Forms.Panel pnlFilter;
    }
}