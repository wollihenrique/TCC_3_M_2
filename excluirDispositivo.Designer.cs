
namespace TCC_3_M
{
    partial class frm_ExcluirDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ExcluirDispositivo));
            this.txtTag = new System.Windows.Forms.TextBox();
            this.btn_Excluir_ExcluirDisp = new System.Windows.Forms.Button();
            this.btn_Voltar_ExcluirDisp = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbDeviceType = new System.Windows.Forms.ComboBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTag
            // 
            this.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTag.Location = new System.Drawing.Point(146, 100);
            this.txtTag.Multiline = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(121, 20);
            this.txtTag.TabIndex = 59;
            // 
            // btn_Excluir_ExcluirDisp
            // 
            this.btn_Excluir_ExcluirDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir_ExcluirDisp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir_ExcluirDisp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Excluir_ExcluirDisp.Location = new System.Drawing.Point(534, 415);
            this.btn_Excluir_ExcluirDisp.Name = "btn_Excluir_ExcluirDisp";
            this.btn_Excluir_ExcluirDisp.Size = new System.Drawing.Size(62, 23);
            this.btn_Excluir_ExcluirDisp.TabIndex = 58;
            this.btn_Excluir_ExcluirDisp.Text = "Excluir";
            this.btn_Excluir_ExcluirDisp.UseVisualStyleBackColor = true;
            this.btn_Excluir_ExcluirDisp.Click += new System.EventHandler(this.btn_Excluir_ExcluirDisp_Click);
            // 
            // btn_Voltar_ExcluirDisp
            // 
            this.btn_Voltar_ExcluirDisp.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Voltar_ExcluirDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_ExcluirDisp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_ExcluirDisp.Location = new System.Drawing.Point(442, 415);
            this.btn_Voltar_ExcluirDisp.Name = "btn_Voltar_ExcluirDisp";
            this.btn_Voltar_ExcluirDisp.Size = new System.Drawing.Size(62, 23);
            this.btn_Voltar_ExcluirDisp.TabIndex = 57;
            this.btn_Voltar_ExcluirDisp.Text = "Voltar";
            this.btn_Voltar_ExcluirDisp.UseVisualStyleBackColor = false;
            this.btn_Voltar_ExcluirDisp.Click += new System.EventHandler(this.btn_Voltar_ExcluirDisp_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Em uso",
            "Em estoque",
            "Em manutenção",
            "Em conserto",
            "Indisponível",
            "Para descarte"});
            this.cmbStatus.Location = new System.Drawing.Point(453, 204);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 47;
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDeviceType.FormattingEnabled = true;
            this.cmbDeviceType.Location = new System.Drawing.Point(299, 204);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(121, 21);
            this.cmbDeviceType.TabIndex = 46;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceType.Location = new System.Drawing.Point(296, 186);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(113, 15);
            this.lblDeviceType.TabIndex = 45;
            this.lblDeviceType.Text = "Tipo de Dispositivo :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(450, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Status :";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(143, 82);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(31, 15);
            this.lblTag.TabIndex = 37;
            this.lblTag.Text = "Tag :";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(13, 82);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(56, 15);
            this.lblLatitude.TabIndex = 35;
            this.lblLatitude.Text = "Latitude :";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(152, 186);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 15);
            this.lblModel.TabIndex = 34;
            this.lblModel.Text = "Modelo :";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(13, 186);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 15);
            this.lblBrand.TabIndex = 33;
            this.lblBrand.Text = "Marca :";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(140, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 13);
            this.lblSearch.TabIndex = 60;
            this.lblSearch.Text = "Pesquisar Dispositivo :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(143, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(441, 20);
            this.txtSearch.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 29);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Pesquisar ID :";
            // 
            // txt_
            // 
            this.txt_.Location = new System.Drawing.Point(13, 59);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(124, 20);
            this.txt_.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblFilter);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 48);
            this.panel2.TabIndex = 65;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(67, 13);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(70, 26);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filtrar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(16, 100);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 66;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Em uso",
            "Em estoque",
            "Em manutenção",
            "Em conserto",
            "Indisponível",
            "Para descarte"});
            this.comboBox1.Location = new System.Drawing.Point(155, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 67;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Em uso",
            "Em estoque",
            "Em manutenção",
            "Em conserto",
            "Indisponível",
            "Para descarte"});
            this.comboBox2.Location = new System.Drawing.Point(16, 204);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 68;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 166);
            this.dataGridView1.TabIndex = 69;
            // 
            // frm_ExcluirDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(623, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btn_Excluir_ExcluirDisp);
            this.Controls.Add(this.btn_Voltar_ExcluirDisp);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbDeviceType);
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm_ExcluirDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Dispositivo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button btn_Voltar_ExcluirDisp;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Excluir_ExcluirDisp;
    }
}