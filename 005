using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0005
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Ağrı Derecesi 0->Ağrım yok 1->Çok az ağrım var 2-Biraz ağrım var 3->Ağrım var 4->Şiddetli ağrım var 5->Çok şiddetli ağrım var
        //Else Hatalı giriş yapıldı.Lütfen tekrar deneyiniz. goto ile tekrar değer girmesini isteyin.
        Hata:
            Console.WriteLine("AĞRI DERECENİZ:" + "\n" +
                "0->Ağrım yok " + "\n" +
                "1->Çok az ağrım var " + "\n" +
                "2-Biraz ağrım var " + "\n" +
                "3->Ağrım var " + "\n" +
                "4->Şiddetli ağrım var " + "\n" +
                "5->Çok şiddetli ağrım var ");

            int AgrıDerecessı = Convert.ToInt32(Console.ReadLine());
            if (AgrıDerecessı == 0)
            {
                Console.WriteLine("Ağrım yok");
            }
            else if (AgrıDerecessı == 1)
            {
                Console.WriteLine("Çok az ağrım var");
            }
            else if (AgrıDerecessı == 2)
            {
                Console.WriteLine("Biraz ağrım var");
            }
            else if (AgrıDerecessı == 3)
            {
                Console.WriteLine("Ağrım var");
            }
            else if (AgrıDerecessı == 4)
            {
                Console.WriteLine("Şiddetli ağrım var");

            }
            else if (AgrıDerecessı == 5)
            {
                Console.WriteLine("Çok şiddetli ağrım var");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Tekrar Deneyiniz!");
                goto Hata;

            }
        // CHAR DÖNÜŞÜMÜNÜ MUTLAKA HOCAYA SOR
        //
        Don:
            Console.WriteLine("AĞRI DERECENİZ:" + "\n" +
              "0->Ağrım yok " + "\n" +
              "1->Çok az ağrım var " + "\n" +
              "2-Biraz ağrım var " + "\n" +
              "3->Ağrım var " + "\n" +
              "4->Şiddetli ağrım var " + "\n" +
              "5->Çok şiddetli ağrım var ");
            // int deger=Convert.ToInt32(Console.ReadLine());
            char deger = Convert.ToChar(Console.ReadLine());

            if (char.IsDigit(deger))
            {
                int deger = Convert.ToInt32(deger);
                if (deger == 0)
                {
                    Console.WriteLine("Ağrı yok");

                }
                else if (deger == 1)
                {
                    Console.WriteLine("Ağrım çok az");
                }
                else if (deger == 2)
                {
                    Console.WriteLine("Biraz ağrım var");

                }
                else if (deger == 3)
                {
                    Console.WriteLine("Ağrım var");
                }
                else if (deger == 4)
                {
                    Console.WriteLine("Şiddetli");
                }
                else
                {
                    Console.WriteLine("Çok şiddetli ağrım var");
                }


            }
            else
            {
                Console.WriteLine("Yanlış Karakter Girdiniz!");
                goto Don;
            }

            // KULLANICI ŞİFRE GİRİŞİ


            string kA = "kübra";
            string posta = "kk@gmail.com";
            string sifre = "123";
        Don:
            Console.WriteLine("kullanıcı adınız");
            string kullanıcı = Console.ReadLine();
            Console.WriteLine("mailiniz:");
            string mail = Console.ReadLine();
            Console.WriteLine("şifreniz");
            string parola = Console.ReadLine();

            if (kA == kullanıcı && sifre == parola || posta == mail && sifre == parola)
            {
                Console.WriteLine($"Hoşgeldiniz Sayın {kullanıcı}");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
                goto Don;
            }



            //Kullanıcıdan iki tane sayı alıp bunlarn farkını alın
            //AMA fark negatif olmayacak.
            Console.WriteLine("Sayi 1");

            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi 2");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi1 - sayi2;
            if (sonuc < 0)
            {
                sonuc *= -1;
                Console.WriteLine(sonuc);
            }


            Console.ReadKey();
            

               
             







        }
    }
}
