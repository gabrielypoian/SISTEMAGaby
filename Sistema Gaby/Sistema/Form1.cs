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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login, senha;

            login = txtNome.Text;
            senha = txtSenha.Text;

            if(login == "Gaby" && senha == "gaby")
            {
                MessageBox.Show("Bem Vindo!");
                Menu frm = new Menu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
                return;
            }
        }
    }
}
