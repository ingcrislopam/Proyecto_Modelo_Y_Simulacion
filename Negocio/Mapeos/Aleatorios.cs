using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class Aleatorios
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string cadenaAleatorios;

        public string CadenaAleatorios
        {
            get { return cadenaAleatorios; }
            set { cadenaAleatorios = value; }
        }
        
    }
}
