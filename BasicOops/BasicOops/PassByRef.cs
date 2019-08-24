using System;
namespace BasicOops
{
    public class PassByRef
    {
        int a = 10, b = 20;
        public PassByRef()
        {
        }

        public int swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return a;
        }

        public void Run()
        {
            a = swap(ref a, ref b);
            Console.WriteLine("a = {0}", a);
        }
    }
}
