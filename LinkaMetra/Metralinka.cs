using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkaMetra
{
    internal class Metralinka
    {
        public string NázevLinky { get; set; }
        public bool aktivni { get; set; }
        public string[] stanice { get; set; }
        public string Barva { get; set; }   
        public void VypisStanice()
        {
            if (stanice.Length > 0)
            {
                foreach (var jednastan in stanice) 
                {
                    Console.WriteLine(jednastan);
                }
            }
        }
        public void VypisPrvniPosledni()
        {
            if (stanice.Length >= 2)
            {
                Console.WriteLine(stanice[0]);
                Console.WriteLine(stanice[stanice.Length-1]);
            }
        }
        public void nastavlinku()
        {
            if(Barva =="zelená")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (Barva == "červená")
            {
                Console.ForegroundColor= ConsoleColor.Red;
            }
            else if (Barva == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (Barva == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine($"vítej v lince metra {NázevLinky}");

        }
        public void CasCesty()
        {
            VypisStanice();
            Console.WriteLine("vyber první stanici ");
            string prvniStanice = Console.ReadLine();
            int indexPrvni = Array.IndexOf(stanice, prvniStanice);
            Console.WriteLine("-------");

            Console.WriteLine("vyberou druhou stanici ");
            string druhastanice = Console.ReadLine();
            int indexdruhe = Array.IndexOf(stanice, druhastanice);
            Console.WriteLine("--------");
            int dobacesty = (indexPrvni + indexdruhe)*2;
            Console.WriteLine("doba cesty "+ dobacesty);
        }


    }
}
