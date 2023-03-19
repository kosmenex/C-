using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* DÖNGÜLER:
            * FOR, WHILE, DO WHILE, FOREACH kullanılan farklı döngülerdir
            * tekrarlı her işlemlerde döngüler kullanılıyor, farklı dinamiklere sahip olması nedeniyel farklı uygulamalarda kullanılır
              */
            //!! hatalar aynı değişken adı tekrarlı kullanıldığı için olmuştur lütfen kodları çalıştırırken ilgili bölümü açıp diğer blokları kapatınız

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("döngü!"); // sonsuz döngü vardır çünkü i'nin değeri sabit
            }
            Console.ReadKey();

            int i = 0;
            int sayac = 0;
            while (i < 10)
            {
                sayac++;
                Console.WriteLine(sayac); // sayının sonsuza kadar ardışık gittiğini görüyoruz


            }
            Console.ReadKey();

            int i = 0;
            int j = 0;
            while (i < 10)
            {
                j++;
                Console.WriteLine(j);
                i++;
            }
            Console.ReadKey();

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i); // çıktılar: 0,1,2,3,4,5,6,7,8,9 olarak 
                i++;
            }
            Console.ReadKey();
            // bu iki örnekteki fark önemli
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i); // çıktı: 1,2,3,4,5,6,7,8,9,10

            }
            Console.ReadKey();

            int a = 0;
            while (a < 10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine("döngü sonu"); // döngü false olduğunda süslü parantezden devam ediyor
            Console.ReadKey();


            // Örnek: Klavyeden girilen sayı 0 (Sıfır) olana kadar, girilen sayılardan çift sayıları toplayan,
            // tek sayıları çıkaran ve sonucu ekranda gösteren programı yapınız.

            int CiftToplam = 0;
            int TekFark = 0;

            while (true)
            {
                Console.WriteLine("bir sayı giriniz:");
            int sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı == 0)
            {
                break;

            }
            else if (sayı % 2 == 0)
            {
                CiftToplam += sayı;

            }
            else
            {
                TekFark -= sayı;

            }
            }
            Console.WriteLine($"Cift Toplam={CiftToplam}");
            Console.WriteLine($"Tek Fark={TekFark}");
            int toplam = CiftToplam + TekFark;
            Console.WriteLine(".........................");
            Console.WriteLine($"sonuç={toplam}");
            Console.ReadKey();


            // Şimdi bu örneği kullanıcıdan almak yerine random sayı atamasıyla yapalım
            // hem tahmin ederken sleep() komutuyla 1 saniye bekliyor hem de random şekilde saniye üretip çalışıyor

            int Cift = 0;
            int Tek = 0;
            while (true)
            {
                Random rnd = new Random();
                int sayı = rnd.Next(10);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(sayı);
                if (sayı == 0)
                {
                    break;
                }
                else if (sayı % 2 == 0)
                {
                    Cift += sayı;
                }
                else
                {
                    Tek -= sayı;
                }

            }
            Console.WriteLine($"Çift Toplam={Cift}");
            Console.WriteLine($"Tek fark={Tek}");
            Console.WriteLine(".............................");
            int toplam = Cift + Tek;
            Console.WriteLine($"Toplam={toplam}");
            Console.ReadKey();


            //Örnek: 1 - 100 arasındaki sayıların toplamını While Döngüsü kullanarak yapınız.

            int sayı = 0;
            int toplam = 0;
            while (sayı < 100)
            {
                toplam += sayı;
                Console.WriteLine($"toplam={toplam}");
                sayı++;
            }
            Console.WriteLine("program bitmiştir");
            Console.ReadKey();


            //Örnek: Kullanıcının girmiş olduğu sayının basamak sayısını While Döngüsü kullanarak bulan programı yapınız.

            Console.WriteLine("bir sayı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;
            while (sayı > 0)
            {
                basamak++;
                sayı = sayı / 10;

            }
            Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + " basamaklıdır");
            Console.ReadKey();

            1'den 10'a kadar sayıları aralarına boşluk bırakarak yazdır

                int i = 0;
            while (i < 10)
            {
                i++;
                Console.Write(" " + i + " "); // yanyana yazdırmak için write komutu kullanılır
                Console.Write("{0,5}", i); // yanyana yazdırmak için write komutu kullanılır
                //{ 0,5}
                //ve { 0,-5}
                //sağa ve sola yaslama farkı var sadece

                }
            Console.ReadKey();

            int sayac = 0;
            while (sayac <= 10)
            {
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac * sayac);
                sayac++;
            }
            Console.ReadKey();



            // DO WHILE DÖNGÜSÜ


            //do // do ifadesi herhangi bir koşula bakmaksızın süslü parantez altına kadar çalıştırır

            //{

            //    //bu kod bloğu her halükarda döngüye girmeden önce çalışır



            //} while (true);




            Console.WriteLine("bir sayı giriniz");
            int n=Convert.ToInt32(Console.ReadLine());
            int i = 2;
            do
            {
                Console.WriteLine("{0,3}",i);
                i += 2;
            } while (i<=n);
            Console.ReadKey();

        }
    }
}
