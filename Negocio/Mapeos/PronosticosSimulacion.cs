using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class PronosticosSimulacion
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string mesPronostico;

        public string MesPronostico
        {
            get { return mesPronostico; }
            set { mesPronostico = value; }
        }

        private string cantidadVenta;

        public string CantidadVenta
        {
            get { return cantidadVenta; }
            set { cantidadVenta = value; }
        }

        private string cobro;

        public string Cobro
        {
            get { return cobro; }
            set { cobro = value; }
        }

        private string evaluar;

        public string Evaluar
        {
            get { return evaluar; }
            set { evaluar = value; }
        }
        
    }
}
