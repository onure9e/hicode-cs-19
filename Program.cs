using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numberList = new ArrayList();
            int counter = 0;
            while (counter < 20)
            {
                var number = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(number) < 0)
                    {
                        Console.WriteLine("negatif sayı giremezsin");
                    }
                    else
                    {
                        numberList.Add(number);
                        counter++;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("sadece sayı girebilirsin ");
                }
            }

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                if (asalMi(Convert.ToInt32(numberList[i])))
                {
                    asalSayilar.Add(numberList[i]);
                }
                else
                {
                    asalOlmayanSayilar.Add(numberList[i]);
                }
            }

            int toplamasal = 0;
            foreach (var n in asalSayilar)
            {
                toplamasal += Convert.ToInt32(n);
            }

            int toplamasalolmayan = 0;
            foreach (var n in asalOlmayanSayilar)
            {
                toplamasalolmayan += Convert.ToInt32(n);
            }


            asalSayilar.Sort();
            asalSayilar.Reverse();
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();

            Console.Write("Asal olan sayıar: ");
            foreach (var n in asalSayilar)
            {
                Console.Write(n + " ");
            }

            System.Console.WriteLine();

            Console.Write("Asal Olmayan Sayılar:  ");
            foreach (var n in asalOlmayanSayilar)
            {
                Console.Write(n + " ");
            }

            System.Console.WriteLine();

            Console.WriteLine("Asal olan sayı adeti : " + asalSayilar.Count);
            Console.WriteLine("Asal olmayan sayı adeti : " + asalOlmayanSayilar.Count);

            int asalOlanSayilarinSayisi = asalSayilar.Count;
            int asalOlmayanSayilarinSayisi = asalOlmayanSayilar.Count;

            Console.WriteLine("Asal olan sayıların ortalaması: " + toplamasal / asalOlanSayilarinSayisi);
            Console.WriteLine("Asal olmayan sayıların ortalaması: " + toplamasalolmayan / asalOlmayanSayilarinSayisi);

        }

        static bool asalMi(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}