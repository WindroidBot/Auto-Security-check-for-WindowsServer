using System;
using ClassLibrary;

namespace TEST_DemoDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass();
            test.DemoDLL();
            Console.ReadLine();
        }
    }
}
