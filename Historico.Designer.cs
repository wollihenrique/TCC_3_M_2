
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
            this.pnlFilterHistoric = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Label();
            this.btnCloseHistoric = new System.Windows.Forms.Button();
            this.txtIdHistoric = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderByHistoric = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilterHistoric.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilterHistoric
            // 
            this.pnlFilterHistoric.BackColor = System.Drawing.Color.SteelBlue;
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
            this.pnlFilterHistoric.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilterHistoric.Name = "pnlFilterHistoric";
            this.pnlFilterHistoric.Size = new System.Drawing.Size(1332, 138);
            this.pnlFilterHistoric.TabIndex = 38;
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
            this.panelDataGrid.Location = new System.Drawing.Point(79, 5);
            this.panelDataGrid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(141, 36);
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
            this.btnCloseHistoric.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseHistoric.Name = "btnCloseHistoric";
            this.btnCloseHistoric.Size = new System.Drawing.Size(71, 47);
            this.btnCloseHistoric.TabIndex = 14;
            this.btnCloseHistoric.Text = "X";
            this.btnCloseHistoric.UseVisualStyleBackColor = false;
            this.btnCloseHistoric.Click += new System.EventHandler(this.btnCloseHistoric_Click);
            // 
            // txtIdHistoric
            // 
            this.txtIdHistoric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdHistoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHistoric.Location = new System.Drawing.Point(28, 83);
            this.txtIdHistoric.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdHistoric.Name = "txtIdHistoric";
            this.txtIdHistoric.Size = new System.Drawing.Size(162, 26);
            this.txtIdHistoric.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.ForeColor = System.Drawing.Color.White;
            this.lblOrderBy.Location = new System.Drawing.Point(295, 55);
            this.lblOrderBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(136, 23);
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
            this.cmbOrderByHistoric.Location = new System.Drawing.Point(297, 81);
            this.cmbOrderByHistoric.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrderByHistoric.Name = "cmbOrderByHistoric";
            this.cmbOrderByHistoric.Size = new System.Drawing.Size(219, 28);
            this.cmbOrderByHistoric.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 50);
            this.panel1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 100);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // frm_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 779);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlFilterHistoric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Historico";
            this.Text = "Historico";
            this.pnlFilterHistoric.ResumeLayout(false);
            this.pnlFilterHistoric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFilterHistoric;
        private System.Windows.Forms.Label panelDataGrid;
        private System.Windows.Forms.Button btnCloseHistoric;
        private System.Windows.Forms.TextBox txtIdHistoric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderByHistoric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}