using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesDAL.DAL
{
    public class RegionesDAL
    {
        public static List<Region> regiones = new List<Region>()
        {
            new Region()
            {
                RegionTxt="Valparaiso"
            },
            new Region()
            {
                RegionTxt="Arica y parinacota"
            },
            new Region()
            {
                RegionTxt="Santiago"
            },
            new Region()
            {
                RegionTxt="Iquique"
            }
        };

        public List<Region> GetAll()
        {
            return regiones;
        }
    }
}
