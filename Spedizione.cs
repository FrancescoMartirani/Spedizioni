using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public abstract class Spedizione
    {

        protected string destinatario;
        protected string mittente;
        protected int valore;

        public Spedizione(string d, string m, int v)
        {

            destinatario = d;
            mittente = m;
            valore = v;

        }

        public abstract double printingombro();
        
        public bool equals(Spedizione x)
        {


            return x.Equals(this);

        }

    }
}
