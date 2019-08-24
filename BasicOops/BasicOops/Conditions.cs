using System;
namespace BasicOops
{
    public class Conditions
    {
        bool b = true;
        int temp;

        public void Conditional()
        {
            int a = 10;

            if (a == 10)
            {
                Console.WriteLine("a is 10");
            }
        }

        public void Loops()
        {
            temp = b ? 1 : 2;
            Console.WriteLine("temp = {0}", temp);
        }
    }
}
