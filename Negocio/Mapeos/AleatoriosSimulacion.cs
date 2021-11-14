using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class AleatoriosSimulacion
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string mes;

        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        private string cantidad;

        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private string cobro;

        public string Cobro
        {
            get { return cobro; }
            set { cobro = value; }
        }
    }
}
