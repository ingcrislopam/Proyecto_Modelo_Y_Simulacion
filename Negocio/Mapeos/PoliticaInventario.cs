using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class PoliticaInventario
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int distribucion;

        public int Distribucion
        {
            get { return distribucion; }
            set { distribucion = value; }
        }

        private int tiempoDeEntrega;

        public int TiempoDeEntrega
        {
            get { return tiempoDeEntrega; }
            set { tiempoDeEntrega = value; }
        }

        private int aleatorioDistribucion;

        public int AleatorioDistribucion
        {
            get { return aleatorioDistribucion; }
            set { aleatorioDistribucion = value; }
        }

        private int aleatorioTiempoDeEntrega;

        public int AleatorioTiempoDeEntrega
        {
            get { return aleatorioTiempoDeEntrega; }
            set { aleatorioTiempoDeEntrega = value; }
        }

        private string cantidadOrdenar;

        public string CantidadOrdenar
        {
            get { return cantidadOrdenar; }
            set { cantidadOrdenar = value; }
        }

        private string puntoDeReorden;

        public string PuntoDeReorden
        {
            get { return puntoDeReorden; }
            set { puntoDeReorden = value; }
        }

        private string costoPorFaltantes;

        public string CostoPorFaltantes
        {
            get { return costoPorFaltantes; }
            set { costoPorFaltantes = value; }
        }

        private string costoMantenimiento;

        public string CostoMantenimiento
        {
            get { return costoMantenimiento; }
            set { costoMantenimiento = value; }
        }

        private string costoDeOrdenar;

        public string CostoDeOrdenar
        {
            get { return costoDeOrdenar; }
            set { costoDeOrdenar = value; }
        }

        private string inventarioInicial;

        public string InventarioInicial
        {
            get { return inventarioInicial; }
            set { inventarioInicial = value; }
        }
        
    }
}
