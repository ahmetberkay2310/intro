using System;

namespace classintroo
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "fizik";
            kurs1.Egitmen = "Yusuf Orhan";
            kurs1.IzlenmeOrani = 76;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Kimya";
            kurs2.Egitmen = "Emir Topçu";
            kurs2.IzlenmeOrani = 34;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Biyoloji";
            kurs3.Egitmen = "Berkay Karabulut";
            kurs3.IzlenmeOrani = 23;

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

        }
    }
            class Kurs
        {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public int IzlenmeOrani { get; set; }
        }
    }


