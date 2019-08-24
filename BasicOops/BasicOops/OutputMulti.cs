using System;
namespace BasicOops
{
    public class OutputMulti
    {
        public OutputMulti()
        {
        }

        public void returnMulti(out int a, out int b)
        {
            a = 5;
            b = 10;
        }

        public void Consume()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            returnMulti(out a, out b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
