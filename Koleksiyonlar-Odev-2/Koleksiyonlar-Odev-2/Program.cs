using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Koleksiyonlar_Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
        
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(i + 1 + ".Sayiyi Giriniz:");
                    list.Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Tanimsiz Veri tipi Girildi !!");
               
            }

            list.Sort();

            ArrayList max3 = new ArrayList();
            ArrayList min3 = new ArrayList();
            max3.Add(list[0]);
            max3.Add(list[1]);
            max3.Add(list[2]);
            min3.Add(list[17]);
            min3.Add(list[18]);
            min3.Add(list[19]);

            Console.WriteLine("1.Listenin Ortalamasi={0}\n2.Listenin Ortalamasi={1}", Ortalama(max3), Ortalama(min3));
            Console.WriteLine("Listelerin ortalamasinin toplami={0}", Ortalama(min3) + Ortalama(max3));
            Console.ReadKey();
           
        }


        static double Ortalama(ArrayList list)
        {
            double plus = 0;
            for (int i = 0; i < list.Count; i++)
            {
                plus = plus + Convert.ToDouble(list[i]);
            }

            return plus * 1.0 / list.Count;
            
        }
    }
}
