using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL.DAL
{
    public class PuntoDeCargaDAL
    {
        private static List<PuntoDeCarga> puntoDeCargas = new List<PuntoDeCarga>();

        public void Add(PuntoDeCarga p)
        {
            puntoDeCargas.Add(p);
        }
        public List<PuntoDeCarga> GetAll()
        {
            return puntoDeCargas;
        }
        public List<PuntoDeCarga>GetAll(int numeroPunto)
        {
            return puntoDeCargas.FindAll(c => c.NumeroPuntoDeCarga == numeroPunto);
        }
        public void Remove(int numeroPunto)
        {
            PuntoDeCarga ptoCarga = puntoDeCargas.Find(c => c.NumeroPuntoDeCarga == numeroPunto);
            puntoDeCargas.Remove(ptoCarga);
        }
    }
}
