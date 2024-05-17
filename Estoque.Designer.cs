namespace TCC_3_M
{
    partial class frm_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Estoque));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOpcoes_Estoque = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarPnlEstoque = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltarEstoque = new System.Windows.Forms.Button();
            this.btnPerifericosEstoque = new System.Windows.Forms.Button();
            this.btnRegistrosEstoque = new System.Windows.Forms.Button();
            this.btnHardwareEstoque = new System.Windows.Forms.Button();
            this.pnlHardware_Estoque = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtModeloEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Procurar_Usuario = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbStatusHardwareEstoque = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrdernarHardwareEstoque = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPesquisarHardwareEstoque = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlOpcoes_Estoque.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlHardware_Estoque.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlOpcoes_Estoque);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlHardware_Estoque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 471);
            this.panel1.TabIndex = 1;
            // 
            // pnlOpcoes_Estoque
            // 
            this.pnlOpcoes_Estoque.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlOpcoes_Estoque.Controls.Add(this.label1);
            this.pnlOpcoes_Estoque.Controls.Add(this.btnVoltarPnlEstoque);
            this.pnlOpcoes_Estoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpcoes_Estoque.Location = new System.Drawing.Point(0, 70);
            this.pnlOpcoes_Estoque.Name = "pnlOpcoes_Estoque";
            this.pnlOpcoes_Estoque.Size = new System.Drawing.Size(904, 49);
            this.pnlOpcoes_Estoque.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estoque";
            // 
            // btnVoltarPnlEstoque
            // 
            this.btnVoltarPnlEstoque.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVoltarPnlEstoque.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltarPnlEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarPnlEstoque.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPnlEstoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarPnlEstoque.Location = new System.Drawing.Point(0, 0);
            this.btnVoltarPnlEstoque.Name = "btnVoltarPnlEstoque";
            this.btnVoltarPnlEstoque.Size = new System.Drawing.Size(47, 49);
            this.btnVoltarPnlEstoque.TabIndex = 50;
            this.btnVoltarPnlEstoque.Text = "<";
            this.btnVoltarPnlEstoque.UseVisualStyleBackColor = false;
            this.btnVoltarPnlEstoque.Click += new System.EventHandler(this.btnVoltarEstoque_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnVoltarEstoque);
            this.panel2.Controls.Add(this.btnPerifericosEstoque);
            this.panel2.Controls.Add(this.btnRegistrosEstoque);
            this.panel2.Controls.Add(this.btnHardwareEstoque);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 70);
            this.panel2.TabIndex = 0;
            // 
            // btnVoltarEstoque
            // 
            this.btnVoltarEstoque.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVoltarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarEstoque.Image")));
            this.btnVoltarEstoque.Location = new System.Drawing.Point(794, 0);
            this.btnVoltarEstoque.Name = "btnVoltarEstoque";
            this.btnVoltarEstoque.Size = new System.Drawing.Size(110, 70);
            this.btnVoltarEstoque.TabIndex = 8;
            this.btnVoltarEstoque.Text = "Voltar";
            this.btnVoltarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltarEstoque.UseVisualStyleBackColor = true;
            this.btnVoltarEstoque.Click += new System.EventHandler(this.btnVoltarCreditos_Click);
            // 
            // btnPerifericosEstoque
            // 
            this.btnPerifericosEstoque.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPerifericosEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerifericosEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerifericosEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPerifericosEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnPerifericosEstoque.Image")));
            this.btnPerifericosEstoque.Location = new System.Drawing.Point(197, 0);
            this.btnPerifericosEstoque.Name = "btnPerifericosEstoque";
            this.btnPerifericosEstoque.Size = new System.Drawing.Size(108, 70);
            this.btnPerifericosEstoque.TabIndex = 2;
            this.btnPerifericosEstoque.Text = "Periféricos";
            this.btnPerifericosEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPerifericosEstoque.UseVisualStyleBackColor = true;
            // 
            // btnRegistrosEstoque
            // 
            this.btnRegistrosEstoque.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistrosEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrosEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrosEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrosEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrosEstoque.Image")));
            this.btnRegistrosEstoque.Location = new System.Drawing.Point(97, 0);
            this.btnRegistrosEstoque.Name = "btnRegistrosEstoque";
            this.btnRegistrosEstoque.Size = new System.Drawing.Size(100, 70);
            this.btnRegistrosEstoque.TabIndex = 3;
            this.btnRegistrosEstoque.Text = "Registros";
            this.btnRegistrosEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistrosEstoque.UseVisualStyleBackColor = true;
            // 
            // btnHardwareEstoque
            // 
            this.btnHardwareEstoque.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHardwareEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardwareEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardwareEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHardwareEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnHardwareEstoque.Image")));
            this.btnHardwareEstoque.Location = new System.Drawing.Point(0, 0);
            this.btnHardwareEstoque.Name = "btnHardwareEstoque";
            this.btnHardwareEstoque.Size = new System.Drawing.Size(97, 70);
            this.btnHardwareEstoque.TabIndex = 1;
            this.btnHardwareEstoque.Text = "Hardware";
            this.btnHardwareEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHardwareEstoque.UseVisualStyleBackColor = true;
            this.btnHardwareEstoque.Click += new System.EventHandler(this.btnHardwareEstoque_Click);
            // 
            // pnlHardware_Estoque
            // 
            this.pnlHardware_Estoque.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlHardware_Estoque.Controls.Add(this.panel3);
            this.pnlHardware_Estoque.Controls.Add(this.btnPesquisarHardwareEstoque);
            this.pnlHardware_Estoque.Controls.Add(this.dataGridView1);
            this.pnlHardware_Estoque.Enabled = false;
            this.pnlHardware_Estoque.Location = new System.Drawing.Point(0, 115);
            this.pnlHardware_Estoque.Name = "pnlHardware_Estoque";
            this.pnlHardware_Estoque.Size = new System.Drawing.Size(904, 334);
            this.pnlHardware_Estoque.TabIndex = 17;
            this.pnlHardware_Estoque.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.txtModeloEstoque);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_Procurar_Usuario);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Controls.Add(this.cmbStatusHardwareEstoque);
            this.panel3.Controls.Add(this.lblOrderBy);
            this.panel3.Controls.Add(this.cmbOrdernarHardwareEstoque);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 59);
            this.panel3.TabIndex = 16;
            // 
            // txtModeloEstoque
            // 
            this.txtModeloEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModeloEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloEstoque.Location = new System.Drawing.Point(16, 27);
            this.txtModeloEstoque.Name = "txtModeloEstoque";
            this.txtModeloEstoque.Size = new System.Drawing.Size(184, 24);
            this.txtModeloEstoque.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Modelo:";
            // 
            // txt_Procurar_Usuario
            // 
            this.txt_Procurar_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Procurar_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Procurar_Usuario.Location = new System.Drawing.Point(727, 30);
            this.txt_Procurar_Usuario.Name = "txt_Procurar_Usuario";
            this.txt_Procurar_Usuario.Size = new System.Drawing.Size(132, 22);
            this.txt_Procurar_Usuario.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(723, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(127, 20);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Pesquisar por Tag:";
            // 
            // cmbStatusHardwareEstoque
            // 
            this.cmbStatusHardwareEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatusHardwareEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusHardwareEstoque.FormattingEnabled = true;
            this.cmbStatusHardwareEstoque.Items.AddRange(new object[] {
            "Em uso",
            "Em manutenção",
            "Em estoque",
            "Indisponível",
            "Quebrado"});
            this.cmbStatusHardwareEstoque.Location = new System.Drawing.Point(414, 27);
            this.cmbStatusHardwareEstoque.Name = "cmbStatusHardwareEstoque";
            this.cmbStatusHardwareEstoque.Size = new System.Drawing.Size(174, 25);
            this.cmbStatusHardwareEstoque.TabIndex = 12;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.Location = new System.Drawing.Point(222, 7);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(85, 17);
            this.lblOrderBy.TabIndex = 9;
            this.lblOrderBy.Text = "Ordenar por:";
            // 
            // cmbOrdernarHardwareEstoque
            // 
            this.cmbOrdernarHardwareEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrdernarHardwareEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdernarHardwareEstoque.FormattingEnabled = true;
            this.cmbOrdernarHardwareEstoque.Items.AddRange(new object[] {
            "Ultima hora",
            "Hoje",
            "Esta semana",
            "Este mês",
            "Este ano"});
            this.cmbOrdernarHardwareEstoque.Location = new System.Drawing.Point(225, 27);
            this.cmbOrdernarHardwareEstoque.Name = "cmbOrdernarHardwareEstoque";
            this.cmbOrdernarHardwareEstoque.Size = new System.Drawing.Size(159, 25);
            this.cmbOrdernarHardwareEstoque.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(411, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // btnPesquisarHardwareEstoque
            // 
            this.btnPesquisarHardwareEstoque.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPesquisarHardwareEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarHardwareEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarHardwareEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisarHardwareEstoque.Image = global::TCC_3_M.Properties.Resources.big_search_len;
            this.btnPesquisarHardwareEstoque.Location = new System.Drawing.Point(784, 292);
            this.btnPesquisarHardwareEstoque.Name = "btnPesquisarHardwareEstoque";
            this.btnPesquisarHardwareEstoque.Size = new System.Drawing.Size(108, 30);
            this.btnPesquisarHardwareEstoque.TabIndex = 18;
            this.btnPesquisarHardwareEstoque.Text = "Pesquisar";
            this.btnPesquisarHardwareEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarHardwareEstoque.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // frm_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - [Estoque]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnlOpcoes_Estoque.ResumeLayout(false);
            this.pnlOpcoes_Estoque.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlHardware_Estoque.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPerifericosEstoque;
        private System.Windows.Forms.Button btnHardwareEstoque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrosEstoque;
        private System.Windows.Forms.Panel pnlOpcoes_Estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarPnlEstoque;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbStatusHardwareEstoque;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrdernarHardwareEstoque;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txt_Procurar_Usuario;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlHardware_Estoque;
        private System.Windows.Forms.TextBox txtModeloEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisarHardwareEstoque;
        private System.Windows.Forms.Button btnVoltarEstoque;
    }
}