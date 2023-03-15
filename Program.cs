using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             if()
                {
                pass
                }
            else if()
                {
                pass
                }
            else
                {
                pass
                }
            yapısında bir koşul sorgulama ifadesidir, koşul ifadesi doğru olunca döngü biter ve sonlanır

            */
            // TEK Mİ ÇİFT Mİ SAYI AYRACI
            Console.WriteLine("bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("sayınız çifttir");
            }
            else
            {
                Console.WriteLine("sayınız tektir");
            }
            Console.ReadLine();

            //Rastgele sayı üretme genelde sık kullanılan bir metotdur.
            Random rnd = new Random(); // kütüphaneyi çağırdık
            int rastgeleSayi = rnd.Next(); // herhangi bir sayı üretme .Next(başlangıc,bitiş)
            if (rastgeleSayi % 2 == 0)
            {
                Console.WriteLine("{0} sayısı çifttir", rastgeleSayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı tektir", rastgeleSayi);
            }


            //aralıklı random sayısı üretme
            Random rnd = new Random();
            int RastgeleSayi = rnd.Next(0, 150);
            if (RastgeleSayi % 2 == 0)
            {
                Console.WriteLine("{0} sayısı çifttir", RastgeleSayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı tektir", RastgeleSayi);
            }

            // ONEMLİ. İF YAZIP İKİ TAB TUŞUNA BASILINCA YAPI OTOMATİK GELİR.

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift bir sayıdır");
            }
            else
            {
                Console.WriteLine($"{sayi} tek bir sayıdır");

            }
            //$ snippet ifadedir indexleme mantığıyla kullanıyoruz yukarıdaki örneğin bir benzeri olarak verildi.


            // Mutlak Değer Ayracı
            Console.WriteLine("bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                n *= -1;
                Console.WriteLine($"|{n}| mutlak ifadesidir");
            }
            else if (n == 0)
            {

                Console.WriteLine($"{n} sayısı 0'dır");
            }
            else
            {
                Console.WriteLine($"{n} sayısı pozitiftir");
            }

        //Random sayı mutlak değer ifadesi

        //Don:
            Random rnd = new Random();
            int RastgeleSayi = rnd.Next();
            if (RastgeleSayi > 0)
            {
                Console.WriteLine($" rastgele sayı={RastgeleSayi}, pozitiftir");

            }
            else if (RastgeleSayi < 0)
            {
                RastgeleSayi *= -1;
                Console.WriteLine($"rastgele sayı={RastgeleSayi}, mutlak ifadesi |{RastgeleSayi}|'dır");
            }
            else
            {
                Console.WriteLine($"{RastgeleSayi} Sıfırdır.");
                // random sayı üreteci 0dan küçük sayı üretemediği için alsa else koşuluna düşmüyor

            }
           // goto Don;

            // goto .... ifadesi yanındaki koşulun olduğu satıra geri dön manasında kullanılır sonsuz göngü yaratıyor burada

            var k = (char)Console.Read(); // char ifadesini kullanmadığımızda karakterin ascıı kodları geliyor
                                          // ifadenin karakter olmasını sağlamak için char kullanıldı
            if (char.IsDigit(k))
            {
                Console.WriteLine("rakamdır");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("küçük karakterdir");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("büyük karakter");
            }    
            else 
            {
                Console.WriteLine("bilinmeyen karakter");
            }


            Console.WriteLine(k);




            Console.ReadKey(); // Console.readline olduğunda hemen bakapınıyor onun için ReadKey kullanmak daha mantıklı



        }
    }
}
