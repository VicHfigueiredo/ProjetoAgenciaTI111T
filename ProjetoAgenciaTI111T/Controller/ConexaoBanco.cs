using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAgenciaTI111T.Controller

{
    class ManipulaCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarCliente",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@nomeCli");
                cmd.Parameters.AddWithValue("@emailCli");
                cmd.Parameters.AddWithValue("@senhaCli");
                cmd.Parameters.AddWithValue("@imagemCli");
            }
        }
    }
    class ConexaoBanco
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.hfigueiredo\Source\Repos\VicHfigueiredo\ProjetoAgenciaTI111T\ProjetoAgenciaTI111T\banco\bdagenciaviagem.mdf;Integrated Security=True";
        }
    }
}
