using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI111T.Model
{
    class Venda
    {
        private static int codigoVen;
        private static int codigoCliFK;
        private static int codigoFunFK;
        private static int codigoPacFK;
        private static int pagoVenda;
        private static string retorno;

        public static int CodigoVen { get => codigoVen; set => codigoVen = value; }
        public static int CodigoCliFK { get => codigoCliFK; set => codigoCliFK = value; }
        public static int CodigoFunFK { get => codigoFunFK; set => codigoFunFK = value; }
        public static int CodigoPacFK { get => codigoPacFK; set => codigoPacFK = value; }
        public static int PagoVenda { get => pagoVenda; set => pagoVenda = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
