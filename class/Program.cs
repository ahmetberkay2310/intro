using System;

namespace class
{
    class Program
{
    static void Main(string[] args)
    {
        kurs kurs1 = new kurs();
        kurs1.kursAdi = "fizik";
        kurs1.eğitmen = "Yusuf Orhan";
        kurs1.izlemeOranı = 76;

        kurs kurs2 = new kurs();
        kurs2.kursAdi = "Kimya";
        kurs2.eğitmen = "Emir Topçu";
        kurs2.izlemeOranı = 34;

        kurs kurs3 = new kurs();
        kurs3.kursAdi = "Biyoloki";
        kurs3.eğitmen = "Berkay Karabulu";
        kurs3.izlemeOranı = 23;

        Console.WriteLine(kurs1.kursAdi + "  " + kurs1.eğitmen);
    }
}
}
