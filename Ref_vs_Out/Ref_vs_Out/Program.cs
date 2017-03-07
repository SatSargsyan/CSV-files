using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_vs_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3; // Variable need to be initialized 
            Console.WriteLine("before calling method ref: {0}", i);
            sampleMethod_for_ref(ref i);
            Console.WriteLine("after calling method ref: {0}", i);

            Console.WriteLine();

            int k, j; // Variable needn't be initialized 
            Console.WriteLine("after calling  sampleMethod_for_out: {0}",  sampleMethod_for_out(out k, out j));
            Console.WriteLine("after calling  sampleMethod_for_out k and j  variables passed values: k= {0}, j= {1}", k, j);

            Console.WriteLine();

            int a = 5;
            int b = 15;
            Console.WriteLine("before calling method swap: {0},  {1}", a, b);
            swap(ref a,ref b);
            Console.WriteLine("after calling method swap: {0},  {1}", a, b);

            Console.WriteLine();

            string s1 = "Barev";
            string s2 = "hayer";
            Console.WriteLine("before calling method swap: {0}  {1}", s1, s2);
            swap(ref s1, ref s2);
            Console.WriteLine("after calling method swap: {0}  {1}", s1, s2);

            Console.ReadKey();
        }

        public static void sampleMethod_for_ref(ref int sampleData)
        {
            sampleData++;
        }
        public static int sampleMethod_for_out(out int sampleData1, out int sampleData2)
        {
            sampleData1 = 10;
            sampleData2 = 20;
            return sampleData1+sampleData2;
        }
        public static void swap(ref int  a, ref int  b)
        {
            int t = a;
            a = b;
            b = t;
        }
        public static void swap(ref string a, ref string b)
        {
            string t = a;
            a = b;
            b = t;
        }

    }
}
