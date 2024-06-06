
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
            this.txtCpfCnpjMenu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.btnEditarRegistroUsuario = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizarUsuario
            // 
            this.btnAtualizarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarUsuario.Location = new System.Drawing.Point(383, 434);
            this.btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            this.btnAtualizarUsuario.Size = new System.Drawing.Size(100, 50);
            this.btnAtualizarUsuario.TabIndex = 34;
            this.btnAtualizarUsuario.Text = "Atualizar";
            this.btnAtualizarUsuario.UseVisualStyleBackColor = true;
            this.btnAtualizarUsuario.Click += new System.EventHandler(this.btnAtualizarUsuario_Click);
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFornecedor.Location = new System.Drawing.Point(496, 434);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(100, 50);
            this.btnNovoFornecedor.TabIndex = 32;
            this.btnNovoFornecedor.Text = "Novo Fornecedor";
            this.btnNovoFornecedor.UseVisualStyleBackColor = true;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.txtCpfCnpjMenu);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 84);
            this.panel3.TabIndex = 31;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "CPF/CNPJ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(-30, 87);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(770, 288);
            this.dgvFornecedor.TabIndex = 30;
            // 
            // btnEditarRegistroUsuario
            // 
            this.btnEditarRegistroUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistroUsuario.Location = new System.Drawing.Point(605, 434);
            this.btnEditarRegistroUsuario.Name = "btnEditarRegistroUsuario";
            this.btnEditarRegistroUsuario.Size = new System.Drawing.Size(100, 50);
            this.btnEditarRegistroUsuario.TabIndex = 33;
            this.btnEditarRegistroUsuario.Text = "Editar Registro";
            this.btnEditarRegistroUsuario.UseVisualStyleBackColor = true;
            // 
            // frm_MenuFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.btnAtualizarUsuario);
            this.Controls.Add(this.btnEditarRegistroUsuario);
            this.Controls.Add(this.btnNovoFornecedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MenuFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFornecedores";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizarUsuario;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCpfCnpjMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Button btnEditarRegistroUsuario;
    }
}