
namespace TCC_3_M
{
    partial class frm_MenuFornecedores
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
            this.btnAtualizarUsuario = new System.Windows.Forms.Button();
            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.txtCpfCnpjMenu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Label();
            this.btnCloseMenuFornecedores = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.btnEditarRegistroUsuario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizarUsuario
            // 
            this.btnAtualizarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizarUsuario.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAtualizarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarUsuario.ForeColor = System.Drawing.Color.Gold;
            this.btnAtualizarUsuario.Location = new System.Drawing.Point(611, 557);
            this.btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            this.btnAtualizarUsuario.Size = new System.Drawing.Size(120, 70);
            this.btnAtualizarUsuario.TabIndex = 34;
            this.btnAtualizarUsuario.Text = "Atualizar";
            this.btnAtualizarUsuario.UseVisualStyleBackColor = false;
            this.btnAtualizarUsuario.Click += new System.EventHandler(this.btnAtualizarUsuario_Click);
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNovoFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNovoFornecedor.Location = new System.Drawing.Point(863, 557);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(120, 70);
            this.btnNovoFornecedor.TabIndex = 32;
            this.btnNovoFornecedor.Text = "Novo Fornecedor";
            this.btnNovoFornecedor.UseVisualStyleBackColor = false;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lblOrderBy);
            this.panel3.Controls.Add(this.txtCpfCnpjMenu);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 84);
            this.panel3.TabIndex = 31;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.ForeColor = System.Drawing.Color.White;
            this.lblOrderBy.Location = new System.Drawing.Point(12, 34);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(88, 20);
            this.lblOrderBy.TabIndex = 17;
            this.lblOrderBy.Text = "CPF/CNPJ:";
            // 
            // txtCpfCnpjMenu
            // 
            this.txtCpfCnpjMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCnpjMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCnpjMenu.Location = new System.Drawing.Point(15, 53);
            this.txtCpfCnpjMenu.Name = "txtCpfCnpjMenu";
            this.txtCpfCnpjMenu.Size = new System.Drawing.Size(130, 22);
            this.txtCpfCnpjMenu.TabIndex = 15;
            this.txtCpfCnpjMenu.TextChanged += new System.EventHandler(this.txtCpfCnpjMenu_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.panelDataGrid);
            this.panel1.Controls.Add(this.btnCloseMenuFornecedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 35);
            this.panel1.TabIndex = 16;
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
            this.panelDataGrid.Size = new System.Drawing.Size(177, 29);
            this.panelDataGrid.TabIndex = 16;
            this.panelDataGrid.Text = "Fornecedores";
            // 
            // btnCloseMenuFornecedores
            // 
            this.btnCloseMenuFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(148)))));
            this.btnCloseMenuFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseMenuFornecedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseMenuFornecedores.FlatAppearance.BorderSize = 0;
            this.btnCloseMenuFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMenuFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMenuFornecedores.ForeColor = System.Drawing.Color.White;
            this.btnCloseMenuFornecedores.Location = new System.Drawing.Point(0, 0);
            this.btnCloseMenuFornecedores.Name = "btnCloseMenuFornecedores";
            this.btnCloseMenuFornecedores.Size = new System.Drawing.Size(59, 35);
            this.btnCloseMenuFornecedores.TabIndex = 13;
            this.btnCloseMenuFornecedores.Text = "X";
            this.btnCloseMenuFornecedores.UseVisualStyleBackColor = false;
            this.btnCloseMenuFornecedores.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedor.Location = new System.Drawing.Point(0, 0);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(995, 466);
            this.dgvFornecedor.TabIndex = 30;
            // 
            // btnEditarRegistroUsuario
            // 
            this.btnEditarRegistroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarRegistroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRegistroUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistroUsuario.ForeColor = System.Drawing.Color.Gray;
            this.btnEditarRegistroUsuario.Location = new System.Drawing.Point(737, 557);
            this.btnEditarRegistroUsuario.Name = "btnEditarRegistroUsuario";
            this.btnEditarRegistroUsuario.Size = new System.Drawing.Size(120, 70);
            this.btnEditarRegistroUsuario.TabIndex = 33;
            this.btnEditarRegistroUsuario.Text = "Editar Registro";
            this.btnEditarRegistroUsuario.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.dgvFornecedor);
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 466);
            this.panel2.TabIndex = 35;
            // 
            // frm_MenuFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 645);
            this.Controls.Add(this.btnAtualizarUsuario);
            this.Controls.Add(this.btnEditarRegistroUsuario);
            this.Controls.Add(this.btnNovoFornecedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MenuFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFornecedores";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizarUsuario;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCpfCnpjMenu;
        private System.Windows.Forms.Button btnCloseMenuFornecedores;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Button btnEditarRegistroUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label panelDataGrid;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.Panel panel2;
    }
}