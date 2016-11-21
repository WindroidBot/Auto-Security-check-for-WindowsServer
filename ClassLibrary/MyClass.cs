using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MyClass
    {
        public MyClass()
        {

        }
        public void DemoDLL()
        {
            Console.WriteLine("调用了dll动态链接库");
        }
    }
}
