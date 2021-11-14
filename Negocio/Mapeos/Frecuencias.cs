using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class Frecuencias
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        private string cadenaDemandas;

        public string CadenaDemandas
        {
            get { return cadenaDemandas; }
            set { cadenaDemandas = value; }
        }

        private string cadenaProbabilidad;

        public string CadenaProbabilidad
        {
            get { return cadenaProbabilidad; }
            set { cadenaProbabilidad = value; }
        }
        
    }
}
