using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_for_array
{
    class TestRef
    {
        public static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Arrayswap(int[] arr)
        {
            int a = arr[1];
            arr[1] = arr[4];
            arr[4] = a;
        }
        static void FillArray( int[] arr)
        {
            
            arr[0] = 2222;
            arr[4] = 7777;
        }
        static void FillArray1(int[] arr)
        {
           
            // Fill the array:
            arr =new int[] {6,9,6,9,6};
            
        }
        static void FillArray2(int[] arr)
        {
            arr[3] = 3333;
            arr[4] = 1;
        }
        static void FillArray3(int[] arr)
        {
            //arr = new int[] { 6, 9, 6, 9, 6 };
            int a = arr[1];
            arr[1] = arr[4];
            arr[4] = a;
            arr[0] = 8000;
        }
       
        static void FillArray(ref int[] arr)
        {
            // Create the array on demand:
            if (arr == null)
            {
                arr = new int[10];
            }
            // Fill the array:
            arr[0] = 1111;
            arr[4] = 5555;
        }

        static void Main()
        {
            // Initialize the array:
            int[] theArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine();
            FillArray3(theArray);
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + " ");
            }

            Console.WriteLine();

            FillArray(theArray);
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + " ");
            }

            // Pass the array using ref:
            FillArray(ref theArray);

            Console.WriteLine();
            // Display the updated array:
            Console.WriteLine("Array elements are using ref:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + " ");
            }

            Console.WriteLine();

            FillArray2(theArray);
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + " ");
            }

            Console.WriteLine();

            FillArray1(theArray);
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("swap with ref ");
            for (int i = 0; i < theArray.Length-1; i++)
            {
                swap(ref theArray[i], ref theArray[i + 1]);
                           }
            for (int i = 0; i < theArray.Length; i++)
            {
                 Console.Write(theArray[i] + " ");
            }

            Console.WriteLine();

            Arrayswap(theArray);
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + " ");
            }

            // Keep the console window open in debug mode.
            Console.ReadKey();
        }
    }
   
}
