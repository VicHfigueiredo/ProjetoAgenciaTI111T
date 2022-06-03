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
using ProjetoAgenciaTI111T.Controller;
using ProjetoAgenciaTI111T.Model;

namespace ProjetoAgenciaTI111T.View
{
    public partial class TelaCadastrarPacote : Form
    {
        public TelaCadastrarPacote()
        {
            InitializeComponent();
        }

        private void btnSalvarPacote_Click(object sender, EventArgs e)
        {
            if (tbxOrigemPac.Text == "" | tbxDestinoPac.Text == "" | rtxDescricaoPacote.Text == "" | dataIdaPacote.Value > dataVoltaPacote.Value | tbxValorPacote.Text == "" | pictureBoxFotoPacote.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 

                Pacote.OrigemPac = tbxOrigemPac.Text;
                Pacote.DestinoPac = tbxDestinoPac.Text;
                Pacote.DataIdaPac = dataIdaPacote.Value;
                Pacote.DatavoltaPac = dataVoltaPacote.Value;
                Pacote.DescricaoPac = rtxDescricaoPacote.Text;
                Pacote.ValorPac = Convert.ToDecimal(tbxValorPacote.Text);
            
                if(pictureBoxFotoPacote != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    pictureBoxFotoPacote.Image.Save(memoryStream, pictureBoxFotoPacote.Image.RawFormat);
                    Pacote.ImagemPac = memoryStream.ToArray();
                }
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.cadastrarPacote();

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
        }
        
        private void TelaCadastrarPacote_KeyPress(object sender, KeyPressEventArgs e)
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

      

        private void TelaCadastrarPacote_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarImagemPacote_Click_1(object sender, EventArgs e)
        {
            openFileDialogImagemPacote.Filter = "Escolha uma imagem (*.jpg;*.png*;.jpeg)" + "| *.jpg;*.png*;.jpeg";
            if (openFileDialogImagemPacote.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotoPacote.Image = Image.FromFile(openFileDialogImagemPacote.FileName);

            }
        }
    }
}
