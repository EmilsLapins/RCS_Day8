using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class CikluUzdevumi
    {

        // cik reizu cikls iet cauri ar console.Readline()
        //Kludas pazinojums, ja skaitlis ir 0 vai negativs!
        /* 
         * *
         * * *
         * * * *
         * utt
         */
        public void Zvaigznite()
        {
            Console.WriteLine("Ludzu ievadiet skaitli!");
            int Robeza = Convert.ToInt16(Console.ReadLine());

            string Zvaigznite = "*";

            if (Robeza <= 0)
            {
                Console.WriteLine("Kludaina ievade!");

            }
            else
            {

                for (int i = 0; i < Robeza; i++)
                {


                    Console.WriteLine(Zvaigznite);
                    Zvaigznite = Zvaigznite + "*";



                }
            }
            
            


        }

    }
}
