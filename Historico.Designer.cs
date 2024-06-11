
namespace TCC_3_M
{
    partial class frm_Historico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHistoric = new System.Windows.Forms.DataGridView();
            this.pnlFilterHistoric = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDataGrid = new System.Windows.Forms.Label();
            this.btnCloseHistoric = new System.Windows.Forms.Button();
            this.txtIdHistoric = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderByHistoric = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoric)).BeginInit();
            this.pnlFilterHistoric.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dgvHistoric);
            this.panel3.Location = new System.Drawing.Point(4, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 468);
            this.panel3.TabIndex = 44;
            // 
            // dgvHistoric
            // 
            this.dgvHistoric.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistoric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoric.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistoric.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvHistoric.Location = new System.Drawing.Point(0, 0);
            this.dgvHistoric.Name = "dgvHistoric";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHistoric.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistoric.Size = new System.Drawing.Size(991, 468);
            this.dgvHistoric.TabIndex = 20;
            // 
            // pnlFilterHistoric
            // 
            this.pnlFilterHistoric.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlFilterHistoric.Controls.Add(this.button1);
            this.pnlFilterHistoric.Controls.Add(this.panelDataGrid);
            this.pnlFilterHistoric.Controls.Add(this.btnCloseHistoric);
            this.pnlFilterHistoric.Controls.Add(this.txtIdHistoric);
            this.pnlFilterHistoric.Controls.Add(this.label2);
            this.pnlFilterHistoric.Controls.Add(this.lblOrderBy);
            this.pnlFilterHistoric.Controls.Add(this.cmbOrderByHistoric);
            this.pnlFilterHistoric.Controls.Add(this.panel1);
            this.pnlFilterHistoric.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterHistoric.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFilterHistoric.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterHistoric.Name = "pnlFilterHistoric";
            this.pnlFilterHistoric.Size = new System.Drawing.Size(999, 112);
            this.pnlFilterHistoric.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGrid.AutoSize = true;
            this.panelDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.panelDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataGrid.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelDataGrid.Location = new System.Drawing.Point(59, 4);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(117, 29);
            this.panelDataGrid.TabIndex = 15;
            this.panelDataGrid.Text = "Histórico";
            // 
            // btnCloseHistoric
            // 
            this.btnCloseHistoric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.btnCloseHistoric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseHistoric.FlatAppearance.BorderSize = 0;
            this.btnCloseHistoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseHistoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseHistoric.ForeColor = System.Drawing.Color.White;
            this.btnCloseHistoric.Location = new System.Drawing.Point(0, 0);
            this.btnCloseHistoric.Name = "btnCloseHistoric";
            this.btnCloseHistoric.Size = new System.Drawing.Size(53, 38);
            this.btnCloseHistoric.TabIndex = 14;
            this.btnCloseHistoric.Text = "X";
            this.btnCloseHistoric.UseVisualStyleBackColor = false;
            this.btnCloseHistoric.Click += new System.EventHandler(this.btnCloseHistoric_Click);
            // 
            // txtIdHistoric
            // 
            this.txtIdHistoric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdHistoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHistoric.Location = new System.Drawing.Point(21, 64);
            this.txtIdHistoric.Name = "txtIdHistoric";
            this.txtIdHistoric.Size = new System.Drawing.Size(122, 22);
            this.txtIdHistoric.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.ForeColor = System.Drawing.Color.White;
            this.lblOrderBy.Location = new System.Drawing.Point(221, 45);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(98, 20);
            this.lblOrderBy.TabIndex = 3;
            this.lblOrderBy.Text = "Ordenar por:";
            // 
            // cmbOrderByHistoric
            // 
            this.cmbOrderByHistoric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrderByHistoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderByHistoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderByHistoric.FormattingEnabled = true;
            this.cmbOrderByHistoric.Items.AddRange(new object[] {
            "Lotes",
            "Dispositivos",
            "Periféricos",
            "Funcionários"});
            this.cmbOrderByHistoric.Location = new System.Drawing.Point(223, 66);
            this.cmbOrderByHistoric.Name = "cmbOrderByHistoric";
            this.cmbOrderByHistoric.Size = new System.Drawing.Size(165, 24);
            this.cmbOrderByHistoric.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 38);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(-8, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 547);
            this.panel2.TabIndex = 45;
            // 
            // frm_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 633);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFilterHistoric);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Historico";
            this.Text = "Historico";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoric)).EndInit();
            this.pnlFilterHistoric.ResumeLayout(false);
            this.pnlFilterHistoric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvHistoric;
        private System.Windows.Forms.Panel pnlFilterHistoric;
        private System.Windows.Forms.Label panelDataGrid;
        private System.Windows.Forms.Button btnCloseHistoric;
        private System.Windows.Forms.TextBox txtIdHistoric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderByHistoric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}