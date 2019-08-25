using System;
namespace BasicOops
{
    public class StringsExample
    {
        // defining string
        string first_name = "Partha";
        string last_name = "Saradhi";

        public string getFullName()
        {
            string temp = first_name + " " + last_name;
            return temp;
        }

        public void Display()
        {
            Console.WriteLine(getFullName());
        }
    }
}
