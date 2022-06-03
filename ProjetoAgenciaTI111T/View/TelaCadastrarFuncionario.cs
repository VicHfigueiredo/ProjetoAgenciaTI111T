using ProjetoAgenciaTI111T.Controller;
using ProjetoAgenciaTI111T.Model;
using System;
using System.Windows.Forms;



namespace ProjetoAgenciaTI111T.View
{
    public partial class TelaCadastrarFuncionario : Form
    {
        public TelaCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void TelaCadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxNomeFuncionario.Text == "" | tbxEmailFuncionario.Text == "" | tbxSenhaFuncionario.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Funcionarios.NomeFun = tbxNomeFuncionario.Text;
                Funcionarios.EmailFun = tbxEmailFuncionario.Text;
                Funcionarios.SenhaFun = tbxSenhaFuncionario.Text;

                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.cadastrarFuncionario();
            

                if (Funcionarios.Retorno == "Sim")
                {
                    limparTela();
                    return;
                }

                if (Funcionarios.Retorno == "Não")
                {
                    fecharCadastro();
                    return;
                }

            }
        }

        private void TelaCadastrarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == 27)
                {
                    limparTela();
                }
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

    }

}
