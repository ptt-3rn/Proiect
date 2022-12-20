using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_interviu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numarMaximArticole = 0;
            double greutateMaxima = 0;
            double volumMaxim = 0;
            bool rezultatAlegere = true;
            bool runLoop = true;
            Ghiozdan ghiozdan = null;

            Console.WriteLine("Configurati ghiozdanul:\n");

            while (runLoop)
            {
                Console.Write("Introduceti numarul maxim de articole: ");

                try
                {
                    numarMaximArticole = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare in valoarea introdusa: " + ex.Message);
                    Console.WriteLine("Incercati din nou.");
                    continue;
                }

                Console.Write("Introduceti greutatea maxima: ");
                try
                {
                    greutateMaxima = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare in valoarea introdusa: " + ex.Message);
                    Console.WriteLine("Incercati din nou.");
                    continue;
                }

                Console.Write("Volum maxim: ");
                try
                {
                    volumMaxim = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare in valoarea introdusa: " + ex.Message);
                    Console.WriteLine("Incercati din nou.");
                    continue;
                }

                ghiozdan = new Ghiozdan(numarMaximArticole, greutateMaxima, volumMaxim);

                runLoop = false;
            } 

            while (rezultatAlegere)
            {
                int alegere = 0;
                Console.WriteLine("\nIntroduceti un numar pentru a adauga articol in ghiozdan.");
                Console.WriteLine("1. Sageata\n2. Arc\n3. Franghie.\n4. Apa " +
                    "\n5. Portie de mancare \n6. Sabie \n7. Inchide aplicatie.");
                
                try
                {
                    alegere = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Eroare: " + ex.Message);
                    Console.WriteLine("Incercati din nou.");
                    continue;
                }

                if(alegere < 1 || alegere > 7)
                {
                    Console.WriteLine("Eroare: Numarul introdus nu este de la 1 la 7.");
                    Console.WriteLine("Incercati din nou.");
                    continue;
                }

                switch (alegere)
                {
                    case 1:
                        rezultatAlegere = ghiozdan.Adauga(new Sageata());
                        break;
                    case 2:
                        rezultatAlegere = ghiozdan.Adauga(new Arc());
                        break;
                    case 3:
                        rezultatAlegere = ghiozdan.Adauga(new Franghie());
                        break;
                    case 4:
                        rezultatAlegere = ghiozdan.Adauga(new Apa());
                        break;
                    case 5:
                        rezultatAlegere = ghiozdan.Adauga(new PortieMancare());
                        break;
                    case 6:
                        rezultatAlegere = ghiozdan.Adauga(new Sabie());
                        break;
                    case 7:
                        Console.WriteLine("Aplicatie inchisa.");
                        Console.ReadKey();
                        return;
                }
                if(rezultatAlegere == true)
                {
                    Console.WriteLine("Articolul a fost introdus cu succes.");
                }
            };

            if(rezultatAlegere == false)
            {
                Console.WriteLine("Ghiozdanul este plin.");
                Console.ReadKey();
            }

        }

    }
}
