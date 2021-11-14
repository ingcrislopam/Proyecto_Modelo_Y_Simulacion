using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class MonteCarlo
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

        private string demandas;

        public string Demandas
        {
            get { return demandas; }
            set { demandas = value; }
        }

        private string ocurrencias;

        public string Ocurrencias
        {
            get { return ocurrencias; }
            set { ocurrencias = value; }
        }
        
    }
}
