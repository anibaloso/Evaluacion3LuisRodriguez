using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL.DAL
{
    public class TipoEstacionesDAL
    {
        public static List<TipoEstacion> tipoEstaciones = new List<TipoEstacion>()
        {
            new TipoEstacion()
            {
               NombreTipo  = "Electrica"
            },
            new TipoEstacion()
            {
               NombreTipo  = "Bencina"
            }
        };

        public List<TipoEstacion> GetAll()
        {
            return tipoEstaciones;
        }
    }
}
