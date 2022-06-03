using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProjetoAgenciaTI111T.Model;
using System.Windows.Forms;

namespace ProjetoAgenciaTI111T.Controller
{
    class ManipulaFuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", Funcionarios.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionarios.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionarios.SenhaFun);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoFun",SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de cliente efetuado com sucesso, deseja efetuar um novo registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resposta == DialogResult.Yes)
                {
                    Funcionarios.Retorno = "Sim";
                    return;
                }
            else
                {
                    Funcionarios.Retorno = "Não";
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
