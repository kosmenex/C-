using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Sayı_Ayracı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan girilen değerin asal olup olmamasını kontrol etme
            // asal sayı: kendisinden ve 1den hariç hiçbir şeye bölünemeyen sayı

            int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i < sayi)
            {
                if (sayi % i == 0)
                    kontrol++;

                i++;
            }

            if (kontrol != 0)
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            else
                Console.WriteLine("Girdiğiniz sayı asaldır.");

            Console.ReadKey();














        }
    }
}
