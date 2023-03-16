using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*
         * Kullanıcıdan aylık gelirini isteyiniz.
           Aylık geliri 4000 üstünde iste %12 vergi kesilecek
           4000'e eşit ve  altında ise %9 vergi kesilecek
           kesintilerden sonra yeni maaşı kullanıcıya gösterilecek.
           4000x12/100 == 480 4000-480  4000x0.88->Direkt yüzde 12 yi hesaplama. 
        */
        Don:
            Console.WriteLine("aylık geliriniz=");
            double gelir = Convert.ToDouble(Console.ReadLine());

            if (gelir > 4000)
            {
                gelir = (gelir * 88) / 100;
                Console.WriteLine($"geliriniz={gelir} tl'dir");

            }
            else if (gelir == 4000 || gelir < 4000)
            {
                gelir = (gelir * 91) / 100;
                Console.WriteLine($"geliriniz={gelir} tl'dir");

            }

            else
            {
                Console.WriteLine("yanlış karakter girdiniz");

            }
            goto Don;

        //MAAŞ DURUMUNU İKİ SORGUYA ALMAK İSTERSEK: mesela önce IsDigit sonra da vergi oranı olarak iç içe if kullanırız
        //hocaya sor readkey ve readline farkını da sor

        Don:
            Console.WriteLine("maaşınız=");
            char Gelir = Convert.ToChar(Console.ReadLine());

            if (char.IsDigit(Gelir))
            {
                double gelir=Convert.ToDouble(Console.ReadLine());
                if (Gelir>4000)
                {
                    gelir = (gelir * 88) / 100;
                    Console.WriteLine($"net maaş={gelir}");
                }
                else if (gelir==4000 || gelir<4000)
                {
                    gelir = (gelir * 91) / 100;
                    Console.WriteLine($"net maaş={Gelir}");
                }


            }

            else
            {
                Console.WriteLine("yanlış karakter girdiniz");
            }
            goto Don;

           Console.ReadKey(); 




        }
    }
}
