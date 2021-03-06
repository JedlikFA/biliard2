﻿using System;
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
            int leeső;
            do
            {
                leeső = LeEsőSorsoló(golyók);
                Kiíró(golyók);
                Console.WriteLine(leeső);
            } while (leeső!=8);

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
                Console.Write($"{item}");
            }
        }

        static int LeEsőSorsoló(List<int> golyók)
        {
            Random rnd = new Random();
            int szám;
            szám = rnd.Next(golyók.Count);
            golyók.Remove(szám);
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
