
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHardware = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.panelDataGrid = new System.Windows.Forms.Label();
            this.btnCloseFrmMenuFornecedores = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirHardware = new System.Windows.Forms.Button();
            this.btnAtualizarHardware = new System.Windows.Forms.Button();
            this.btnEditarRegistroHardware = new System.Windows.Forms.Button();
            this.btnNovoHardware = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardware)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHardware
            // 
            this.dgvHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHardware.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHardware.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHardware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHardware.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHardware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHardware.ColumnHeadersHeight = 30;
            this.dgvHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHardware.EnableHeadersVisualStyles = false;
            this.dgvHardware.GridColor = System.Drawing.Color.DarkGray;
            this.dgvHardware.Location = new System.Drawing.Point(0, 0);
            this.dgvHardware.Name = "dgvHardware";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHardware.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHardware.Size = new System.Drawing.Size(995, 448);
            this.dgvHardware.TabIndex = 22;
            this.dgvHardware.SelectionChanged += new System.EventHandler(this.dgvHardware_SelectionChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlFilter.Controls.Add(this.lblUsuario);
            this.pnlFilter.Controls.Add(this.cmbUsuario);
            this.pnlFilter.Controls.Add(this.panelDataGrid);
            this.pnlFilter.Controls.Add(this.btnCloseFrmMenuFornecedores);
            this.pnlFilter.Controls.Add(this.txtTag);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.cmbStatus);
            this.pnlFilter.Controls.Add(this.lblOrderBy);
            this.pnlFilter.Controls.Add(this.cmbOrderBy);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.panel1);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(995, 104);
            this.pnlFilter.TabIndex = 18;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(643, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuário:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(647, 66);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(175, 24);
            this.cmbUsuario.TabIndex = 17;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
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
            this.panelDataGrid.Size = new System.Drawing.Size(239, 29);
            this.panelDataGrid.TabIndex = 15;
            this.panelDataGrid.Text = "Filtros de Pesquisa";
            // 
            // btnCloseFrmMenuFornecedores
            // 
            this.btnCloseFrmMenuFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.btnCloseFrmMenuFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFrmMenuFornecedores.FlatAppearance.BorderSize = 0;
            this.btnCloseFrmMenuFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFrmMenuFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFrmMenuFornecedores.ForeColor = System.Drawing.Color.White;
            this.btnCloseFrmMenuFornecedores.Location = new System.Drawing.Point(0, 0);
            this.btnCloseFrmMenuFornecedores.Name = "btnCloseFrmMenuFornecedores";
            this.btnCloseFrmMenuFornecedores.Size = new System.Drawing.Size(53, 38);
            this.btnCloseFrmMenuFornecedores.TabIndex = 14;
            this.btnCloseFrmMenuFornecedores.Text = "X";
            this.btnCloseFrmMenuFornecedores.UseVisualStyleBackColor = false;
            this.btnCloseFrmMenuFornecedores.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTag
            // 
            this.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag.Location = new System.Drawing.Point(16, 66);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(97, 22);
            this.txtTag.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "TAG:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(485, 66);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 24);
            this.cmbStatus.TabIndex = 6;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.ForeColor = System.Drawing.Color.White;
            this.lblOrderBy.Location = new System.Drawing.Point(220, 41);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(98, 20);
            this.lblOrderBy.TabIndex = 3;
            this.lblOrderBy.Text = "Ordenar por:";
            // 
            // cmbOrderBy
            // 
            this.cmbOrderBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderBy.FormattingEnabled = true;
            this.cmbOrderBy.Location = new System.Drawing.Point(223, 66);
            this.cmbOrderBy.Name = "cmbOrderBy";
            this.cmbOrderBy.Size = new System.Drawing.Size(165, 24);
            this.cmbOrderBy.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(481, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 38);
            this.panel1.TabIndex = 16;
            // 
            // btnExcluirHardware
            // 
            this.btnExcluirHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirHardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirHardware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirHardware.Location = new System.Drawing.Point(731, 557);
            this.btnExcluirHardware.Name = "btnExcluirHardware";
            this.btnExcluirHardware.Size = new System.Drawing.Size(120, 70);
            this.btnExcluirHardware.TabIndex = 33;
            this.btnExcluirHardware.Text = "Excluir Dispositivo";
            this.btnExcluirHardware.UseVisualStyleBackColor = false;
            this.btnExcluirHardware.Click += new System.EventHandler(this.btnExcluirHardware_Click);
            // 
            // btnAtualizarHardware
            // 
            this.btnAtualizarHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizarHardware.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAtualizarHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarHardware.ForeColor = System.Drawing.Color.Gold;
            this.btnAtualizarHardware.Location = new System.Drawing.Point(465, 557);
            this.btnAtualizarHardware.Name = "btnAtualizarHardware";
            this.btnAtualizarHardware.Size = new System.Drawing.Size(120, 70);
            this.btnAtualizarHardware.TabIndex = 32;
            this.btnAtualizarHardware.Text = "Atualizar";
            this.btnAtualizarHardware.UseVisualStyleBackColor = false;
            this.btnAtualizarHardware.Click += new System.EventHandler(this.btnAtualizarHardware_Click_1);
            // 
            // btnEditarRegistroHardware
            // 
            this.btnEditarRegistroHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarRegistroHardware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarRegistroHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarRegistroHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRegistroHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistroHardware.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEditarRegistroHardware.Location = new System.Drawing.Point(599, 557);
            this.btnEditarRegistroHardware.Name = "btnEditarRegistroHardware";
            this.btnEditarRegistroHardware.Size = new System.Drawing.Size(120, 70);
            this.btnEditarRegistroHardware.TabIndex = 31;
            this.btnEditarRegistroHardware.Text = "Editar Registro";
            this.btnEditarRegistroHardware.UseVisualStyleBackColor = false;
            this.btnEditarRegistroHardware.Click += new System.EventHandler(this.btnEditarRegistroHardware_Click);
            // 
            // btnNovoHardware
            // 
            this.btnNovoHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoHardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNovoHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHardware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNovoHardware.Location = new System.Drawing.Point(863, 557);
            this.btnNovoHardware.Name = "btnNovoHardware";
            this.btnNovoHardware.Size = new System.Drawing.Size(120, 70);
            this.btnNovoHardware.TabIndex = 30;
            this.btnNovoHardware.Text = "Novo Dispositivo";
            this.btnNovoHardware.UseVisualStyleBackColor = false;
            this.btnNovoHardware.Click += new System.EventHandler(this.btnNovoHardware_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dgvHardware);
            this.panel3.Location = new System.Drawing.Point(0, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 448);
            this.panel3.TabIndex = 36;
            // 
            // frm_CadastroDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExcluirHardware);
            this.Controls.Add(this.btnAtualizarHardware);
            this.Controls.Add(this.btnEditarRegistroHardware);
            this.Controls.Add(this.btnNovoHardware);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CadastroDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - [Cadastro de Dispositivos]";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardware)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderBy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCloseFrmMenuFornecedores;
        private System.Windows.Forms.Button btnExcluirHardware;
        private System.Windows.Forms.Button btnAtualizarHardware;
        private System.Windows.Forms.Button btnEditarRegistroHardware;
        private System.Windows.Forms.Button btnNovoHardware;
        private System.Windows.Forms.Label panelDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
    }
}