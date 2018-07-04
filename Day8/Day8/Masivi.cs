using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Masivi
    {
        public void IzvaditMasivu()
        {
            int[] piemraMasivs = new int[5]; // piecas vertibas!
            Console.WriteLine("Masivu saraksts!");
            piemraMasivs[0] = 11;
            piemraMasivs[1] = 22;
            piemraMasivs[2] = 33;
            piemraMasivs[3] = 44;
            piemraMasivs[4] = 55; // piekta vertiba!

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine(piemraMasivs[i]);
            }

            string[] stringMasivs = new string[5];

            stringMasivs[0] = "*";
            stringMasivs[1] = "**";
            stringMasivs[2] = "***";
            stringMasivs[3] = "****";
            stringMasivs[4] = "*****";


            for (int i = 0; i <5; i++)
            {
                Console.WriteLine(stringMasivs[i]);

            }

            for (int i = 4; i >= 0; i--)
            {

                Console.WriteLine(stringMasivs[i]);

            }
            // parvediot un apvienot so piemeru, ar ieprieksejo. Katra elementa vertibu pieskiram cikla!




        }
        public void MasivuUzdevums()
        {
            
            string Zvaigznite = "*";

            string[] masivsViens = new string[5]; // radam masivu, kura var ievadit 5 vertibas.

            // Bez 3 for loopiem var iztikt !
            /* for (int i = 0; i < 5; i++)  
            {
                masivsViens[i] = Zvaigznite;

                Zvaigznite = Zvaigznite + "*";
            } */

            for (int i = 0; i < 5; i++) // augusa seciba
            {
                
                masivsViens[i] = Zvaigznite;  // masivam pieksiram vertibas seit, velak izmantojam ari dilstosa seciba.

                Zvaigznite = Zvaigznite + "*";

                Console.WriteLine(masivsViens[i]);
                
            }
           
            for (int i = 4; i >= 0; i--) // dilstosa seciba
            {
                Console.WriteLine(masivsViens[i]);
            }
            
        }

    }
}
