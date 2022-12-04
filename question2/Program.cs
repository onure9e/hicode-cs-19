using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            ArrayList numberList = new ArrayList(); 
            for (int i = 0; i < 20; i++)
            {
                number = int.Parse(Console.ReadLine());
                numberList.Add(number);
            }
            numberList.Sort();
            ArrayList lowNumbers = new ArrayList();
            ArrayList highNumbers = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                lowNumbers.Add(numberList[i]);
            }
            for (int i = 17; i < 20; i++)
            {
                highNumbers.Add(numberList[i]);
            }

            int totalhigh = 0;
            Console.Write("en 3 büyük sayı: ");
            foreach (var item in highNumbers)
            {
                Console.Write(item + " ");
                totalhigh += Convert.ToInt32(item);
            }
            int highavarage = totalhigh/3;
            
            Console.WriteLine();

            int totallow = 0;
            Console.Write("En 3 küçük sayı: ");
            foreach (var item in lowNumbers)
            {
                Console.Write(item+" ");
                totallow += Convert.ToInt32(item);
            }
            int lowavarage = totallow/3;

            Console.WriteLine();

            Console.WriteLine("En büyük 3 sayının toplamı : "+totalhigh);
            Console.WriteLine("En küçük 3 asyının toplamı : " + totallow);
            Console.WriteLine("ortalama en büyük sayı : " + highavarage);
            Console.WriteLine("ortalama en küçük sayı :"+lowavarage);

        }
    }
}