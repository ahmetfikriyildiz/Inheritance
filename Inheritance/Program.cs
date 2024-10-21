using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Bu uygulamada nesne yönelimli programlamanın kalıtım özelliğini örnekler ile anlatımı bulunmaktadır.
    public class BaseKisi
    {
        // Ortak Özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Ortak Metot
        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }
    public class Ogrenci : BaseKisi
    {
        // Ogrenci'ye özel property
        public int OgrenciNumarasi { get; set; }

        // Ogrenci'ye özel metot
        public void OgrenciBilgisiYazdir()
        {
            // Öğrenci Numarası ile birlikte Ad ve Soyadı da yazdır
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
            AdSoyadYazdir();  // Base sınıfın metodunu kullanarak ad ve soyadı yazdır
        }
    }
    public class Ogretmen : BaseKisi
    {
        // Ogretmen'e özel property
        public decimal Maas { get; set; }

        // Ogretmen'e özel metot
        public void OgretmenBilgisiYazdir()
        {
            // Maaş bilgisi ile birlikte Ad ve Soyadı da yazdır
            Console.WriteLine($"Maaş: {Maas} TL");
            AdSoyadYazdir();  // Base sınıfın metodunu kullanarak ad ve soyadı yazdır
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesnesi oluşturma ve değer atama
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                OgrenciNumarasi = 12345
            };

            // Öğretmen nesnesi oluşturma ve değer atama
            Ogretmen ogretmen = new Ogretmen
            {
                Ad = "Ayşe",
                Soyad = "Kara",
                Maas = 5000.00m
            };

            // Öğrenci ve öğretmen bilgilerini yazdırma
            Console.WriteLine("Öğrenci Bilgileri:");
            ogrenci.OgrenciBilgisiYazdir();

            Console.WriteLine("\nÖğretmen Bilgileri:");
            ogretmen.OgretmenBilgisiYazdir();
            Console.ReadKey();
        }
    }
}
