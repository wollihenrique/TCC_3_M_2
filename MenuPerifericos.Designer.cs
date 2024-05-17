
namespace TCC_3_M
{
    partial class frm_Perifericos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Perifericos));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btnVoltarPerifericos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btn_Novo_CastroDisp = new System.Windows.Forms.Button();
            this.btn_Pesquisar_CadastroDispo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(0, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 57);
            this.panel3.TabIndex = 29;
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
            this.panel2.Size = new System.Drawing.Size(944, 47);
            this.panel2.TabIndex = 28;
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
            this.btnVoltar_pnlCadastroDevice.Size = new System.Drawing.Size(44, 47);
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
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERIFÉRICOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 281);
            this.dataGridView1.TabIndex = 27;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Menu.Controls.Add(this.btnVoltarPerifericos);
            this.pnl_Menu.Controls.Add(this.button3);
            this.pnl_Menu.Controls.Add(this.button2);
            this.pnl_Menu.Controls.Add(this.btnEdit);
            this.pnl_Menu.Controls.Add(this.btn_Novo_CastroDisp);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(944, 62);
            this.pnl_Menu.TabIndex = 25;
            // 
            // btnVoltarPerifericos
            // 
            this.btnVoltarPerifericos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVoltarPerifericos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarPerifericos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPerifericos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltarPerifericos.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarPerifericos.Image")));
            this.btnVoltarPerifericos.Location = new System.Drawing.Point(832, 0);
            this.btnVoltarPerifericos.Name = "btnVoltarPerifericos";
            this.btnVoltarPerifericos.Size = new System.Drawing.Size(110, 60);
            this.btnVoltarPerifericos.TabIndex = 9;
            this.btnVoltarPerifericos.Text = "Voltar";
            this.btnVoltarPerifericos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltarPerifericos.UseVisualStyleBackColor = true;
            this.btnVoltarPerifericos.Click += new System.EventHandler(this.btnVoltarPerifericos_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::TCC_3_M.Properties.Resources.atualizar1;
            this.button3.Location = new System.Drawing.Point(225, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Atualizar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
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
            this.button2.Location = new System.Drawing.Point(150, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excluir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Image = global::TCC_3_M.Properties.Resources.edit24x;
            this.btnEdit.Location = new System.Drawing.Point(75, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 60);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btn_Novo_CastroDisp
            // 
            this.btn_Novo_CastroDisp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Novo_CastroDisp.FlatAppearance.BorderSize = 0;
            this.btn_Novo_CastroDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo_CastroDisp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo_CastroDisp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Novo_CastroDisp.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo_CastroDisp.Image")));
            this.btn_Novo_CastroDisp.Location = new System.Drawing.Point(0, 0);
            this.btn_Novo_CastroDisp.Name = "btn_Novo_CastroDisp";
            this.btn_Novo_CastroDisp.Size = new System.Drawing.Size(75, 60);
            this.btn_Novo_CastroDisp.TabIndex = 0;
            this.btn_Novo_CastroDisp.Text = "Novo";
            this.btn_Novo_CastroDisp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novo_CastroDisp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Novo_CastroDisp.UseVisualStyleBackColor = true;
            // 
            // btn_Pesquisar_CadastroDispo
            // 
            this.btn_Pesquisar_CadastroDispo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Pesquisar_CadastroDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar_CadastroDispo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar_CadastroDispo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Pesquisar_CadastroDispo.Image = global::TCC_3_M.Properties.Resources.big_search_len;
            this.btn_Pesquisar_CadastroDispo.Location = new System.Drawing.Point(824, 475);
            this.btn_Pesquisar_CadastroDispo.Name = "btn_Pesquisar_CadastroDispo";
            this.btn_Pesquisar_CadastroDispo.Size = new System.Drawing.Size(108, 30);
            this.btn_Pesquisar_CadastroDispo.TabIndex = 26;
            this.btn_Pesquisar_CadastroDispo.Text = "Pesquisar";
            this.btn_Pesquisar_CadastroDispo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pesquisar_CadastroDispo.UseVisualStyleBackColor = false;
            // 
            // frm_Perifericos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Pesquisar_CadastroDispo);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "frm_Perifericos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - [Perifericos]";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Pesquisar_CadastroDispo;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btnVoltarPerifericos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btn_Novo_CastroDisp;
    }
}