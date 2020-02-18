using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biliard2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int leeső = LeEsőSorsoló(golyók);
            Kiíró(golyók);

           // for (int i = 0; i < golyók.Count; i++)
           // {
           //     Console.WriteLine(golyók[i]);
           // }
            Console.ReadKey();
        }

        private static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.WriteLine($"{item}");
            }
        }

        static int LeEsőSorsoló(List<int> golyók)
        {
            Random rnd = new Random();
            int szám;
            do
            {
                szám = rnd.Next(golyók.Count);
                golyók.Remove(szám);
            } while (szám != 0);
            return golyók[szám];

        }

        static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i < 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
