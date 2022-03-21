using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int pozitif_sayi = Convert.ToInt16(Console.ReadLine());
            int[] sayilar = new int[100];
            int[] cift_sayilar = new int[100];
            int index = 0;
            for (int i = 0; i < pozitif_sayi; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Giriniz: ");
                sayilar[i] = Convert.ToInt16(Console.ReadLine());
                if (sayilar[i] % 2 == 0)
                {
                    cift_sayilar[index] = sayilar[i];
                    index++;
                }
            }
            Console.Write("Girilen çift sayılar: ");
            for(int i=0;i<index;i++)
            {
                Console.Write(cift_sayilar[i] + " ");
            }
        }
    }
}
