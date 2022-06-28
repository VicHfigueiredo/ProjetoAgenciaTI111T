﻿using System;
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
    }
}
