using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenciaTI111T.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.TelaCadastrarCliente cadastrarCliente = new TelaCadastrarCliente();
            cadastrarCliente.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View.TelaCadastrarFuncionario cadastrarFuncionario = new TelaCadastrarFuncionario();
            cadastrarFuncionario.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            View.TelaCadastrarPacote cadastrarPacote = new TelaCadastrarPacote();
            cadastrarPacote.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarCliente telaPesquisarCliente = new TelaPesquisarCliente();
            telaPesquisarCliente.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisarFuncionario telaPesquisarFuncionario = new TelaPesquisarFuncionario();
            telaPesquisarFuncionario.Show();
        }
    }
}
