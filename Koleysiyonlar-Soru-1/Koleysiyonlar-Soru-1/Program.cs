using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

          



            ArrayList list = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write(i + 1 + ".Sayiyi Giriniz:");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    list.Add(number1);
                }
                catch (Exception)
                {
                    i = i - 1;
                    Console.WriteLine("Sadece Sayi Giriniz!");
                }
            }




            ArrayList asallist = new ArrayList();
            ArrayList noasallist = new ArrayList();

            AsallariAyir(list, asallist, noasallist);

            Console.WriteLine("**Asal Sayilar**");
            BuyuktenKucugeYazdir(asallist);
            Console.WriteLine("\n");
            Console.WriteLine("**Asal Olmayan Sayilar**");
            BuyuktenKucugeYazdir(noasallist);
            Console.WriteLine("\n");
            Console.WriteLine("Asal Sayi Adet:" + asallist.Count + "\n" + "Asal Sayilarin Ortalamasi:" + ListeOrtalama(asallist));
            Console.WriteLine("Asal Olmayan Sayi Adet:" + noasallist.Count + "\n" + "Asal Olmayan Sayilarin Ortalamasi:" + ListeOrtalama(noasallist));

            Console.ReadKey();
        }


        static void AsallariAyir(ArrayList sayilar, ArrayList asallist, ArrayList noasallist)
        {
            for (int i = 0; i < 20; i++)
            {
                if (AsalKontrol(Convert.ToInt32(sayilar[i])))
                {
                    asallist.Add(sayilar[i]);
                }
                else

                {
                    noasallist.Add(sayilar[i]);
                }

            }



        }


        static bool AsalKontrol(int  number)
        {
            int sayac = 0;

            for (int i = 1; i <= number; i++)
            {
                double sayi = number * 1.0 / i;
                if (sayi==(int) sayi)
                {
                    sayac++;
                }
            }

            if (sayac==2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void BuyuktenKucugeYazdir(ArrayList arraylist)
        {
            arraylist.Sort();
            for (int i = arraylist.Count - 1; i >= 0; i--)
            {
                Console.Write(arraylist[i] + " ");
            }

        }

        static double ListeOrtalama(ArrayList array)
        {
            double ort = 0;
            for (int i = 0; i < array.Count; i++)
            {
                ort = ort + Convert.ToInt32(array[i]);
            }
            ort = ort * 1.0 / array.Count;
            return ort;
        }
    }
}
