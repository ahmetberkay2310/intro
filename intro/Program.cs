using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool sistemeGirişYaptımı = true;
            double dolarDün = 7.33;
            double dolarBugün = 7.33;
            string kategoriEtiketi = "kategori";

            if (dolarBugün>dolarDün)
            {
                Console.WriteLine("dolar yükselişte");
            }
            else if (dolarDün>dolarBugün)
            {
                Console.WriteLine("dolar düşüşte");
            }

            else
            {
                Console.WriteLine("dolar aynı");
            }

            if (sistemeGirişYaptımı== true)
            {
                Console.WriteLine("kullanıcı ayarlar butonu");
            }

            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
               
             
            // Console.WriteLine(merhaba);
            //Console.WriteLine(sayı);
           // Console.WriteLine(serbestSayı);


        }
    }
}

