using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class PromedioMovilPronostico
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

        private int evaluarUno;

        public int EvaluarUno
        {
            get { return evaluarUno; }
            set { evaluarUno = value; }
        }

        private int evaluarDos;

        public int EvaluarDos
        {
            get { return evaluarDos; }
            set { evaluarDos = value; }
        }
        
    }
}
