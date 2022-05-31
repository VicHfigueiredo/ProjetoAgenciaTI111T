using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI111T.Model
{
    class Pacote
    {
        private static int codigoPac;
        private static string valorPac;
        private static string origemPac;
        private static string destinoPac;
        private static DateTime dataPacote;
        private static DateTime dataIdaPac;
        private static DateTime datavoltaPac;
        private static string descricaoPac;
        private static Array imagemPac;

        public static int CodigoPac { get => codigoPac; set => codigoPac = value; }
        public static string ValorPac { get => valorPac; set => valorPac = value; }
        public static string OrigemPac { get => origemPac; set => origemPac = value; }
        public static string DestinoPac { get => destinoPac; set => destinoPac = value; }
        public static DateTime DataPacote { get => dataPacote; set => dataPacote = value; }
        public static DateTime DataIdaPac { get => dataIdaPac; set => dataIdaPac = value; }
        public static DateTime DatavoltaPac { get => datavoltaPac; set => datavoltaPac = value; }
        public static string DescricaoPac { get => descricaoPac; set => descricaoPac = value; }
        public static Array ImagemPac { get => imagemPac; set => imagemPac = value; }
    }
}
