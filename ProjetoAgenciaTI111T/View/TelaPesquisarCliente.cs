using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI111T.Model;
using ProjetoAgenciaTI111T.Controller;
using System.IO;

namespace ProjetoAgenciaTI111T.View
{
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarNomeCli_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaCodCli_Click(object sender, EventArgs e)
        {
            if(tbxCodigoCliente.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodigoCliente.Text = string.Empty;
                tbxCodigoCliente.Focus();
                tbxCodigoCliente.SelectAll();
                tbxEmailCliente.Text = string.Empty;
                tbxSenhaCliente.Text = string.Empty;
            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCodigoCliente.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                tbxCodigoCliente.Text = Clientes.CodigoCli.ToString();
                tbxNomeCliente.Text = Clientes.NomeCli;
                tbxSenhaCliente.Text = Clientes.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCli);
                pictureBoxFotoCliente.Image = Image.FromStream(ms);

                if (Clientes.Retorno == "Não")
                {
                    tbxCodigoCliente.Text = string.Empty;
                    tbxCodigoCliente.Focus();
                    tbxCodigoCliente.SelectAll();
                    tbxNomeCliente.Text = string.Empty;
                    tbxSenhaCliente.Text = string.Empty;
                    pictureBoxFotoCliente.Image = null;
                    return;
                }
            }
        }

        private void TelaPesquisarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarImagemCli_Click(object sender, EventArgs e)
        {
            
        }
    }
}
