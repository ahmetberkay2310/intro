using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "fizik";
            string kurs2 = "matematik";
            string kurs3 = "kimya";
            string kurs4 = "biyoloji";
            string kurs5 = "ingilizce";
            string kurs6 = "eem";
            string kurs7 = "fizik lab";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine(kurs6);
            Console.WriteLine(kurs7);

            Console.WriteLine("-------------------------------------------");

            string[] kurslar = new string[]
            {
                "fizik ", "kimya", "biyoloji", "matematik", "eem", "ingilizce", "fizik lab"
            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for döngüsü bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("footer - sayfa sonu");

        }
    }
}
