using System;
namespace BasicOops
{
    public class Operators
    {
        int a = 2, b = 3, e;
        bool c = true, d = true;

        // Arithmetic Operators
        public void ArithmeticOperators()
        {
            Console.WriteLine("a +b = {0}", (a + b));
            Console.WriteLine("a - b = {0}", (a - b));
            Console.WriteLine("a * b = {0}", (a * b));
            Console.WriteLine("a / b = {0}", (a / b));
            Console.WriteLine("a % b = {0}", (a % b));
            Console.WriteLine("a++ = {1}", a++, a);
            Console.WriteLine("a-- = {1}", a--, a);
        }

        // Relational Operators
        public void RelationalOperators()
        {
            Console.WriteLine("a == b = {0}", (a == b));
            Console.WriteLine("a != b = {0}", (a != b));
            Console.WriteLine("a > b = {0}", (a > b));
            Console.WriteLine("a < b = {0}", (a < b));
            Console.WriteLine("a >= b = {0}", (a >= b));
            Console.WriteLine("a <= b = {0}", (a <= b));
        }

        // Logical Operators
        public void LogicalOperators()
        {
            Console.WriteLine("c && d = {0}", (c && d));
            Console.WriteLine("c || d = {0}", (c || d));
            Console.WriteLine("!(c && d) = {0}", !(c && d));
        }

        // Bitwise Operators
        public void BitwiseOperators()
        {
            Console.WriteLine("a & b = {0}", (a & b));
            Console.WriteLine("a | b = {0}", (a | b));
            Console.WriteLine("a ^ b = {0}", (a ^ b));
            Console.WriteLine("~a = {0}", (~a));
        }

        // Assignment Operators
        public void AssignmentOperators()
        {
            e = a + b;
            Console.WriteLine("e = a + b - {0}", e);
            e += a;
            Console.WriteLine("e += - {0}", e);
            e -= a;
            Console.WriteLine("e -= - {0}", e);
            e *= a;
            Console.WriteLine("e *= a - {0}", e);
            e /= a;
            Console.WriteLine("e /= a - {0}", e);
            e %= a;
            Console.WriteLine("e %= a - {0}", e);
            e <<= a;
            Console.WriteLine("e <<= a - {0}", e);
            e >>= a;
            Console.WriteLine("e >>= a - {0}", e);
            e &= a;
            Console.WriteLine("e &= a - {0}", e);
            e ^= a;
            Console.WriteLine("e ^= a - {0}", e);
            e |= a;
            Console.WriteLine("e |= a - {0}", e);
        }

        // Misc
        public void MiscOpeators()
        {
            Console.WriteLine(sizeof(int));
            Console.WriteLine(typeof(int));
            Console.WriteLine("is operators = {0}", (a is object));
        }
    }
}
