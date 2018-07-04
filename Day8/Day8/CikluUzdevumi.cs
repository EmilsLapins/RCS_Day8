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
            int Sakums = Convert.ToInt16(Console.ReadLine());

            string Zvaigznite = "*";

            if (Sakums > 0)
            {
                for (int i = 1; i < Sakums + 1; i++)
                {
                    Console.WriteLine(Zvaigznite);

                    Zvaigznite = Zvaigznite + "*";

                }
            } else
            {
                Console.WriteLine("Error!");
            }

        }
      
    }
}
