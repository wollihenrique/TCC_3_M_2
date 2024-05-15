
namespace TCC_3_M
{
    partial class frm_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Inicio));
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnHistoricos = new System.Windows.Forms.Button();
            this.btnPerifericos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnComputadores = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.pnlMenus = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Creditos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.Location = new System.Drawing.Point(690, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(110, 70);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnPerifericos
            // 
            this.btnPerifericos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerifericos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPerifericos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerifericos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerifericos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPerifericos.Image = global::TCC_3_M.Properties.Resources.rato;
            this.btnPerifericos.Location = new System.Drawing.Point(511, 108);
            this.btnPerifericos.Name = "btnPerifericos";
            this.btnPerifericos.Size = new System.Drawing.Size(136, 104);
            this.btnPerifericos.TabIndex = 4;
            this.btnPerifericos.Text = "Periféricos";
            this.btnPerifericos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPerifericos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(511, 234);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(136, 104);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Usuários";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(343, 234);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 104);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Deletar";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnComputadores
            // 
            this.btnComputadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComputadores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnComputadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputadores.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputadores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComputadores.Image = global::TCC_3_M.Properties.Resources.computador;
            this.btnComputadores.Location = new System.Drawing.Point(343, 108);
            this.btnComputadores.Name = "btnComputadores";
            this.btnComputadores.Size = new System.Drawing.Size(136, 104);
            this.btnComputadores.TabIndex = 1;
            this.btnComputadores.Text = "Hardware";
            this.btnComputadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComputadores.UseVisualStyleBackColor = false;
            this.btnComputadores.Click += new System.EventHandler(this.btnCadastrarDispositivo_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstoque.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(174, 108);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(136, 104);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // pnlMenus
            // 
            this.pnlMenus.Controls.Add(this.pictureBox1);
            this.pnlMenus.Controls.Add(this.button4);
            this.pnlMenus.Controls.Add(this.btn_Creditos);
            this.pnlMenus.Controls.Add(this.button1);
            this.pnlMenus.Controls.Add(this.btnUsuario);
            this.pnlMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenus.Location = new System.Drawing.Point(0, 0);
            this.pnlMenus.Name = "pnlMenus";
            this.pnlMenus.Size = new System.Drawing.Size(800, 70);
            this.pnlMenus.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(360, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 70);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ajuda";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_Creditos
            // 
            this.btn_Creditos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creditos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Creditos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Creditos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Creditos.Image")));
            this.btn_Creditos.Location = new System.Drawing.Point(470, 0);
            this.btn_Creditos.Name = "btn_Creditos";
            this.btn_Creditos.Size = new System.Drawing.Size(110, 70);
            this.btn_Creditos.TabIndex = 9;
            this.btn_Creditos.Text = "Créditos";
            this.btn_Creditos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Creditos.UseVisualStyleBackColor = true;
            this.btn_Creditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(580, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnComputadores);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnPerifericos);
            this.panel1.Controls.Add(this.btnHistoricos);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 8;
            // 
            // frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnlMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnComputadores;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPerifericos;
        private System.Windows.Forms.Button btnHistoricos;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel pnlMenus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Creditos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}