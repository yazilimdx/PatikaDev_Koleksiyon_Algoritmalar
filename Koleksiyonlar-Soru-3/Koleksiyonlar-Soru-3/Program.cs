using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sesli = "aeıioöuü";
            string str = Console.ReadLine();
            ArrayList sesliler = new ArrayList();

            for (int i = 0; i < str.Length; i++)
            {
                if (sesli.Contains(str[i]))
                {
                    sesliler.Add(str[i]);
                }
            }

            foreach (var item in sesliler)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();
            
        }
    }
}
