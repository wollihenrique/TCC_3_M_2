namespace TCC_3_M
{
    partial class Estoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRevisao = new System.Windows.Forms.Button();
            this.btnPerif = new System.Windows.Forms.Button();
            this.btnCompu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRevisao);
            this.panel1.Controls.Add(this.btnPerif);
            this.panel1.Controls.Add(this.btnCompu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnRevisao
            // 
            this.btnRevisao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRevisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisao.Image = global::TCC_3_M.Properties.Resources.revisao;
            this.btnRevisao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisao.Location = new System.Drawing.Point(250, 0);
            this.btnRevisao.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevisao.Name = "btnRevisao";
            this.btnRevisao.Size = new System.Drawing.Size(102, 50);
            this.btnRevisao.TabIndex = 2;
            this.btnRevisao.Text = "Revisão";
            this.btnRevisao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRevisao.UseVisualStyleBackColor = true;
            // 
            // btnPerif
            // 
            this.btnPerif.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPerif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerif.Image = global::TCC_3_M.Properties.Resources.Perifericos;
            this.btnPerif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerif.Location = new System.Drawing.Point(137, 0);
            this.btnPerif.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerif.Name = "btnPerif";
            this.btnPerif.Size = new System.Drawing.Size(113, 50);
            this.btnPerif.TabIndex = 1;
            this.btnPerif.Text = "Periféricos";
            this.btnPerif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerif.UseVisualStyleBackColor = true;
            // 
            // btnCompu
            // 
            this.btnCompu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCompu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompu.Image = global::TCC_3_M.Properties.Resources.Maquina;
            this.btnCompu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompu.Location = new System.Drawing.Point(0, 0);
            this.btnCompu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompu.Name = "btnCompu";
            this.btnCompu.Size = new System.Drawing.Size(137, 50);
            this.btnCompu.TabIndex = 0;
            this.btnCompu.Text = "Computadores";
            this.btnCompu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompu.UseVisualStyleBackColor = true;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1023, 480);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRevisao;
        private System.Windows.Forms.Button btnPerif;
        private System.Windows.Forms.Button btnCompu;
    }
}