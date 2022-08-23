using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    internal class Shared_1
    {
        public int MyField { get; private set; }

        public void Test()
        {
            Console.WriteLine();
        }

#if NET6_0
        public void MethodForNet6()
        {
            MyField = 1;
        }
#endif
    }
}
