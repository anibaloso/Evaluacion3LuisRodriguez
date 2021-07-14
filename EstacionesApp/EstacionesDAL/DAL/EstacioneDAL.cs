using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacioneDAL.DAL
{
    public class EstacioneDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();

        public void Add(Estacion estacion)
        {
            estaciones.Add(estacion);
        }

        public List<Estacion> GetAll()
        {
            return estaciones;
        }

        public void Remove(int numeroEstacion)
        {
            Estacion estacion = estaciones.Find(c => c.NumeroEstacion == numeroEstacion);
            estaciones.Remove(estacion);
        }
    }
}
