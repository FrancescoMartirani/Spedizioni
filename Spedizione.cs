using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public abstract class Spedizione
    {

        protected string Destinatario;
        protected string Mittente;
        protected int Valore;

        public Spedizione(string destinatario, string mittente, int valore)
        {

            Destinatario = destinatario;
            Mittente = mittente;
            Valore = valore;

        }

        public abstract double printingombro();
        
        public bool equals(Spedizione spedizione)
        {


            return spedizione.Mittente.Equals(Mittente) &&
                spedizione.Destinatario.Equals(Destinatario) &&
                spedizione.Valore.Equals(Valore) &&
                spedizione.printingombro().Equals(printingombro());

        }

    }
}
