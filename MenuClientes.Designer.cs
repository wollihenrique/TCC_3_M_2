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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Usuario));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Pesquisar_CadastroDispo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_Status_Usuario = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmb_OrderBy_Usuario = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txt_Procurar_Usuario = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltar_pnlCadastroDevice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_NovoUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(511, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Pesquisar_CadastroDispo
            // 
            this.btn_Pesquisar_CadastroDispo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisar_CadastroDispo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Pesquisar_CadastroDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar_CadastroDispo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar_CadastroDispo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Pesquisar_CadastroDispo.Image = global::TCC_3_M.Properties.Resources.big_search_len;
            this.btn_Pesquisar_CadastroDispo.Location = new System.Drawing.Point(607, 483);
            this.btn_Pesquisar_CadastroDispo.Name = "btn_Pesquisar_CadastroDispo";
            this.btn_Pesquisar_CadastroDispo.Size = new System.Drawing.Size(108, 30);
            this.btn_Pesquisar_CadastroDispo.TabIndex = 26;
            this.btn_Pesquisar_CadastroDispo.Text = "Pesquisar";
            this.btn_Pesquisar_CadastroDispo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pesquisar_CadastroDispo.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.cmb_Status_Usuario);
            this.panel3.Controls.Add(this.lblOrderBy);
            this.panel3.Controls.Add(this.cmb_OrderBy_Usuario);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.txt_Procurar_Usuario);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 59);
            this.panel3.TabIndex = 25;
            // 
            // cmb_Status_Usuario
            // 
            this.cmb_Status_Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Status_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Status_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Status_Usuario.FormattingEnabled = true;
            this.cmb_Status_Usuario.Items.AddRange(new object[] {
            "Em uso",
            "Em manutenção",
            "Em estoque",
            "Indisponível",
            "Quebrado"});
            this.cmb_Status_Usuario.Location = new System.Drawing.Point(519, 24);
            this.cmb_Status_Usuario.Name = "cmb_Status_Usuario";
            this.cmb_Status_Usuario.Size = new System.Drawing.Size(174, 25);
            this.cmb_Status_Usuario.TabIndex = 12;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.Location = new System.Drawing.Point(327, 3);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(85, 17);
            this.lblOrderBy.TabIndex = 9;
            this.lblOrderBy.Text = "Ordenar por:";
            // 
            // cmb_OrderBy_Usuario
            // 
            this.cmb_OrderBy_Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_OrderBy_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_OrderBy_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OrderBy_Usuario.FormattingEnabled = true;
            this.cmb_OrderBy_Usuario.Items.AddRange(new object[] {
            "Ultima hora",
            "Hoje",
            "Esta semana",
            "Este mês",
            "Este ano"});
            this.cmb_OrderBy_Usuario.Location = new System.Drawing.Point(330, 23);
            this.cmb_OrderBy_Usuario.Name = "cmb_OrderBy_Usuario";
            this.cmb_OrderBy_Usuario.Size = new System.Drawing.Size(159, 25);
            this.cmb_OrderBy_Usuario.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(516, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // txt_Procurar_Usuario
            // 
            this.txt_Procurar_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Procurar_Usuario.Location = new System.Drawing.Point(5, 23);
            this.txt_Procurar_Usuario.Name = "txt_Procurar_Usuario";
            this.txt_Procurar_Usuario.Size = new System.Drawing.Size(278, 20);
            this.txt_Procurar_Usuario.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(4, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 17);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Procurar:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnVoltar_pnlCadastroDevice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 44);
            this.panel2.TabIndex = 24;
            // 
            // btnVoltar_pnlCadastroDevice
            // 
            this.btnVoltar_pnlCadastroDevice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVoltar_pnlCadastroDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar_pnlCadastroDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar_pnlCadastroDevice.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar_pnlCadastroDevice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVoltar_pnlCadastroDevice.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar_pnlCadastroDevice.Name = "btnVoltar_pnlCadastroDevice";
            this.btnVoltar_pnlCadastroDevice.Size = new System.Drawing.Size(44, 44);
            this.btnVoltar_pnlCadastroDevice.TabIndex = 52;
            this.btnVoltar_pnlCadastroDevice.Text = "<";
            this.btnVoltar_pnlCadastroDevice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(49, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_NovoUsuario);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 62);
            this.panel1.TabIndex = 23;
            // 
            // btn_NovoUsuario
            // 
            this.btn_NovoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_NovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NovoUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_NovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NovoUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_NovoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_NovoUsuario.Image")));
            this.btn_NovoUsuario.Location = new System.Drawing.Point(160, 0);
            this.btn_NovoUsuario.Name = "btn_NovoUsuario";
            this.btn_NovoUsuario.Size = new System.Drawing.Size(80, 62);
            this.btn_NovoUsuario.TabIndex = 0;
            this.btn_NovoUsuario.Text = "Novo";
            this.btn_NovoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_NovoUsuario.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(80, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Excluir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 62);
            this.button3.TabIndex = 6;
            this.button3.Text = "Atualizar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(21, 171);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(694, 288);
            this.dgvUsuarios.TabIndex = 22;
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Pesquisar_CadastroDispo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Usuario";
            this.Text = "Menu - [Cadastro Usuarios]";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Pesquisar_CadastroDispo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_Status_Usuario;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmb_OrderBy_Usuario;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txt_Procurar_Usuario;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoltar_pnlCadastroDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_NovoUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}