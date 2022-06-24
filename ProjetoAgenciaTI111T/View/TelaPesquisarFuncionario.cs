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
    public partial class TelaPesquisarFuncionario : Form
    {
        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxCodigoFuncionario.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodigoFuncionario.Text = string.Empty;
                tbxCodigoFuncionario.Focus();
                tbxCodigoFuncionario.SelectAll();
                tbxCodigoFuncionario.Text = string.Empty;
                tbxCodigoFuncionario.Text = string.Empty;
            }
            else
            {
                Funcionarios.CodigoFun = Convert.ToInt32(tbxCodigoFuncionario.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFuncionario();

                tbxCodigoFuncionario.Text = Funcionarios.CodigoFun.ToString();
                tbxNomeFuncionario.Text = Funcionarios.NomeFun;
                tbxSenhaFuncionario.Text = Funcionarios.SenhaFun;
                tbxEmailFuncionario.Text = Funcionarios.EmailFun;

                if (Funcionarios.Retorno == "Não")
                {
                    tbxCodigoFuncionario.Text = string.Empty;
                    tbxCodigoFuncionario.Focus();
                    tbxCodigoFuncionario.SelectAll();
                    tbxCodigoFuncionario.Text = string.Empty;
                    tbxCodigoFuncionario.Text = string.Empty;
             
                    return;
                }
            }
        }
    }
}