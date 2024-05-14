namespace TCC_3_M
{
    partial class frm_Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Creditos));
            this.pnlCreditos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltarCreditos = new System.Windows.Forms.Button();
            this.pnlCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreditos
            // 
            this.pnlCreditos.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCreditos.Controls.Add(this.pictureBox1);
            this.pnlCreditos.Controls.Add(this.btnVoltarCreditos);
            this.pnlCreditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreditos.Location = new System.Drawing.Point(0, 0);
            this.pnlCreditos.Name = "pnlCreditos";
            this.pnlCreditos.Size = new System.Drawing.Size(800, 70);
            this.pnlCreditos.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltarCreditos
            // 
            this.btnVoltarCreditos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVoltarCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCreditos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCreditos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltarCreditos.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarCreditos.Image")));
            this.btnVoltarCreditos.Location = new System.Drawing.Point(690, 0);
            this.btnVoltarCreditos.Name = "btnVoltarCreditos";
            this.btnVoltarCreditos.Size = new System.Drawing.Size(110, 70);
            this.btnVoltarCreditos.TabIndex = 7;
            this.btnVoltarCreditos.Text = "Voltar";
            this.btnVoltarCreditos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltarCreditos.UseVisualStyleBackColor = true;
            this.btnVoltarCreditos.Click += new System.EventHandler(this.btnVoltarCreditos_Click);
            // 
            // frm_Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCreditos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Creditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creditos";
            this.pnlCreditos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCreditos;
        private System.Windows.Forms.Button btnVoltarCreditos;
    }
}