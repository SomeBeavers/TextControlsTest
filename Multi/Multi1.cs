using System;

namespace Multi
{
    public class Multi1
    {
        // comment is here

#if NET6_0
        public void Test()
        {
            Console.WriteLine();
        }
#else
        public void Test2()
        {
            int t = 1;
            Console.WriteLine(t);
        }

#endif
    }
}
