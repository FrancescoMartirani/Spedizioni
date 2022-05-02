﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public class Corriere
    {

        public string nome { get; set; }
        List <Spedizione> spedizioni;

        public Corriere (String nomeCorriere,List <Spedizione> sped)
        {

            nome = nomeCorriere;
            spedizioni = sped;

        }

        public double ingombroTotale()
        {

            double tot = 0;

            for (int i = 0; i < spedizioni.Count; i++)
            {

                tot = tot + spedizioni[i].printingombro();

            }

            return tot;

        }

        public void getLista()
        {

            for (int i = 0; i < spedizioni.Count; i++)
            {

                Console.WriteLine(spedizioni[i]);

            }

        }

        public void aggiungiSpedizione(Spedizione x)
        {

            spedizioni.Add(x);

        }


    }
}
