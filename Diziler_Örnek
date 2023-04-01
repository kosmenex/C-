using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diziler_Örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi: bellekte aynı tipteki veri grubunun tutulmasını sağlar
            int[] sayı = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(sayı); // sayı dizisinin veri tipi system.keyınfo olarak veriyor
            for (int i = 0; i < sayı.Length; i++)
            {
                Console.WriteLine(sayı[i]); // bu yapı ile diiz içerisindeki verileri döndürüyoruz
            }

            //Örnek 1: Eleman sayısını kullanıcının belirlediği bir dizi oluşturarak içine kullanıcının eleman girmesini sağlayan örnek

            Console.WriteLine("eleman sayısı giriniz:");
            int mevcut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[mevcut];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Nci Öğrencinin adı=");
                Console.ReadLine();


            }
            Console.ReadKey();


            //Örnek 2: 10 personele ait numara,isim,telefon ve email bilgileri ayrı ayrı dizilerde tutan ve 
            //    aranan numaraya göre ilgili kişinin bilgilerini ekranda gösteren dizi örneği(indexOf kullanıldı) :


            int[] numara = new int[10];
            string[] isim = new string[] { "kübra", "ayşe", "fatma", "hayriye", "yiğitali", "emine", "büşra", "süleyman", "ahmet", "nurullah" };
            string[] telefon = new string[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110" };
            string[] mail = new string[] { "kk@mail", "aa@mail", "bb@mail", "cc@mail", "dd@mail", "ee@mail", "cc@mail", "gg@mail", "ii@mail", "oo@mail" };


            for (int i = 0; i < numara.Length; i++)
            {

                Console.WriteLine($"{i + 1}.ci öğrenci={isim[i]}");
                Console.WriteLine($"{i + 1}.ci {isim[i]}'nin bilgileri yükleniyor");
                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(500);
                    Console.Write(".");
                }
                Console.WriteLine
                    (
                    $"\n" +
                    $"isim={isim[i]}\n" +
                    $"telefon={telefon[i]}\n" +
                    $"mail={mail[i]}"
                    );

                Console.ReadLine();

            }
            Console.ReadKey();

            //Örnek 3: 20 elemanlı diziye rasgele - 100 ile + 100 arası sayılar atan ve daha sonra 
            //dizinin elemanlarını, pozitif sayı adetini, negatif sayı adetini ve işaretsiz sayı adetini 
            //ekranda gösteren örnek:
            int[] dizi = new int[20];
            Random rand = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {

                int rastgele_sayi = rand.Next(-100, 100);
            //Console.WriteLine(rastgele_sayi);
            dizi[i] = rastgele_sayi;
            Console.WriteLine($"{i + 1}.ci sayı={dizi[i]}");
            Console.ReadLine();
        }
            for (int i = 0; i<dizi.Length; i++)
            {
                Console.WriteLine("dizi=[{0}]", dizi[i]); // sayılarımız diziye yazılmış mı kontrol ettim
                Console.ReadLine();


            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > 0)
                {
                    Console.WriteLine($"dizinin {i + 1}.ci elemanı pozitiftir");
                }
                else if (dizi[i] < 0)
                {
                    Console.WriteLine($"dizinin {i + 1}.ci elemanı negatiftir");
                }
                else
                {
                    Console.WriteLine($"dizinin {i + 1}.ci elemanı 0'dır");
                }
            }
            Console.ReadKey();


            // Örnek 4 :Kullanıcının girmiş olduğu sayının dizide olup olmadığını bulan,
            //varsa kaç adet bulunduğunu ekranda gösteren dizi örneği:

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 7, 8, 10 };
            Console.WriteLine("1-10 arası bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int kontrol = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    kontrol++;
                }
            }
            if (kontrol == 0)
            {
                Console.WriteLine("sayınız dizide bulunamadı");
            }
            else
            {
                Console.WriteLine($"{sayi} dizide {kontrol} adet vardır");
            }

            Console.ReadKey();

            
                //Örnek 5: 10 elemanlı string dizi içindeki tek sayıları foreach döngüsüyle ekrana yazdıran
            //    ve teksayıların adetini ekranda gösteren örnek:

            string[] dizi = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", }; //12 elemanlı
            int kontrol = 0;
            foreach (string d in dizi)
            {
                int yeni_sayi = Convert.ToInt32(d); // int değere çevirme
                //yeni_sayi += 2; kontrolü yaptım
                if (yeni_sayi % 2 == 0)
                {
                    kontrol++;
                }
                else
                {
                    Console.WriteLine("tek sayı={0}", yeni_sayi);
                }
            }
            Console.WriteLine("dizide toplam {0} kadar tek sayı vardır", kontrol);
            Console.ReadKey();


















































        }
    }
}
