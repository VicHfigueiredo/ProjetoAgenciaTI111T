using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProjetoAgenciaTI111T.Model;
using ProjetoAgenciaTI111T.Controller;
using System.IO;
using System.Windows.Forms;


namespace ProjetoAgenciaTI111T.Controller
{
    class ManipulaVenda
    {
        public void cadastrarVenda()
        {


            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try {
                cmd.Parameters.AddWithValue("@pagoVen", Venda.PagoVenda);
                cmd.Parameters.AddWithValue("@codigoCliFK", Clientes.CodigoCli);
                cmd.Parameters.AddWithValue("@codigoFunFK",Funcionarios.CodigoFun );
                cmd.Parameters.AddWithValue("@codigoPacFK", Pacote.CodigoPac);
                

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoVen", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do Venda efetuado com sucesso, deseja efetuar um novo registro?",
                                 "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                                 );

                if (resposta == DialogResult.Yes)
                {
                    Venda.Retorno = "Sim";
                    return;
                }
                else
                {
                    Venda.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }

        }

    }
}

