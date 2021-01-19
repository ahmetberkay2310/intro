using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)

        {
            string musterii = "Berkay";

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Berkay";
            musteri1.Yas = "20";
            musteri1.Meslek = "Öğrenci";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Yusuf";
            musteri2.Yas = "21";
            musteri2.Meslek = "Doktor";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Eyüp";
            musteri3.Yas = "18";
            musteri3.Meslek = "Öğretmen";

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,musteri2,musteri3
            };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : " + musteri.Adi + ", Müşteri Yaşı : "+musteri.Yas  );
            }

            Console.WriteLine("----------------------------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Add2("Berkay",20, "Öğrenci");
            musteriManager.Add2("Yusuf", 21, "Doktor");
            musteriManager.Add2("Eyüp", 18, "Öğretmen");













        }
    }
}
