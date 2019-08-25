using System;
namespace BasicOops
{
    public class structureexample
    {
        struct Employee
        {
            public string name;
            public int employeeid;
            public string description;
        }
        

        public void Display()
        {
            Employee partha = new Employee();
            partha.name = "Partha Saradhi";
            partha.employeeid = 123;
            partha.description = "new employee";

            Console.WriteLine("name of the employee: {0}", partha.name);
            Console.WriteLine("empid of the employee: {0}", partha.employeeid);
            Console.WriteLine("description of the employee: {0}", partha.description);
        }
    }
}
