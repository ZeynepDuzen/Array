using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = {10,20,30,40,50};
            //Console.WriteLine(sayilar[4]);

            //for (int i= 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //************************************

            //string[] sehirler = {"Istanbul","Ankara","Bursa","Antalya","Erzurum"};

            //Console.WriteLine(sehirler[2]);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}
            //************************************


            //int[] sayilar = {10,20,30,40,50,60,70,80,90};

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 20 == 0 && sayilar[i] % 30 == 0) 
            //    {
            //       Console.WriteLine(sayilar[i]);
            //    }
            //}
            //**************************************


            //string[] isimler = {"Zeynep","Cankus","Serhat"};

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //Console.WriteLine(isimler.Length);
            //**************************************


            int[] sayilar = { 10, 20, 30, 40, 50 };

            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
                Console.WriteLine("Satir satir toplam deger : " + toplam);
            }
            Console.WriteLine("Toplam : " + toplam);







            Console.Read();
        }
    }
}
