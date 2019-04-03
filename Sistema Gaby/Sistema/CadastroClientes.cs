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
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string vegano, lactose, diabetico, vegetariano, estadocivil;

            if(ckbVegano.Checked == true)
            {
                vegano = "sim";
            }
            else
            {
                vegano = "não";
            }

            if(ckbVegetariano.Checked == true)
            {
                vegetariano = "sim";
            }
            else
            {
                vegetariano = "não";
            }

            if(ckbLactose.Checked == true)
            {
                lactose = "sim";
            }
            else
            {
                lactose = "não";
            }

            if(ckbDiabetico.Checked == true)
            {
                diabetico = "sim";
            }
            else
            {
                diabetico = "não";
            }

            if(rbtnCasado.Checked == true)
            {
                estadocivil = "Casado";
            }else if(rbtnSolteiro.Checked == true)
            {
                estadocivil = "Solteiro";
            }
            else
            {
                estadocivil = "";
            }
            GravarCliente(txtNome.Text, txtEmail.Text, mtxtTelefone.Text, mtxtCelular.Text, txtCidade.Text, txtEstado.Text, estadocivil, vegetariano, vegano, lactose, diabetico, txtCEP.Text, txtEndereco.Text, txtBairro.Text);
            MessageBox.Show("Cliente cadastrado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparClientes();
        }
        private void GravarCliente(string nome, string email, string telefone, string celular, string cidade, string estado, string estadocivil, string vegetariano, string lactose, string vegano, string diabetico, string cep, string bairro, string endereco)
        {
            StreamWriter arquivo;
            string caminho = "Cadastro de Clientes";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Celular: " + celular);
            arquivo.WriteLine("CEP: " + cep);
            arquivo.WriteLine("Endereço: " + endereco);
            arquivo.WriteLine("Bairro: " + bairro);
            arquivo.WriteLine("Cidade: " + cidade);
            arquivo.WriteLine("Estado: " + estado);
            arquivo.WriteLine("Vegano?: " + vegano);
            arquivo.WriteLine("DIabético?: " + diabetico);
            arquivo.WriteLine("Intolerante à lactose?: " + lactose);
            arquivo.WriteLine("Vegetariano?: " + vegetariano);
            arquivo.WriteLine("--------------------------");
            arquivo.WriteLine("");
            arquivo.Close();
        }
        private void LimparClientes()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mtxtTelefone.Clear();
            mtxtCelular.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            ckbVegetariano.Checked = false;
            ckbVegano.Checked = false;
            ckbLactose.Checked = false;
            ckbDiabetico.Checked = false;
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            string enderecoCompleto = "";

            try
            {
                var webService = new CORREIOS.AtendeClienteClient();
                var resposta = webService.consultaCEP(txtCEP.Text);
                enderecoCompleto += "Endereço: " + resposta.end;
                enderecoCompleto += "\nBairro: " + resposta.bairro;
                enderecoCompleto += "\nCidade: " + resposta.cidade;
                enderecoCompleto += "\nEstado: " + resposta.uf;
                MessageBox.Show(enderecoCompleto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esse CEP não foi encontrado");
            }
        }
    }
}
