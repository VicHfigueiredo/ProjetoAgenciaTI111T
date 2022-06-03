using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI111T.Model;
using ProjetoAgenciaTI111T.Controller;

namespace ProjetoAgenciaTI111T.View
{
    public partial class TelaCadastrarCliente : Form
    {
        public TelaCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCiente_Click(object sender, EventArgs e)
        {
            if (tbxNomeCliente.Text == "" | tbxEmailCliente.Text == "" | tbxSenhaCliente.Text == "" | pictureBoxFotoCliente.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clientes.NomeCli = tbxNomeCliente.Text;
            Clientes.EmailCli = tbxEmailCliente.Text;
            Clientes.SenhaCli = tbxSenhaCliente.Text;
            if (pictureBoxFotoCliente.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBoxFotoCliente.Image.Save(memoryStream, pictureBoxFotoCliente.Image.RawFormat);
                Clientes.ImagemCli = memoryStream.ToArray();
            }

            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.cadastrarCliente();

            if (Clientes.Retorno == "Sim")
            {
                limparTela();
                return;
            }

            if (Clientes.Retorno == "Não")
            {
                fecharCadastro();
                return;
            }
        }

        private void btnBuscarFotoCliente_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png*;.jpeg)" + " | *.jpg;*.png*;.jpeg";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotoCliente.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }

        public void TelaCadastrarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                limparTela();
            }
        }

        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }

        }

        private void fecharCadastro()
        {
            this.Close();
        }

        private void TelaCadastrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}


