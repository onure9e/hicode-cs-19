using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution of third question
            Console.WriteLine("> cümle girin: ");
            string cümle = Console.ReadLine();
            cümle.ToLower();

            string harfler = "ıiuüoöae";

            int cümleUzunluğu = cümle.Count();

            List<char> harfListesi = new List<char>();
            for (int i = 0; i < cümleUzunluğu; i++)
            {
                if (harfler.Contains(cümle[i]))
                {
                    if (!harfListesi.Contains(cümle[i]))
                    {
                        harfListesi.Add(cümle[i]);
                    }
                 
                }
            }

            Console.Write("Bu cümledeki sesli harfler:  ");
            foreach (var n in harfListesi)
            {
                Console.Write(n+", ");
            }


        }
    }
}