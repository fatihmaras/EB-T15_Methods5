using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMethodTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 3. sayıyı giriniz");
            int sayi3 = int.Parse(Console.ReadLine());

            ToplamaYap(sayi1, sayi2, sayi3);

            CarpmaYap(sayi1, sayi2, sayi3);

            Console.WriteLine("Lütfen İsminizi giriniz ");
            string Isim = Console.ReadLine();

            Console.WriteLine("Lütfen Soyisminizi giriniz ");
            string Soyisim = Console.ReadLine();
            İsimSoyisimYazdir(Isim, Soyisim);

            Console.ReadLine();

        }
        static void ToplamaYap(int sayi1, int sayi2, int sayi3)

        {
            Console.WriteLine("Girilen Sayıların Toplamı : " + (sayi1 + sayi2 + sayi3));

        }

        static void CarpmaYap(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("3 Sayının Çarpımı :" + (sayi1 * sayi2 * sayi3));
        }

        static void İsimSoyisimYazdir(string Isim, String Soyisim)
        {
            Console.WriteLine("Isim ve Soyisim : " + Isim + " " + Soyisim);
        }
    }
}
