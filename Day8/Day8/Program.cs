using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch un case izvelni!!!
            CikluUzdevumi CikluUzd = new CikluUzdevumi();
            int Choice = 1;
            Masivi masivs1 = new Masivi();


            while (Choice != 0) {
                Console.WriteLine("Izveleties uzdevumu- 1: Zvaigznites 2: Massivi 3: MasivuEglite (0: Iziet!)");

                Choice = Convert.ToInt16(Console.ReadLine());

                switch (Choice)
                {
                    case 0:

                        break;

                    case 1:

                        CikluUzd.Zvaigznite();

                        break;
                    case 2:
                        
                        masivs1.IzvaditMasivu();

                        break;
                    case 3:

                        masivs1.MasivuUzdevums();

                        break;

                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;
                }
            }



        }
    }
}
