using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ProjetoAgenciaTI111T.Model;

namespace ProjetoAgenciaTI111T.Controller
{
    class ManipulaPacote
    {
        public void cadastrarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac","");
                cmd.Parameters.AddWithValue("@origemPac", "");
                cmd.Parameters.AddWithValue("@destinoPac", "");
                cmd.Parameters.AddWithValue("@dataidaPac", "");
                cmd.Parameters.AddWithValue("@dataVoltaPac", "");
                cmd.Parameters.AddWithValue("@descricaoPac", "");
                cmd.Parameters.AddWithValue("@imagemPac", "");

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do pacote efetuado com sucesso, deseja efetuar um novo registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    Pacote.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacote.Retorno = "Não";
                }
            
            }
            catch
            {
                
            }
        }
    }
}
