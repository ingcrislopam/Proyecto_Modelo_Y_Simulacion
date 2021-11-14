using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class LineaEsperaUnCanal
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int idLlegada;

        public int IdLlegada
        {
            get { return idLlegada; }
            set { idLlegada = value; }
        }

        private int idServicio;

        public int IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }

        private string mediaTiempoEntreLLegada;
        
        public string MediaTiempoEntreLlegada
        {
            get { return mediaTiempoEntreLLegada; }
            set { mediaTiempoEntreLLegada = value; }
        }

        private string mediaTiempoDeServicio;

        public string MediaTiempoDeServicio
        {
            get { return mediaTiempoDeServicio; }
            set { mediaTiempoDeServicio = value; }
        }
        
    }
}
