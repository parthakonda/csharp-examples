using System;
namespace BasicOops
{
    public class EncapsulationBase
    {

        private int a;
        public int b;
        protected int c;
        internal int d;

        public EncapsulationBase()
        {
        }

        public void AccessA()
        {
            a = 10;
        }

        public void AccessB()
        {
            b = 20;
        }

        public void AccessC()
        {
            c = 30;
        }

        public void AccessD()
        {
            d = 40;
        }

        public void DisplayValues()
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
        }
    }
}
