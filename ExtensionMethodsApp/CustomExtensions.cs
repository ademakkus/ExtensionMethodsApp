using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsApp
{
    static class CustomExtensions
    {
        public static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);

        }
        public static double Avarage(this int sayi1,int sayi2){
            return (double)(sayi1+sayi2)/2;
        }
        public static T Maximum<T>(this T[] array)where T:IComparable
        {
            T enb=array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i].CompareTo(enb)>0)
                {
                    enb = array[i];
                }
            }
            return enb;


        }
    }
}
