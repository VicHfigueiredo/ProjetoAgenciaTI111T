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
using ProjetoAgenciaTI111T.Controller;
using ProjetoAgenciaTI111T.Model;


namespace ProjetoAgenciaTI111T.View
{
    public partial class TelaRegistrarVenda : Form
    {
        public TelaRegistrarVenda()
        {
            InitializeComponent();
        }

        private void TelaRegistrarVenda_Load(object sender, EventArgs e)
        {
            
        }

        private void buscarCodCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Preencha o código do cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCodCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                if (Clientes.Retorno == "Não")
                {
                    tbxCodCli.Text = string.Empty;
                    tbxCodCli.Focus();
                    tbxCodCli.SelectAll();
                    tbxNomeCli.Text = string.Empty;
                    
                    return;
                }
                else
                {

                    tbxCodCli.Text = Clientes.CodigoCli.ToString();
                    tbxNomeCli.Text = Clientes.NomeCli;
                    

                    
                }


            }


        }

        private void buscarCodFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Text = string.Empty;
            }
            else
            {
                Funcionarios.CodigoFun = Convert.ToInt32(tbxCodFun.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFuncionario();

                tbxCodFun.Text = Funcionarios.CodigoFun.ToString();
                tbxNomeFun.Text = Funcionarios.NomeFun;
                

                if (Funcionarios.Retorno == "Não")
                {
                    tbxCodFun.Text = string.Empty;
                    tbxCodFun.Focus();
                    tbxCodFun.SelectAll();
                    tbxCodFun.Text = string.Empty;
                    tbxCodFun.Text = string.Empty;

                    return;
                }
            }
        }

        private void buscarCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite o código ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
            }
            else
            {
                Pacote.CodigoPac = Convert.ToInt32(tbxCodPac.Text);
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.pesquisarPacote();

                tbxCodPac.Text = Pacote.CodigoPac.ToString();
                tbxOrigem.Text = Pacote.OrigemPac;
                tbxDestino.Text = Pacote.DestinoPac;
                

                if (Pacote.Retorno == "Não")
                {
                    tbxCodPac.Text = string.Empty;
                    tbxCodPac.Focus();
                    tbxCodPac.SelectAll();
                    tbxCodPac.Text = string.Empty;
                    tbxCodPac.Text = string.Empty;

                    return;
                }
            }
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            if (tbxValorVenda.Text == "" |  tbxCodCli.Text == "" | tbxCodFun.Text == "" | tbxOrigem.Text == "" | tbxDestino.Text == "" |tbxDestino.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Venda.PagoVenda = Convert.ToInt32(tbxValorVenda.Text);
            Clientes.CodigoCli = Convert.ToInt32(tbxCodCli.Text);
            Funcionarios.CodigoFun = Convert.ToInt32(tbxCodFun.Text);
            Pacote.CodigoPac = Convert.ToInt32(tbxCodPac.Text); 
            

            ManipulaVenda manipulaVenda = new ManipulaVenda();
            manipulaVenda.cadastrarVenda();

            
           
            
            
        }
    }
}
