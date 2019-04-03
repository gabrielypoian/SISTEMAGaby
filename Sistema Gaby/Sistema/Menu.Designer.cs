namespace Sistema
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.btnCadastroFuncionarios = new System.Windows.Forms.Button();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroClientes.Image")));
            this.btnCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroClientes.Location = new System.Drawing.Point(12, 30);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(149, 44);
            this.btnCadastroClientes.TabIndex = 0;
            this.btnCadastroClientes.Text = "Cadastro de clientes";
            this.btnCadastroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadastroClientes_Click);
            // 
            // btnCadastroFuncionarios
            // 
            this.btnCadastroFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFuncionarios.Image")));
            this.btnCadastroFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionarios.Location = new System.Drawing.Point(196, 30);
            this.btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            this.btnCadastroFuncionarios.Size = new System.Drawing.Size(165, 44);
            this.btnCadastroFuncionarios.TabIndex = 1;
            this.btnCadastroFuncionarios.Text = " Cadastro de funcionários";
            this.btnCadastroFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroFuncionarios.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionarios.Click += new System.EventHandler(this.btnCadastroFuncionarios_Click);
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProdutos.Image")));
            this.btnCadastroProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProdutos.Location = new System.Drawing.Point(12, 125);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(149, 44);
            this.btnCadastroProdutos.TabIndex = 2;
            this.btnCadastroProdutos.Text = "Cadastro de produtos";
            this.btnCadastroProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.btnCadastroProdutos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(302, 125);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 44);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 274);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.btnCadastroFuncionarios);
            this.Controls.Add(this.btnCadastroClientes);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroClientes;
        private System.Windows.Forms.Button btnCadastroFuncionarios;
        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.Button btnSair;
    }
}