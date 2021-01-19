using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 20;
            sayı1 = sayı2;
            sayı2 = 43;
            //sayı2 = ? 20 Eşitliğin sağ tarafındaki değerin int değerine bakılır 

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300};

            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            // sayılar1[0] = ? 999 eşitliğin sağ tarafındaki referans değerini
            //                      array var iken int'e göre değil eşitliğin altındaki
            //                      referansa bakılır



        }

    }
}
