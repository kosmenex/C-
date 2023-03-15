using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Writeline() yazma / ekrana basma  metodu olarak bilinir aynı zamanda kullanıcıdan veri girişi için de kullanılır
            //Console.Readline() okuma metodu olarak bilinir yazılan kodları okuması için mutlaka program sonuna koyuyoruz
            //Console.Readkey() olarak da program sonu kod bloğu okuma metodu olarak kullanılıyor
            // Refactoring iyileştirme kavramları, hızlıca yazdığınız kod için daha hızlı veya daha verimli çalışması için yapılan iyileşttirmelerdir.
            // Visula Studio için bu örneği inceleyelim, kod bloğunu seçip CTRL+. yaptığımızda globalden lokala düşmüş oluyor



            //int sayi = 3;
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi+2);
            //Console.WriteLine(sayi*sayi);
            //Console.WriteLine(sayi-8);
            //Console.ReadKey();

            NewMethod();

            void NewMethod()
            {
                int sayi = 3;
                Console.WriteLine(sayi);
                Console.WriteLine(sayi + 2);
                Console.WriteLine(sayi * sayi);
                Console.WriteLine(sayi - 8);
                Console.ReadLine();
            }


            // ESCAPE kaçış ifadeleri

            string ifade = "kübra kösmene";
            string new_ifade = "kübra\nkösmene\n2023";
            Console.WriteLine(ifade);
            Console.WriteLine(new_ifade);
            Console.ReadLine() ;
            /*
             * 
             \n.......alt satıra geçme ifadesi
             \t........tab 4 boşluk bırakma ifadesi
             \\a........alert uyarı sesi üretmesi

            */

            //string lokasyon = "C:\user\kosmene"; // gördüğünüz gibi hata veriyor bunu düzeltmek için iki yol var
            string lokasyon1= "C:\\user\\kosmene"; // çift slaş 
            string lokasyon2= @"C:\user\kosmene"; // string ifade başına @ koyarak da bunu çözebiliriz

            string ifade0=Console.ReadLine(); // klavyeden girilen değeri hafızada tutuyor

            var ifade1=Console.ReadLine(); //örtülü değişken "var" gelen değişkeni değişken olarak tutuyor

            // string ifadeler indexlenebilir yani harfi harfine sorgulatılabilir bunu sağlayan da bazı metodlar var şimdi bunları inceleyelim

            string message = "hello world, again!";
            Console.WriteLine(message);
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());
            Console.WriteLine(message.Length);
            Console.WriteLine(message.TrimStart());
            Console.WriteLine(message.TrimEnd());
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
            Console.WriteLine(message[3]);
            Console.WriteLine(message.Length-1);
            Console.ReadLine();
          
            









        }
    }
}
