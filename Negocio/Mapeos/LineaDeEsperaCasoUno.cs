using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class LineaDeEsperaCasoUno
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int llegada;

        public int Llegada
        {
            get { return llegada; }
            set { llegada = value; }
        }

        private int servicio;

        public int Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }

        private string tiempoEntreLlegada;

        public string TiempoEntreLlegada
        {
            get { return tiempoEntreLlegada; }
            set { tiempoEntreLlegada = value; }
        }

        private string tiempoDeServicio;

        public string TiempoDeServicio
        {
            get { return tiempoDeServicio; }
            set { tiempoDeServicio = value; }
        }
        
    }
}
