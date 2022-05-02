namespace Spedizioni
{
    public class Pacco : Spedizione
    {

        public int altezza { get; set; }
        public int lunghezza { get; set; }
        public int profondità { get; set; }

        public Pacco(int h, int l, int p, string destinatario, string mittente, int valore) : base (destinatario, mittente, valore)
        {

            altezza = h;
            lunghezza = l;
            profondità = p;

        }

        public override double printingombro() => altezza*lunghezza*profondità;

    }
}
