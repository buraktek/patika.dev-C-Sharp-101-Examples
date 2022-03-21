using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen girilecek kelime sayısını giriniz: ");
            int lenght = Convert.ToInt16(Console.ReadLine());
            string[] mesaj = new string[lenght];
            for (int i = 0; i < lenght; i++)
            {
                mesaj[lenght-i-1] = Console.ReadLine() + Environment.NewLine;
            }
            Console.Write("Girilen kelimeler tersten:");
            foreach (string str in mesaj)
                Console.Write(str);
        }
    }
}
