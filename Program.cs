using System;
using System.Globalization;

namespace consoleapp
{
    class Program
    {
        // private static IFormatProvider culture;

        static void Main(string[] args)
        {

            // 1) Girilen sayının hangisi büyüktür?
            Console.Write("1. Sayıyı Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hangi Sayı Büyük? " + ((sayi1 > sayi2) ? "1. Sayı" : "2. Sayı"));


            // 2) Email ve Parola bilgisini isteyip doğruluğunu kontrol ediniz.
            string email = "deneme@gmail.com", parola = "123456";
            Console.Write("email :");
            string girilen_email = Console.ReadLine();
            Console.Write("Parola :");
            string girilen_parola = Console.ReadLine();
            bool sonuc = (email == girilen_email) && (parola == girilen_parola);
            Console.WriteLine($"Girilen bilgiler {sonuc}");


            // 3) Girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.
            Console.Write("Sayı Giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            bool sonuc = (sayi >= 0 && sayi % 2 == 0);
            Console.WriteLine("Sonuç Pozitif Çift Sayı mı? " + sonuc);


            // 4) Girilen 3 sayının büyüklük olarak karşılaştırınız.
            Console.Write("1. Sayıyı Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz : ");
            int sayi3 = int.Parse(Console.ReadLine());
            int enbuyuksayi = ((sayi1 > sayi2) && (sayi1 > sayi3)) ? sayi1 : (sayi2 > sayi3) ? sayi2 : sayi3;
            Console.WriteLine("En Büyük Sayı = " + enbuyuksayi);




        }
    }
}
