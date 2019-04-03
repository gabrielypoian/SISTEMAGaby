using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema
{
    public partial class CadastroDeFuncionarios : Form
    {
        public CadastroDeFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string estadocivil, nome, escolaridade, salario, celular, telefone, cidade, estado, email;

            nome = txtNome.Text;
            email = txtEmail.Text;
            telefone = mtxtTelefone.Text;
            celular = mtxtCelular.Text;
            salario = txtSalario.Text;
            cidade = cbxCidade.Items[cbxCidade.SelectedIndex].ToString();
            estado = cbxEstado.Items[cbxEstado.SelectedIndex].ToString();
            
            if(rbtnCasado.Checked == true)
            {
                estadocivil = "Casado(a)";
            }
            else
            {
                estadocivil = "Solteiro(a)";
            }

            if(rbtnSuperior.Checked == true)
            {
                escolaridade = "Superior";
            }else if(rbtnMedio.Checked == true)
            {
                escolaridade = "Médio";
            }
            else
            {
                escolaridade = "Fundamental";
            }

            GravarFuncionarios(nome, email, estado, cidade, estadocivil, escolaridade, telefone, celular, salario);
            LimparFuncionarios();
        }
        private void GravarFuncionarios(string nome, string email, string telefone, string celular, string cidade, string estado, string estadocivil, string escolaridade, string salario)
        {
            StreamWriter arquivo;
            string caminho = "";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Celular: " + celular);
            arquivo.WriteLine("Cidade: " + cidade);
            arquivo.WriteLine("Estado: " + estado);
            arquivo.WriteLine("Estado Civil: " + estadocivil);
            arquivo.WriteLine("Escolaridade: " + escolaridade);
            arquivo.WriteLine("Salário: " + salario);
            arquivo.WriteLine("---------------------------------");
            arquivo.WriteLine("");
            arquivo.Close();

        }
        private void LimparFuncionarios()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSalario.Clear();
            mtxtTelefone.Clear();
            mtxtCelular.Clear();
            cbxCidade.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            gbxEstadoCivil.Controls.Clear();
            gbxEscolaridade.Controls.Clear();
        }
    }
}
