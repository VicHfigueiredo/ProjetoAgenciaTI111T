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
            if(tbxNomeCli.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Clientes.NomeCli = tbxNomeCli.Text;

            dataGridViewCliente.DataSource = ManipulaCliente.pesquisarNomeCliente();

            dataGridViewCliente.Columns[0].Visible = false;
            dataGridViewCliente.Columns[1].Visible = false;
            dataGridViewCliente.Columns[2].Visible = false;
            dataGridViewCliente.Columns[3].Visible = false;
            dataGridViewCliente.Columns[4].HeaderCell.Value = "Código";
            dataGridViewCliente.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewCliente.Columns[6].HeaderCell.Value = "Email";
            dataGridViewCliente.Columns[7].Visible = false;
            dataGridViewCliente.Columns[8].HeaderCell.Value = "Foto";
            



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
                else
                {

                    tbxCodigoCliente.Text = Clientes.CodigoCli.ToString();
                    tbxNomeCliente.Text = Clientes.NomeCli;
                    tbxSenhaCliente.Text = Clientes.SenhaCli;

                    MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCli);
                    pictureBoxFotoCliente.Image = Image.FromStream(ms);
                }
            }
        }

        private void TelaPesquisarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarImagemCli_Click(object sender, EventArgs e)
        {
            openFileDialogPesquisar.Filter = "Escolha uma imagem (*.jpg;*.png;*jpeg)" + "| *.jpg; *.jpeg;.png";
            if(openFileDialogPesquisar.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotoCliente.Image = Image.FromFile(openFileDialogPesquisar.FileName);
            }
        }

        private void btnDeletarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodigoCliente.Text == "")
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
                var resposta = MessageBox.Show("Deseja excluir o cliente" + tbxCodigoCliente.Text + " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if(resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCli = Convert.ToInt32(tbxCodigoCliente.Text);

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.deletarCliente();
                }
            }
        }

        private void btnAlterarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodigoCliente.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodigoCliente.Text = string.Empty;
                tbxCodigoCliente.Focus();
                tbxCodigoCliente.SelectAll();
                tbxEmailCliente.Text = string.Empty;
                tbxSenhaCliente.Text = string.Empty;
                pictureBoxFotoCliente.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do cliente" + tbxCodigoCliente.Text + " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.OK)
                {
                    Clientes.CodigoCli = Convert.ToInt32(tbxCodigoCliente.Text);
                    Clientes.NomeCli = tbxNomeCliente.Text;
                    Clientes.EmailCli = tbxEmailCliente.Text;
                    Clientes.SenhaCli = tbxSenhaCliente.Text;

                    MemoryStream ms = new MemoryStream();
                    pictureBoxFotoCliente.Image.Save(ms,pictureBoxFotoCliente.Image.RawFormat);
                    Clientes.ImagemCli = ms.ToArray();

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.alterarCliente();
                }
            }
        }
    }
}
