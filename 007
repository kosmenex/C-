using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  WHİLE DÖNGÜSÜ ÖRNEKLER

            // 1. EKRANA 10'A KADAR YAZDIR

            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();

            // 2. EKRANA 10'DAN 0'A KADAR YAZDIR
            int j = 10;
            while (j >= 0)
            {
                Console.WriteLine(j);
                j--;
            }
            Console.ReadKey();

            // 3. 0'DAN 100'E KADAR TEK VE ÇİFT OLARAK YAZDIR

            int a = 0;
            while (a <= 100)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine($"çift sayı={a}");
                }
                else
                {
                    Console.WriteLine($"tek sayı={a}");
                }
                a++;
            }
            //Console.ReadKey();

            //4. A’dan Z’ye kadar while döngüsü ile ekrana yazan C# programı

            char harf = 'A'; // string veri türünde kıyaslama yapamıyor onun için char denedik
            while (harf < 'Z')
            {
                Console.WriteLine(harf);
                harf++;
            }
            Console.ReadKey();

            //Kullanıcıdan ürün adedi isteyiniz.Bu ürün adedi kadar yine kullanıcıdan fiyat bilgisi alınız.
            //Alınan her fiyatı sepet tutarı olarak ekraana yazdırınız.
            int i = 0;
            int toplam = 0;
            Console.WriteLine("ürün adedi giriniz");
            int adet = Convert.ToInt32(Console.ReadLine());
            while (i <= adet)
            {
                Console.WriteLine($"{i}'nin fiyatını giriniz");
                int fiyat = Convert.ToInt32(Console.ReadLine());
                toplam += fiyat;
                i++;
            }
            Console.WriteLine($"sepet toplam={toplam}");
            Console.ReadKey();

            // RASTGELE SAYILARLA 3 HAK ŞİFRE GİRME
            Random rnd =new Random();
            Console.WriteLine("şifre giriniz"); // tek haneli kontrol sağlar
            int sifre=Convert.ToInt32(Console.ReadLine());
            int hak = 0;
            while (true)
            {
                hak++;
                int cozucu=rnd.Next(0,5);
                if (cozucu==sifre)
                {
                    break;
                }
                Console.WriteLine(cozucu);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine($"şifreniz={sifre} {hak} denemedde çözüldü");
            Console.ReadKey();





























        }
    }
}
