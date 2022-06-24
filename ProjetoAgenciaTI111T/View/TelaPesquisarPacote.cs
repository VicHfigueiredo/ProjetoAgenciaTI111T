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
                tbxOrigemPacote.Text = Pacote.OrigemPac;
                tbxDestinoPacote.Text = Pacote.DestinoPac;
                rtxDescricaoPacote.Text = Pacote.DescricaoPac;

                if (Funcionarios.Retorno == "Não")
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
    }
}