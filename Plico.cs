using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    class Plico : Spedizione
    {

        int altezza { get; set; }
        int lunghezza { get; set; }

        public Plico(int a, int l, string destinatario, string mittente, int valore) : base (destinatario, mittente, valore)
        {

            altezza = a;
            lunghezza = l;

        }

        public override double printingombro() => altezza * lunghezza;

    }
}
