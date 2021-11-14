using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mapeos
{
    public class Exponencial
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private Congruencial idCongruencial;

        public Congruencial IDCongruencial
        {
            get { return idCongruencial; }
            set { idCongruencial = value; }
        }

        private double landa;

        public double Landa
        {
            get { return landa; }
            set { landa = value; }
        }
        
    }
}
