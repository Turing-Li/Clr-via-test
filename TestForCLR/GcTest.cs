using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestForCLR
{
    class GcTest
    {
        public static void GcTestFunc(object o)
        {
            Thread.Sleep(1000);
            Console.WriteLine("CurrentThreadId: {0}",Thread.CurrentThread.ManagedThreadId);

        }
    }
}
