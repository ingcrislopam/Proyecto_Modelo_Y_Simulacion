using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class LineaDeEsperaCasoDos
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int tiempoEntreLlegada;

        public int TiempoEntreLlegada
        {
            get { return tiempoEntreLlegada; }
            set { tiempoEntreLlegada = value; }
        }

        private int tiempoDeServicio;

        public int TiempoDeServicio
        {
            get { return tiempoDeServicio; }
            set { tiempoDeServicio = value; }
        }

        private int aleatorioEntrada;

        public int AleatorioEntrada
        {
            get { return aleatorioEntrada; }
            set { aleatorioEntrada = value; }
        }

        private int aleatorioServicio;

        public int AleatorioServicio
        {
            get { return aleatorioServicio; }
            set { aleatorioServicio = value; }
        }
        
    }
}
