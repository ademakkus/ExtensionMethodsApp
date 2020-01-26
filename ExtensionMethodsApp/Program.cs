using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //ToInt32()
            int sayi = 5;
            string sayiStr = sayi.ToString();
            int yeniSayi = sayiStr.ToInt32();
            Console.WriteLine(yeniSayi);
            //Avarage()
            int sayi1 = 10;
            double ortalama = sayi1.Avarage(13);
            Console.WriteLine(ortalama.ToString());
           
            //Maximum
            int[] sayilar = { 1, 5, 3, 20, 50, 50, 40 };
            int enb = sayilar.Maximum();
            StringBuilder sb = new StringBuilder();
            foreach (var item in sayilar)
            {
                sb.Append(item + "-");
            }
            Console.WriteLine("{0} Dizideki enbüyük sayı: {1}",sb, enb);
            Console.ReadKey();
        }
    }
}
