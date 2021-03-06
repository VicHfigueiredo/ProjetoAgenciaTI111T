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

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoPac", SqlDbType.Int);
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

        public void pesquisarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPac", Pacote.CodigoPac);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Pacote.CodigoPac = Convert.ToInt32(arrayDados["codigoPac"]);
                    Pacote.ValorPac = Convert.ToDecimal(arrayDados["valorPac"]);
                    Pacote.OrigemPac = arrayDados["origemPac"].ToString();
                    Pacote.DestinoPac = arrayDados["destinoPac"].ToString();
                    Pacote.DataIdaPac = Convert.ToDateTime(arrayDados["dataidaPac"]);
                    Pacote.DatavoltaPac = Convert.ToDateTime(arrayDados["datavoltaPac"]);
                    Pacote.DescricaoPac = arrayDados["descricaoPac"].ToString();
                    Pacote.ImagemPac = (System.Array)arrayDados["imagemPac"];
                    Pacote.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Codigo não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Funcionarios.Retorno = "Não";
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoPac", Pacote.CodigoPac);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote excluído com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception)
            {
                MessageBox.Show("O pacote não pode ser excluído", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoPac", Pacote.CodigoPac);
                cmd.Parameters.AddWithValue("@valorPac", Pacote.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
                cmd.Parameters.AddWithValue("@dataidaPac", Pacote.DataIdaPac);
                cmd.Parameters.AddWithValue("@datavoltaPac", Pacote.DatavoltaPac);
                cmd.Parameters.AddWithValue("@descricaoPac", Pacote.DescricaoPac);
                cmd.Parameters.AddWithValue("@imagemPac", Pacote.ImagemPac);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisarOrigemFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaOrigemPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
        public static BindingSource pesquisarDestinoFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaDestinoPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }

    }
}
