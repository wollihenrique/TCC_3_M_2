
namespace TCC_3_M
{
    partial class frm_CadastroDisp
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnExcluirHardware = new System.Windows.Forms.Button();
            this.btnAtualizarHardware = new System.Windows.Forms.Button();
            this.btnEditarRegistroHardware = new System.Windows.Forms.Button();
            this.btnNovoHardware = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 288);
            this.dataGridView1.TabIndex = 20;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFilter.Controls.Add(this.button2);
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
            this.pnlFilter.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // btnExcluirHardware
            // 
            this.btnExcluirHardware.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirHardware.Location = new System.Drawing.Point(499, 459);
            this.btnExcluirHardware.Name = "btnExcluirHardware";
            this.btnExcluirHardware.Size = new System.Drawing.Size(100, 50);
            this.btnExcluirHardware.TabIndex = 33;
            this.btnExcluirHardware.Text = "Excluir Dispositivo";
            this.btnExcluirHardware.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarHardware
            // 
            this.btnAtualizarHardware.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarHardware.Location = new System.Drawing.Point(282, 459);
            this.btnAtualizarHardware.Name = "btnAtualizarHardware";
            this.btnAtualizarHardware.Size = new System.Drawing.Size(100, 50);
            this.btnAtualizarHardware.TabIndex = 32;
            this.btnAtualizarHardware.Text = "Atualizar";
            this.btnAtualizarHardware.UseVisualStyleBackColor = true;
            // 
            // btnEditarRegistroHardware
            // 
            this.btnEditarRegistroHardware.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistroHardware.Location = new System.Drawing.Point(608, 459);
            this.btnEditarRegistroHardware.Name = "btnEditarRegistroHardware";
            this.btnEditarRegistroHardware.Size = new System.Drawing.Size(100, 50);
            this.btnEditarRegistroHardware.TabIndex = 31;
            this.btnEditarRegistroHardware.Text = "Editar Registro";
            this.btnEditarRegistroHardware.UseVisualStyleBackColor = true;
            this.btnEditarRegistroHardware.Click += new System.EventHandler(this.btnEditarRegistroHardware_Click);
            // 
            // btnNovoHardware
            // 
            this.btnNovoHardware.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHardware.Location = new System.Drawing.Point(388, 459);
            this.btnNovoHardware.Name = "btnNovoHardware";
            this.btnNovoHardware.Size = new System.Drawing.Size(100, 50);
            this.btnNovoHardware.TabIndex = 30;
            this.btnNovoHardware.Text = "Novo Dispositivo";
            this.btnNovoHardware.UseVisualStyleBackColor = true;
            this.btnNovoHardware.Click += new System.EventHandler(this.btnNovoHardware_Click);
            // 
            // frm_CadastroDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.btnExcluirHardware);
            this.Controls.Add(this.btnAtualizarHardware);
            this.Controls.Add(this.btnEditarRegistroHardware);
            this.Controls.Add(this.btnNovoHardware);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CadastroDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - [Cadastro de Dispositivos]";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderBy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExcluirHardware;
        private System.Windows.Forms.Button btnAtualizarHardware;
        private System.Windows.Forms.Button btnEditarRegistroHardware;
        private System.Windows.Forms.Button btnNovoHardware;
    }
}