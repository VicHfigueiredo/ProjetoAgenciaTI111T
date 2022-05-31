using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAgenciaTI111T.Controller

{
    
    class ConexaoBanco
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.hfigueiredo\source\repos\VicHfigueiredo\ProjetoAgenciaTI111T\ProjetoAgenciaTI111T\banco\bdagenciaviagem.mdf;Integrated Security=True";
        }
    }
}
