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
            //int i = 3; // Variable need to be initialized 
            //Console.WriteLine("before calling method ref {0}", i);
            //sampleMethod_for_ref(ref i);
            //Console.WriteLine("after calling method ref {0}",i);

            //int k, j; // Variable needn't be initialized 
            //Console.WriteLine(sampleMethod_for_out(out k, out j)); 
            //Console.WriteLine("after calling method out {0}, {1}", k,j);

            int a = 5;
            int b = 15;
            Console.WriteLine("before calling method swap {0}, {1}", a, b);
            swap(ref a,ref b);
            Console.WriteLine("after calling method swap {0}, {1}", a, b);

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

    }
}
