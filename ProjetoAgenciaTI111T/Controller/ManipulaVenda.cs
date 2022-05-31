using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAgenciaTI111T.Controller
{
    class ManipulaVenda
    {
        public void cadastrarVenda()
        {


            SqlConnection cn = new SqlConnection(ConexaoBanco());
            SqlCommand cmd = new SqlCommand("pCadastrarVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try {
                cmd.Parameters.AddWithValue("@codigoCliFK", "");
                cmd.Parameters.AddWithValue("@codigoFunFK", "");
                cmd.Parameters.AddWithValue("@codigoPacFK", "");
                cmd.Parameters.AddWithValue("@pagoVen", "");

            }
            catch (Exception)
            {
                throw;
            }
              
    }

        private string ConexaoBanco()
        {
            throw new NotImplementedException();
        }
    }
}

