using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class PromedioMovil
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string demandas;

        public string Demandas
        {
            get { return demandas; }
            set { demandas = value; }
        }

        private int evaluar;

        public int Evaluar
        {
            get { return evaluar; }
            set { evaluar = value; }
        }
        
    }
}
