﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI111T.Model
{
    class Clientes
    {
        private static int codigoCli;
        private static string nomeCli;
        private static string emailCli;
        private static string senhaCli;
        private static Array imagemCli;
        private static string retorno;

        public static int CodigoCli { get => codigoCli; set => codigoCli = value; }
        public static string NomeCli { get => nomeCli; set => nomeCli = value; }
        public static string EmailCli { get => emailCli; set => emailCli = value; }
        public static string SenhaCli { get => senhaCli; set => senhaCli = value; }
        public static Array ImagemCli { get => imagemCli; set => imagemCli = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }

 

}
