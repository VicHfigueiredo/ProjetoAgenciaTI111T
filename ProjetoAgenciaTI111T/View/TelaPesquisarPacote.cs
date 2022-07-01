using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI111T.Controller;
using ProjetoAgenciaTI111T.Model;
using System.IO;

namespace ProjetoAgenciaTI111T.View
{
    public partial class TelaPesquisarPacote : Form
    {
        public TelaPesquisarPacote()
        {
            InitializeComponent();
        }

        private void btnBuscarPacote_Click(object sender, EventArgs e)
        {
            if (tbxCodigoPacote.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodigoPacote.Text = string.Empty;
                tbxCodigoPacote.Focus();
                tbxCodigoPacote.SelectAll();
                tbxCodigoPacote.Text = string.Empty;
                tbxCodigoPacote.Text = string.Empty;
            }
            else
            {
                Pacote.CodigoPac = Convert.ToInt32(tbxCodigoPacote.Text);
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.pesquisarPacote();

                tbxCodigoPacote.Text = Pacote.CodigoPac.ToString();
                tbxValorPacote.Text = Convert.ToString(Pacote.ValorPac);
                rtxDescricaoPacote.Text = Pacote.DescricaoPac;
                dateIda.Value = Pacote.DataIdaPac;
                dateVolta.Value = Pacote.DatavoltaPac;

                if (Pacote.Retorno == "Não")
                {
                    tbxCodigoPacote.Text = string.Empty;
                    tbxCodigoPacote.Focus();
                    tbxCodigoPacote.SelectAll();
                    tbxCodigoPacote.Text = string.Empty;
                    tbxCodigoPacote.Text = string.Empty;

                    return;
                }
            }
        }

        private void btnBuscarImagemPacote_Click(object sender, EventArgs e)
        {
            openFileDialogPesquisarPacote.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg;*.png;.jpeg";
            if (openFileDialogPesquisarPacote.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotoPacote.Image = Image.FromFile(openFileDialogPesquisarPacote.FileName);
            }
        }

        private void btnDeletarPacote_Click(object sender, EventArgs e)
        {
            if (tbxCodigoPacote.Text == "")
            {
                MessageBox.Show("Digite o código do pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodigoPacote.Text = string.Empty;
                tbxCodigoPacote.Focus();
                tbxCodigoPacote.SelectAll();
                tbxValorPacote.Text = string.Empty;
                tbxOrigemPacote.Text = string.Empty;
                tbxDestinoPacote.Text = string.Empty;
                rtxDescricaoPacote.Text = string.Empty;
                dateIda.Text = string.Empty;
                dateVolta.Text = string.Empty;
                pictureBoxFotoPacote.Image = null;

            }
                else
                {
                    var resposta = MessageBox.Show("Deseja deletar os dados do pacote" + tbxCodigoPacote.Text + " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                    if (resposta == DialogResult.Yes)
                    {
                        Pacote.CodigoPac = Convert.ToInt32(tbxCodigoPacote.Text);

                        ManipulaPacote manipulaPacote = new ManipulaPacote();
                        manipulaPacote.deletarPacote();

                    }
                }
            }
    
        private void btnAlterarPacote_Click(object sender, EventArgs e)
        {
            if (tbxCodigoPacote.Text == "")

            {
                MessageBox.Show("Digite o código do pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodigoPacote.Text = string.Empty;
                tbxCodigoPacote.Focus();
                tbxCodigoPacote.SelectAll();
                tbxValorPacote.Text = string.Empty;
                tbxOrigemPacote.Text = string.Empty;
                tbxDestinoPacote.Text = string.Empty;
                rtxDescricaoPacote.Text = string.Empty;
                dateIda.Text = string.Empty;
                dateVolta.Text = string.Empty;
                pictureBoxFotoPacote.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do pacote" + tbxCodigoPacote.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.OK)
                {
                    Pacote.CodigoPac = Convert.ToInt32(tbxCodigoPacote.Text);
                    Pacote.ValorPac = Convert.ToDecimal(Pacote.ValorPac);
                    Pacote.OrigemPac = tbxOrigemPacote.Text;
                    Pacote.DestinoPac = tbxDestinoPacote.Text;
                    Pacote.DescricaoPac = rtxDescricaoPacote.Text;
                    Pacote.DataIdaPac = dateIda.Value;
                    Pacote.DatavoltaPac = dateVolta.Value;

                    MemoryStream ms = new MemoryStream();
                    pictureBoxFotoPacote.Image.Save(ms, pictureBoxFotoPacote.Image.RawFormat);
                    Pacote.ImagemPac = ms.ToArray();

                    ManipulaPacote manipulaPacote = new ManipulaPacote();
                    manipulaPacote.alterarPacote();
                }
            }
        }

        private void btnBucarPacoteNome_Click(object sender, EventArgs e)
        {
            if(tbxOrigemPac.Text == "") {
                MessageBox.Show("Preencha o nome do pacote", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Pacote.OrigemPac = tbxOrigemPac.Text;

            dataGridViewPacote.DataSource = ManipulaPacote.pesquisarOrigemFuncionario();

            dataGridViewPacote.Columns[0].Visible = false;
            dataGridViewPacote.Columns[1].Visible = false;
            dataGridViewPacote.Columns[2].Visible = false;
            dataGridViewPacote.Columns[3].Visible = false;
            dataGridViewPacote.Columns[4].Visible = false;
            dataGridViewPacote.Columns[5].Visible = false;
            dataGridViewPacote.Columns[6].Visible = false;
            dataGridViewPacote.Columns[7].HeaderCell.Value = "Código";
            dataGridViewPacote.Columns[8].HeaderCell.Value = "Valor";
            dataGridViewPacote.Columns[9].HeaderCell.Value = "Origem";
            dataGridViewPacote.Columns[10].HeaderCell.Value = "Destino";
            dataGridViewPacote.Columns[11].HeaderCell.Value = "Data da ida";
            dataGridViewPacote.Columns[12].HeaderCell.Value = "Data da volta";
            dataGridViewPacote.Columns[13].Visible = false;
        }

        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
            if (tbxDestinoPac.Text == "")
            {
                MessageBox.Show("Preencha o destino ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Pacote.DestinoPac = tbxDestinoPac.Text;

            dataGridViewDestinoPacote.DataSource = ManipulaPacote.pesquisarDestinoFuncionario();

            dataGridViewDestinoPacote.Columns[0].Visible = false;
            dataGridViewDestinoPacote.Columns[1].Visible = false;
            dataGridViewDestinoPacote.Columns[2].Visible = false;
            dataGridViewDestinoPacote.Columns[3].Visible = false;
            dataGridViewDestinoPacote.Columns[4].Visible = false;
            dataGridViewDestinoPacote.Columns[5].Visible = false;
            dataGridViewDestinoPacote.Columns[6].Visible = false;
            dataGridViewDestinoPacote.Columns[7].HeaderCell.Value = "Código";
            dataGridViewDestinoPacote.Columns[8].HeaderCell.Value = "Valor";
            dataGridViewDestinoPacote.Columns[9].HeaderCell.Value = "Origem";
            dataGridViewDestinoPacote.Columns[10].HeaderCell.Value = "Destino";
            dataGridViewDestinoPacote.Columns[11].HeaderCell.Value = "Data da ida";
            dataGridViewDestinoPacote.Columns[12].HeaderCell.Value = "Data da volta";
            dataGridViewDestinoPacote.Columns[13].Visible = false;
        }
    }
}
