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

            while (Choice != 0) {
                Console.WriteLine("Izveleties uzdevumu- 1 vai 2 (0: Iziet!)");

                Choice = Convert.ToInt16(Console.ReadLine());

                switch (Choice)
                {
                    case 0:

                        break;

                    case 1:

                        CikluUzd.Zvaigznite();

                        break;
                    case 2:
                        Console.WriteLine("Placeholder");

                        break;

                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;
                }
            }
        }
    }
}
