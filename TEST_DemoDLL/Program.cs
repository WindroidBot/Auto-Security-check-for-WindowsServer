using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
