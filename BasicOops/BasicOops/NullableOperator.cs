using System;
namespace BasicOops
{
    public class NullableOperator
    {
        public void TestNullable()
        {
            int? a = 423;
            int? b = 123;
            int defaultValueOfa, defaultValueOfb;
            Console.WriteLine(a);
            a = null;
            Console.WriteLine("a is Nullable? = {0}", a is null);
            Console.WriteLine("b is Nullable? = {0}", b is null);
            defaultValueOfa = a ?? 20;
            defaultValueOfb = b ?? 10;
            Console.WriteLine("defaultValueOfa = {0}", defaultValueOfa);
            Console.WriteLine("defaultValueOfb = {0}", defaultValueOfb);
        }
    }
}

