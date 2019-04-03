namespace Sistema
{
    partial class CadastroDeFuncionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbxEscolaridade = new System.Windows.Forms.GroupBox();
            this.rbtnFundamental = new System.Windows.Forms.RadioButton();
            this.rbtnMedio = new System.Windows.Forms.RadioButton();
            this.rbtnSuperior = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCivil.SuspendLayout();
            this.gbxEscolaridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Celular:";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(15, 95);
            this.mtxtTelefone.Mask = "(99)9999-9999";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefone.TabIndex = 6;
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(140, 95);
            this.mtxtCelular.Mask = "(99)9999-9999";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(100, 20);
            this.mtxtCelular.TabIndex = 7;
            // 
            // cbxCidade
            // 
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "Rio de Janeiro",
            "São Paulo",
            "Minas Gerais"});
            this.cbxCidade.Location = new System.Drawing.Point(15, 147);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(100, 21);
            this.cbxCidade.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG"});
            this.cbxEstado.Location = new System.Drawing.Point(140, 147);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 11;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(15, 174);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(225, 46);
            this.gbxEstadoCivil.TabIndex = 12;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(125, 16);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbtnSolteiro.TabIndex = 1;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro(a)";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(3, 16);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(73, 17);
            this.rbtnCasado.TabIndex = 0;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado(a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Salário    R$:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(321, 171);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(81, 20);
            this.txtSalario.TabIndex = 17;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(259, 197);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(143, 23);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbxEscolaridade
            // 
            this.gbxEscolaridade.Controls.Add(this.rbtnFundamental);
            this.gbxEscolaridade.Controls.Add(this.rbtnMedio);
            this.gbxEscolaridade.Controls.Add(this.rbtnSuperior);
            this.gbxEscolaridade.Location = new System.Drawing.Point(259, 63);
            this.gbxEscolaridade.Name = "gbxEscolaridade";
            this.gbxEscolaridade.Size = new System.Drawing.Size(143, 100);
            this.gbxEscolaridade.TabIndex = 19;
            this.gbxEscolaridade.TabStop = false;
            this.gbxEscolaridade.Text = "Escolaridade";
            // 
            // rbtnFundamental
            // 
            this.rbtnFundamental.AutoSize = true;
            this.rbtnFundamental.Location = new System.Drawing.Point(3, 77);
            this.rbtnFundamental.Name = "rbtnFundamental";
            this.rbtnFundamental.Size = new System.Drawing.Size(121, 17);
            this.rbtnFundamental.TabIndex = 2;
            this.rbtnFundamental.TabStop = true;
            this.rbtnFundamental.Text = "Ensino Fundamental";
            this.rbtnFundamental.UseVisualStyleBackColor = true;
            // 
            // rbtnMedio
            // 
            this.rbtnMedio.AutoSize = true;
            this.rbtnMedio.Location = new System.Drawing.Point(3, 48);
            this.rbtnMedio.Name = "rbtnMedio";
            this.rbtnMedio.Size = new System.Drawing.Size(89, 17);
            this.rbtnMedio.TabIndex = 1;
            this.rbtnMedio.TabStop = true;
            this.rbtnMedio.Text = "Ensino Médio";
            this.rbtnMedio.UseVisualStyleBackColor = true;
            // 
            // rbtnSuperior
            // 
            this.rbtnSuperior.AutoSize = true;
            this.rbtnSuperior.Location = new System.Drawing.Point(3, 16);
            this.rbtnSuperior.Name = "rbtnSuperior";
            this.rbtnSuperior.Size = new System.Drawing.Size(99, 17);
            this.rbtnSuperior.TabIndex = 0;
            this.rbtnSuperior.TabStop = true;
            this.rbtnSuperior.Text = "Ensino Superior";
            this.rbtnSuperior.UseVisualStyleBackColor = true;
            // 
            // CadastroDeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 241);
            this.Controls.Add(this.gbxEscolaridade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroDeFuncionarios";
            this.Text = "CadastroDeFuncionarios";
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.gbxEscolaridade.ResumeLayout(false);
            this.gbxEscolaridade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbxEscolaridade;
        private System.Windows.Forms.RadioButton rbtnSuperior;
        private System.Windows.Forms.RadioButton rbtnMedio;
        private System.Windows.Forms.RadioButton rbtnFundamental;
    }
}