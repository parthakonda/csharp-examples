using System;
namespace BasicOops
{
    public class Loops
    {
        int a = 10;
        public void WhileLoop()
        {
            while (a< 20)
            {
                Console.WriteLine(a);
                a++;
            }
        }

        public void ForLoop()
        {
            for(int b = 10; b < 20; b++)
            {
                Console.WriteLine(b);
            }
        }
    }
}
