using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroClientes_Click(object sender, EventArgs e)
        {
            CadastroClientes frm = new CadastroClientes();
            frm.Show();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroDeProdutos frm = new CadastroDeProdutos();
            frm.Show();
            this.Hide();
        }

        private void btnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionarios frm = new CadastroDeFuncionarios();
            frm.Show();
            this.Hide();
        }
    }
}
