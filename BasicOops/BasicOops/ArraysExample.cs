using System;
namespace BasicOops
{
    public class ArraysExample
    { 
        // defining arrays
        int[] a = new int[20];

        // initializing arrays
        int[] b = new int[5] { 1, 2, 3, 4, 5 };

        int[] c = { 1, 2, 3, 4, 5 };
        // dynamic array
        int[] d = new int[] { };

        // multi-dimensional arrays
        int[,] mdstatic = new int[2, 3];
        int[,] mdstatic_initialize = new int[2, 3]
        {
            {1, 2, 3 },
            {4, 5, 6 }
        };

        int[,] mddynamic = new int[,] { { } };

        public void Display()
        {
            // accessing specific element
            Console.WriteLine("specific value of b = {0}", b[3]);

            // iterating all items
            for(int iter=0; iter<b.Length; iter++)
            {
                Console.WriteLine("b[{0}] = {1}", iter, b[iter]);
            }
        }

        public void ForEachAccess()
        {
            foreach(int item in b)
            {
                Console.WriteLine(item);
            }
        }

        public void MultiDimensional()
        {
            // Accessing specific item
            Console.WriteLine("mdstatic[2][2] = {0}", mdstatic_initialize[2, 2]);

            foreach(int item in mdstatic_initialize)
            {
                Console.WriteLine(item);
            }
        }

        public int MethodWithArrayArgument(int[] itemstosum)
        {
            // dynamic number of args
            int sum = 0;
            foreach(int item in itemstosum)
            {
                sum += item;
            }
            return sum;
        }
    }
}
