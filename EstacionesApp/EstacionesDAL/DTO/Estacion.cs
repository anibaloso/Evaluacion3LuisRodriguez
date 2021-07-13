using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL
{
    public class Estacion
    {
        private int numeroEstacion;
        private String direccion;
        private String tipo;
        private String region;

        public int NumeroEstacion { get => numeroEstacion; set => numeroEstacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Region { get => region; set => region = value; }
    }
}
