namespace TCC_3_M
{
    partial class frm_Usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCpfUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Label();
            this.btnCloseMenuUsuarios = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderByUsuario = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnEditarRegistroUsuario = new System.Windows.Forms.Button();
            this.btnAtualizarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.txtCpfUsuario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.txtNomeUsuario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblOrderBy);
            this.panel3.Controls.Add(this.cmbOrderByUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 97);
            this.panel3.TabIndex = 25;
            // 
            // txtCpfUsuario
            // 
            this.txtCpfUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfUsuario.Location = new System.Drawing.Point(167, 65);
            this.txtCpfUsuario.Name = "txtCpfUsuario";
            this.txtCpfUsuario.Size = new System.Drawing.Size(130, 22);
            this.txtCpfUsuario.TabIndex = 20;
            this.txtCpfUsuario.TextChanged += new System.EventHandler(this.txtCpfUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "CPF:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.panelDataGrid);
            this.panel1.Controls.Add(this.btnCloseMenuUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 35);
            this.panel1.TabIndex = 18;
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
            this.panelDataGrid.Location = new System.Drawing.Point(60, 1);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(164, 29);
            this.panelDataGrid.TabIndex = 16;
            this.panelDataGrid.Text = "Funcionários";
            // 
            // btnCloseMenuUsuarios
            // 
            this.btnCloseMenuUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.btnCloseMenuUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseMenuUsuarios.FlatAppearance.BorderSize = 0;
            this.btnCloseMenuUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMenuUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMenuUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnCloseMenuUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnCloseMenuUsuarios.Name = "btnCloseMenuUsuarios";
            this.btnCloseMenuUsuarios.Size = new System.Drawing.Size(59, 35);
            this.btnCloseMenuUsuarios.TabIndex = 13;
            this.btnCloseMenuUsuarios.Text = "X";
            this.btnCloseMenuUsuarios.UseVisualStyleBackColor = false;
            this.btnCloseMenuUsuarios.Click += new System.EventHandler(this.btnCloseMenuUsuarios_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(15, 65);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(130, 22);
            this.txtNomeUsuario.TabIndex = 15;
            this.txtNomeUsuario.TextChanged += new System.EventHandler(this.txtNomeUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.ForeColor = System.Drawing.Color.White;
            this.lblOrderBy.Location = new System.Drawing.Point(315, 42);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(92, 18);
            this.lblOrderBy.TabIndex = 9;
            this.lblOrderBy.Text = "Ordenar por:";
            // 
            // cmbOrderByUsuario
            // 
            this.cmbOrderByUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrderByUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderByUsuario.FormattingEnabled = true;
            this.cmbOrderByUsuario.Items.AddRange(new object[] {
            "Ultima hora",
            "Hoje",
            "Esta semana",
            "Este mês",
            "Este ano"});
            this.cmbOrderByUsuario.Location = new System.Drawing.Point(318, 64);
            this.cmbOrderByUsuario.Name = "cmbOrderByUsuario";
            this.cmbOrderByUsuario.Size = new System.Drawing.Size(145, 23);
            this.cmbOrderByUsuario.TabIndex = 11;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.ColumnHeadersHeight = 30;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.DarkGray;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.Size = new System.Drawing.Size(995, 448);
            this.dgvUsuarios.TabIndex = 22;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNovoUsuario.Location = new System.Drawing.Point(863, 557);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(120, 70);
            this.btnNovoUsuario.TabIndex = 26;
            this.btnNovoUsuario.Text = "Novo Usuario";
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnEditarRegistroUsuario
            // 
            this.btnEditarRegistroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarRegistroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRegistroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistroUsuario.ForeColor = System.Drawing.Color.Gray;
            this.btnEditarRegistroUsuario.Location = new System.Drawing.Point(599, 557);
            this.btnEditarRegistroUsuario.Name = "btnEditarRegistroUsuario";
            this.btnEditarRegistroUsuario.Size = new System.Drawing.Size(120, 70);
            this.btnEditarRegistroUsuario.TabIndex = 27;
            this.btnEditarRegistroUsuario.Text = "Editar Registro";
            this.btnEditarRegistroUsuario.UseVisualStyleBackColor = false;
            this.btnEditarRegistroUsuario.Click += new System.EventHandler(this.btnEditarRegistroUsuario_Click);
            // 
            // btnAtualizarUsuario
            // 
            this.btnAtualizarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizarUsuario.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAtualizarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarUsuario.ForeColor = System.Drawing.Color.Gold;
            this.btnAtualizarUsuario.Location = new System.Drawing.Point(465, 557);
            this.btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            this.btnAtualizarUsuario.Size = new System.Drawing.Size(120, 70);
            this.btnAtualizarUsuario.TabIndex = 28;
            this.btnAtualizarUsuario.Text = "Atualizar";
            this.btnAtualizarUsuario.UseVisualStyleBackColor = false;
            this.btnAtualizarUsuario.Click += new System.EventHandler(this.btnAtualizarUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirUsuario.Location = new System.Drawing.Point(731, 557);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(120, 70);
            this.btnExcluirUsuario.TabIndex = 29;
            this.btnExcluirUsuario.Text = "Excluir Usuário";
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dgvUsuarios);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 455);
            this.panel2.TabIndex = 30;
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.btnAtualizarUsuario);
            this.Controls.Add(this.btnEditarRegistroUsuario);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Usuario";
            this.Text = "Menu - [Cadastro Usuarios]";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderByUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnEditarRegistroUsuario;
        private System.Windows.Forms.Button btnAtualizarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label panelDataGrid;
        private System.Windows.Forms.Button btnCloseMenuUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCpfUsuario;
        private System.Windows.Forms.Label label2;
    }
}