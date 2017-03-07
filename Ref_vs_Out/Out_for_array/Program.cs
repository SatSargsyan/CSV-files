using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_for_array
{
    class TestOut
    {
        static void FillArray(out int[] arr)
        {
            // Initialize the array:
            arr = new int[5] { 1, 2, 3, 4, 5 };
        }

        static void Main()
        {
            int[] theArray; // Initialization is not required

            // Pass the array to the callee using out:
            FillArray(out theArray);

            // Display the array elements:
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