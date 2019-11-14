using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacaOcjenee
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            double prosjek;
            float brojOcjena = 0; //brojac
            int zbrojOcjena = 0;
            do
            {
                Console.WriteLine("Upisite ocjenu: ");
                ocjena = Convert.ToInt32(Console.ReadLine());



                if (ocjena == 1)
                {
                    prosjek = 1;
                    break;
                }

                else if (ocjena > 5 || ocjena < 0)
                {
                    Console.WriteLine("Pogresan unos. Unesite ponovno");

                }
                else if(ocjena!=0)
                {
                    brojOcjena+=1;
                    zbrojOcjena += ocjena;
                    
                }
                prosjek = zbrojOcjena / brojOcjena;

            }
            while (ocjena != 0);
            Console.WriteLine("Prosjek ocjena je"+prosjek);
            Console.ReadKey();
        }
    }
}
