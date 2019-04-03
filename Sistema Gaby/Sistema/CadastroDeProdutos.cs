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
    public partial class CadastroDeProdutos : Form
    {
        public CadastroDeProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string NomedoProduto, NomeFuncionario, CodigoBarras, Preco, QntdCadastrada, DataCadastro, Marca, Fornecedor;

            NomedoProduto = txtNomeProduto.Text;
            NomeFuncionario = txtNomeDoFuncionario.Text;
            CodigoBarras = txtCodigoDeBarras.Text;
            Preco = txtPreco.Text;
            QntdCadastrada = txtQuantiaProdutos.Text;
            Marca = txtMarca.Text;
            Fornecedor = txtFornecedor.Text;
            DataCadastro = dtpDataDoCadastro.Text;

            SalvarProduto(NomedoProduto, NomeFuncionario, CodigoBarras, Preco, QntdCadastrada, DataCadastro, Marca, Fornecedor);
            LimparProduto();
        }
        private void SalvarProduto(string NomedoProduto, string NomeFuncionario, string CodigoBarras, string Preco, string QntdCadastrada, string DataCadastro, string Marca, string Fornecedor)
        {
            StreamWriter arquivo;
            string caminho = "";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome do Funcionário: " + NomeFuncionario);
            arquivo.WriteLine("Data de cadastro: " + DataCadastro);
            arquivo.WriteLine("Nome do produto: " + NomedoProduto);
            arquivo.WriteLine("Código de barras: " + CodigoBarras);
            arquivo.WriteLine("Quantidade cadastrada: " + QntdCadastrada);
            arquivo.WriteLine("Fornecedor: " + Fornecedor);
            arquivo.WriteLine("Marca: " + Marca);
            arquivo.WriteLine("Preço: " + Preco);
            arquivo.WriteLine("-----------------------------------------");
            arquivo.WriteLine("");
            arquivo.Close();
        }
        private void LimparProduto()
        {
            txtNomeDoFuncionario.Clear();
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtQuantiaProdutos.Clear();
            txtMarca.Clear();
            txtFornecedor.Clear();
            txtCodigoDeBarras.Clear();
            dtpDataDoCadastro.ResetText();
        }
    }
}
