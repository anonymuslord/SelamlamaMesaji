using System;
using System.Threading;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı İSİM SOYİSİM:");
            string isim = Console.ReadLine();
            Console.WriteLine($"Merhaba, {isim}! Hoşgeldiniz? Nasılsınız?");
            string cevap =Console.ReadLine();
            Console.WriteLine(cevap + " pek yeterli bir cevap olmadı sanki. Bana biraz daha kendinizden bahsedebilir misiniz?");
            string cevap2 =Console.ReadLine();
            Console.WriteLine("...");
            Thread.Sleep(3000);
            Console.WriteLine("Anlıyorum.");
            Thread.Sleep(2000);
            Console.WriteLine("Bana Hobilerinden bahsetmek sana iyi gelebilir belki.");
            Console.ReadLine();
            Console.WriteLine("Bunları duyduğuma sevindim. Sonraki Güncellemelerde tekrar gel. AnonymusLord");

        }
    }
}