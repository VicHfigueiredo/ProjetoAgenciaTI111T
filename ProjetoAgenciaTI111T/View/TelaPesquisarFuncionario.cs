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

        private void tbxDeletarFuncionario_Click(object sender, EventArgs e)
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
                var resposta = MessageBox.Show("Deseja excluir o funcionário" + tbxCodigoFuncionario + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if(resposta == DialogResult.Yes)
                {
                    Funcionarios.CodigoFun = Convert.ToInt32(tbxCodigoFuncionario.Text);

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.deletarFuncionario();
                }
            }
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            if(tbxCodigoFuncionario.Text == "")
            {
                MessageBox.Show("Digite o código do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodigoFuncionario.Text = string.Empty;
                tbxCodigoFuncionario.Focus();
                tbxCodigoFuncionario.SelectAll();
                tbxNomeFuncionario.Text = string.Empty;
                tbxEmailFuncionario.Text = string.Empty;
                tbxSenhaFuncionario.Text = string.Empty;

            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do funcionário" + tbxNomeFuncionario + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if(resposta == DialogResult.Yes)
                {
                    Funcionarios.CodigoFun = Convert.ToInt32(tbxCodigoFuncionario.Text);
                    Funcionarios.NomeFun = tbxNomeFuncionario.Text;
                    Funcionarios.EmailFun = tbxEmailFuncionario.Text;
                    Funcionarios.SenhaFun = tbxSenhaFun.Text;

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.alterarFuncionario();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(tbxNomeFun.Text == "")
            {
                MessageBox.Show("Preencha com o código do funcionário", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            

            Funcionarios.NomeFun = tbxNomeFun.Text;

            dataGridViewFuncionario.DataSource = ManipulaFuncionario.pesquisarNomeFuncionario();

            dataGridViewFuncionario.Columns[0].Visible = false;
            dataGridViewFuncionario.Columns[1].Visible = false;
            dataGridViewFuncionario.Columns[2].Visible = false;
            dataGridViewFuncionario.Columns[3].HeaderCell.Value = "Código";
            dataGridViewFuncionario.Columns[4].HeaderCell.Value = "Nome";
            dataGridViewFuncionario.Columns[5].HeaderCell.Value = "Email";
            dataGridViewFuncionario.Columns[6].Visible = false;


        }
    }
}
