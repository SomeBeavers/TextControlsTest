// Lilia.Shamsutdinova

namespace Framework
{
    public class Refactorings
    {
        public void UseTest()
        {
            Test();
        }

        private MyInnerClass Test()
        {
            return a;
        }
    }
}