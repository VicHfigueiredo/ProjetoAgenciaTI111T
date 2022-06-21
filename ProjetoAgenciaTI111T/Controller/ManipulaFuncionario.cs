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

        public void pesquisarCodigoFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarCodFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoFuncionario", Funcionarios.CodigoFun);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Funcionarios.CodigoFun = Convert.ToInt32(arrayDados["codigoFun"]);
                    Funcionarios.NomeFun = arrayDados["nomeFun"].ToString();
                    Funcionarios.EmailFun = arrayDados["emailFun"].ToString();
                    Funcionarios.SenhaFun = arrayDados["senhaFun"].ToString();
                    Funcionarios.Retorno = "Sim";
                }
                else {
                    MessageBox.Show("Codigo não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Funcionarios.Retorno = "Sim";

                }

            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Funcionarios.Retorno = "Não";
            }

          }
        public void deletarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoFuncionario", Funcionarios.CodigoFun);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluído com sucesso", "Exclusão");
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();

                }
            }
        }

        public void alterarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoFun", Funcionarios.CodigoFun);
                cmd.Parameters.AddWithValue("@nomeFun", Funcionarios.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionarios.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionarios.SenhaFun);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O funcionario não foi alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisarNomeFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarNomeFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeFun", Funcionarios.NomeFun);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new  SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
            
        }
    }

