using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif iki adet sayı giriniz: ");
            int pozitif_sayi1 = Convert.ToInt16(Console.ReadLine());
            int pozitif_sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Lütfen pozitif " + pozitif_sayi1 + " adet sayı giriniz: ");
            string mesaj = "";

            for (int i = 0; i < pozitif_sayi1; i++)
            {
                int pozitif_sayi3 = Convert.ToInt16(Console.ReadLine());
                if ((pozitif_sayi3 == pozitif_sayi2) || (pozitif_sayi3 % pozitif_sayi2 == 0))
                    mesaj += pozitif_sayi3 + " ";
            }
            Console.Write(Environment.NewLine + "Eşit yada tam bölen sayılar: " + mesaj);
        }
    }
}
