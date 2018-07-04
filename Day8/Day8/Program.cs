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
            Console.WriteLine("Izveleties uzdevumu- 1 vai 2 ");
            string choice = Console.ReadLine();
            int ch = Convert.ToInt16(choice);

            CikluUzdevumi CikUzd = new CikluUzdevumi();


            switch (ch)
            {
                case 1:
                    CikUzd.Zvaigznite();

                    break;
                case 2:
                    
                    break;
              

                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;
            }
            Console.ReadLine();


        }
    }
}
