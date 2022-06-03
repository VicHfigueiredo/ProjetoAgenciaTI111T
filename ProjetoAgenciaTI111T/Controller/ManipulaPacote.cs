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
                cmd.Parameters.AddWithValue("@valorPac",Pacote.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac",Pacote.DestinoPac );
                cmd.Parameters.AddWithValue("@dataidaPac",Pacote.DataIdaPac );
                cmd.Parameters.AddWithValue("@dataVoltaPac",Pacote.DatavoltaPac );
                cmd.Parameters.AddWithValue("@descricaoPac",Pacote.DescricaoPac );
                cmd.Parameters.AddWithValue("@imagemPac",Pacote.ImagemPac );

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro Efetuado", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
