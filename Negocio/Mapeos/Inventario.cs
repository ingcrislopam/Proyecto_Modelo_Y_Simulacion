using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class Inventario
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int idDistribucion;

        public int IdDistribucion
        {
            get { return idDistribucion; }
            set { idDistribucion = value; }
        }

        private int idTiempo;

        public int IdTiempo
        {
            get { return idTiempo; }
            set { idTiempo = value; }
        }

        private int idDistribucionM;

        public int IdDistribucionM
        {
            get { return idDistribucionM; }
            set { idDistribucionM = value; }
        }

        private int idTiempoM;

        public int IdTiempoM
        {
            get { return idTiempoM; }
            set { idTiempoM = value; }
        }

        private string cantidadOrdenar;

        public string CantidadOrdenar
        {
            get { return cantidadOrdenar; }
            set { cantidadOrdenar = value; }
        }

        private string puntoReorden;

        public string PuntoReorden
        {
            get { return puntoReorden; }
            set { puntoReorden = value; }
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

        private string costoOrdenar;

        public string CostoOrdenar
        {
            get { return costoOrdenar; }
            set { costoOrdenar = value; }
        }

        private string inventarioInicial;

        public string InventarioInicial
        {
            get { return inventarioInicial; }
            set { inventarioInicial = value; }
        }
        
    }
}
