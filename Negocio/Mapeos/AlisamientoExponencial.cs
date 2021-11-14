using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class AlisamientoExponencial
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string alfa;

        public string Alfa
        {
            get { return alfa; }
            set { alfa = value; }
        }

        private string demandas;

        public string Demandas
        {
            get { return demandas; }
            set { demandas = value; }
        }

        private string nuevasDemandas;

        public string NuevasDemandas
        {
            get { return nuevasDemandas; }
            set { nuevasDemandas = value; }
        }
        
    }
}
