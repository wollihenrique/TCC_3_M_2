
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroDisp));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Voltar_CadastroDisp = new System.Windows.Forms.Button();
            this.btn_Pesquisar_CadastroDispo = new System.Windows.Forms.Button();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btn_Novo_CastroDisp = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 153);
            this.dataGridView1.TabIndex = 20;
            // 
            // btn_Voltar_CadastroDisp
            // 
            this.btn_Voltar_CadastroDisp.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Voltar_CadastroDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_CadastroDisp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_CadastroDisp.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar_CadastroDisp.Location = new System.Drawing.Point(503, 429);
            this.btn_Voltar_CadastroDisp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Voltar_CadastroDisp.Name = "btn_Voltar_CadastroDisp";
            this.btn_Voltar_CadastroDisp.Size = new System.Drawing.Size(71, 33);
            this.btn_Voltar_CadastroDisp.TabIndex = 19;
            this.btn_Voltar_CadastroDisp.Text = "Voltar";
            this.btn_Voltar_CadastroDisp.UseVisualStyleBackColor = false;
            // 
            // btn_Pesquisar_CadastroDispo
            // 
            this.btn_Pesquisar_CadastroDispo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Pesquisar_CadastroDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar_CadastroDispo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar_CadastroDispo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Pesquisar_CadastroDispo.Image = global::TCC_3_M.Properties.Resources.big_search_len;
            this.btn_Pesquisar_CadastroDispo.Location = new System.Drawing.Point(620, 432);
            this.btn_Pesquisar_CadastroDispo.Name = "btn_Pesquisar_CadastroDispo";
            this.btn_Pesquisar_CadastroDispo.Size = new System.Drawing.Size(108, 30);
            this.btn_Pesquisar_CadastroDispo.TabIndex = 17;
            this.btn_Pesquisar_CadastroDispo.Text = "Pesquisar";
            this.btn_Pesquisar_CadastroDispo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pesquisar_CadastroDispo.UseVisualStyleBackColor = false;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Menu.Controls.Add(this.button3);
            this.pnl_Menu.Controls.Add(this.button2);
            this.pnl_Menu.Controls.Add(this.btnEdit);
            this.pnl_Menu.Controls.Add(this.btn_Novo_CastroDisp);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 58);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(740, 60);
            this.pnl_Menu.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::TCC_3_M.Properties.Resources.atualizar;
            this.button3.Location = new System.Drawing.Point(225, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 58);
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
            this.button2.Size = new System.Drawing.Size(75, 58);
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
            this.btnEdit.Size = new System.Drawing.Size(75, 58);
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
            this.btn_Novo_CastroDisp.Size = new System.Drawing.Size(75, 58);
            this.btn_Novo_CastroDisp.TabIndex = 0;
            this.btn_Novo_CastroDisp.Text = "Novo";
            this.btn_Novo_CastroDisp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novo_CastroDisp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Novo_CastroDisp.UseVisualStyleBackColor = true;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.pnlFilter.Size = new System.Drawing.Size(740, 58);
            this.pnlFilter.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 7);
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
            this.cmbStatus.Location = new System.Drawing.Point(628, 23);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(174, 25);
            this.cmbStatus.TabIndex = 6;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.Location = new System.Drawing.Point(448, 3);
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
            this.cmbOrderBy.Location = new System.Drawing.Point(451, 24);
            this.cmbOrderBy.Name = "cmbOrderBy";
            this.cmbOrderBy.Size = new System.Drawing.Size(159, 25);
            this.cmbOrderBy.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(625, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(155, 27);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(278, 24);
            this.txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(152, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Procurar:";
            // 
            // frm_CadastroDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Voltar_CadastroDisp);
            this.Controls.Add(this.btn_Pesquisar_CadastroDispo);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CadastroDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - [Cadastro de Dispositivos]";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Voltar_CadastroDisp;
        private System.Windows.Forms.Button btn_Pesquisar_CadastroDispo;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btn_Novo_CastroDisp;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderBy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}