using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class Aleatoria
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private Congruencial idCongruencial;

        public Congruencial IdCongruencial
        {
            get { return idCongruencial; }
            set { idCongruencial = value; }
        }

        private string primerParametro;

        public string PrimerParametro
        {
            get { return primerParametro; }
            set { primerParametro = value; }
        }

        private string segundaParametro;

        public string SegundoParametro
        {
            get { return segundaParametro; }
            set { segundaParametro = value; }
        }

        private string funcion;

        public string Funcion
        {
            get { return funcion; }
            set { funcion = value; }
        }

    }
}
