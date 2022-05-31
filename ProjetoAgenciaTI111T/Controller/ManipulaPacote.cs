using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
