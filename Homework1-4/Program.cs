using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız:");
            string mesaj = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Toplam kelime sayısı:" + (mesaj.Split(" ").Length));
            Console.WriteLine("Toplam harf sayısı:" + (mesaj.Replace(" ", "").Length));
        }
    }
}
