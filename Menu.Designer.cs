
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
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrarDispositivo = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUsuario.Image")));
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(287, 289);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(181, 128);
            this.btnCadastrarUsuario.TabIndex = 3;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(524, 289);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(181, 128);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Deletar";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrarDispositivo
            // 
            this.btnCadastrarDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarDispositivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDispositivo.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarDispositivo.Image")));
            this.btnCadastrarDispositivo.Location = new System.Drawing.Point(524, 134);
            this.btnCadastrarDispositivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarDispositivo.Name = "btnCadastrarDispositivo";
            this.btnCadastrarDispositivo.Size = new System.Drawing.Size(181, 128);
            this.btnCadastrarDispositivo.TabIndex = 1;
            this.btnCadastrarDispositivo.Text = "Cadastrar Periférico";
            this.btnCadastrarDispositivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarDispositivo.UseVisualStyleBackColor = true;
            this.btnCadastrarDispositivo.Click += new System.EventHandler(this.btnCadastrarDispositivo_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(287, 134);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(181, 128);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrarDispositivo);
            this.Controls.Add(this.btnEstoque);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCadastrarDispositivo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrarUsuario;
    }
}