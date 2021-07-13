using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL
{
    public class PuntoDeCarga
    {
        private int numeroPuntoDeCarga;
        private String encargado;
        private String tipo;
        private String region;

        public int NumeroPuntoDeCarga { get => numeroPuntoDeCarga; set => numeroPuntoDeCarga = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Region { get => region; set => region = value; }
    }
}
