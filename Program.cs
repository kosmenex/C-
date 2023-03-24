using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FOR DÖNGÜSÜ: koşullu tek tek sorguya alır

            //for (int i = 0; i < length; i++)
            //{
            //Console.WriteLine(i);
            //}
            //forr ...... FOR REVERSE MANASINDA GERİYE DOĞRU DÖNDÜRÜR
            //forr snippet yardımıyla tersten sorgu yapan for bloğu geliyor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            for (int i = 101 - 1; i >= 0; i -= 10)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            // 0 dan 20ye kadar sayıların karesi alma write yanyana yazmak için kullandım
            // \n kaçış karakteriyle satırları alta kaydırdım
            for (int i = 0; i <= 20; i++)
            {
                Console.Write($"sayı={i} karesi={i * i}\n");
            }
            Console.ReadKey();

            // kullanıcıdan aldığını iki sayıyı sorgulatın

            Console.WriteLine("bir değer giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bir değer giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine("{0,3}", i);
            }
            Console.ReadKey();

            // kullanıcıdan aldığınız iki sayı aralığındaki 3ün katlarını çıkartınız
            Console.WriteLine("bir değer giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bir değer giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++) // (başlangıç, bitiş, sorgu değeri)
            {
                if (i % 3 == 0)
                {
                    continue; // devam et manasında program yeniden for bloğuna dönüp i++; okur
                }
                Console.WriteLine("{0,3}", i);
            }
            Console.ReadKey();

            // break; komutu
            Console.WriteLine("bir değer giriniz");
            Console.WriteLine("bir değer giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i == 100)
                {
                    break; // şart sağlanırsa programı bitir amacıyla kullanılıyor
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();

            // İç İçe For Döngüsü
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" * "); // iki for döngüsü her sorgu için iç içe 5 kez döndüğü için yanyana 5 tane yıldızı 25 kez alt alta yazdıracaktır

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
