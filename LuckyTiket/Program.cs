using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LuckyTiket
{
    class Program
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Tiket> tikets = new List<Tiket>();
            for (int i = 0; i < 100000; i++)
            {
                tikets.Add(new Tiket());
                tikets[i].FillTiket();
                tikets[i].LuckyChiNe();
            }

            int counter = tikets.Where(x => x.lucky == true).Count();

            if (counter > 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine("+");
                }
            }
            Console.ReadLine();
        }
    }

}

