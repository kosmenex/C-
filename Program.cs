using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //if else çeşitli örnekler
        //Kullanıcıdan iki ürün fiyatı isteyin,fiyat toplamları 250 tl geçerse
        //ucuz ürüne
        //%25 indirim uygulayınız.

        Geri:
            Console.WriteLine("1.ürün fiyatı=");
            double urun_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.ürün fiyatı=");
            double urun_2 = Convert.ToDouble(Console.ReadLine());
            double toplam = urun_1 + urun_2;

            if (toplam > 250)
            {
                if (urun_1 > urun_2)
                {
                    urun_2 = (urun_2 * 75) / 100;
                    Console.WriteLine($"{urun_2}'ye %25 İndirim uygulandı");
                    toplam = urun_1 + urun_2;
                    Console.WriteLine($"toplam={toplam}");
                }
                else
                {
                    urun_1 = (urun_1 * 75) / 100;
                    Console.WriteLine($"{urun_1}'ye %25 İndirim uygulandı");
                    toplam = urun_1 + urun_2;
                    Console.WriteLine($"toplam={toplam}");
                }

            }
            else
            {
                Console.WriteLine($"toplam={toplam}");

            }
            Console.ReadKey();
            goto Geri;

        /*
            Kullanıcıdan alınacak kw değerine göre.
            KW başına değer                                   
            0-100 kw harcamışsa 0.35 ile fiyatlanıdırlacak.
            101-250 kw => 0.38 -> 
            251-400 kw=> 0.41 ->
            401-600 kw=> 0.42 ->
            600 kw  üstü ise 120 tl indirim yapılacak. ve fiyatlandırma 0.43 üzerinden olacak.İndirim Oranı ekrana yazdırılsın.
            120 tl indirim yapıldı diye ekrana bilgi mesajı indirim yaptırabilirsiniz.
            Örnek -> 150 kw elektrik kullanılmış olsun 150 * 0.38 yapılacak.
            ilk koşulumuz zaten sıfırdan büyük veya eşit koşulu olduğu için negatif değer girmesi söz konusu değildir.ü
        */

            // her iki örneğimizde de goto kullandığımız için alt satırlar silik renkli çıkıyor
            // çünkü GOTO döngüsü sonsuza kadar çalışıyor ve alt satırlara derleyici asla geçemiyor

        Back:
            Console.WriteLine("kaç kw elektrik kullandınız?");
            double kw=Convert.ToDouble(Console.ReadLine());
            
            if (kw>=0 && kw<=100)
            {
                double indirim=(kw*35)/100;
                Console.WriteLine($"Tebrikler {indirim} tl indirim kazandınız");
                double tutar = (kw * 65) / 100;
                Console.WriteLine($"toplam tutar={tutar} tl");
            }
            else if (kw>=101 && kw<=250)
            {
                double indirim = (kw * 38) / 100;
                Console.WriteLine($"Tebrikler {indirim} tl indirim kazandınız");
                double tutar = (kw*62) / 100;
                Console.WriteLine($"toplam tutar={tutar} tl");

            }
            else if (kw>=251 && kw<=400)
            {
                double indirim = (kw * 41) / 100;
                Console.WriteLine($"Tebrikler {indirim} tl indirim kazandınız");
                double tutar = (kw * 59) / 100;
                Console.WriteLine($"toplam tutar={tutar} tl");
            }
            else if(kw>=401 && kw<=600) 
            {
                double indirim = (kw * 42) / 100;
                Console.WriteLine($"Tebrikler {indirim} tl indirim kazandınız");
                double tutar = (kw * 58) / 100;
                Console.WriteLine($"toplam tutar={tutar} tl");
            }
            else if (kw>=601)
            {
                Console.WriteLine("Tebrikler 120 tl indirim kazandınız");
                double tutar = ((kw * 57) / 100) - 120;
                Console.WriteLine($"toplam tutar={tutar}");

            }
            else
            {
                Console.WriteLine("yanlış karakter girdiniz");
            }
            goto Back;

            Console.ReadKey();  
            




































        }
    }
}
