// Lilia.Shamsutdinova

namespace Framework
{
    public class Refactorings
    {
        public void UseTest()
        {
            Test();
        }

        private MyInnerClass Test(/*caret*/)
        {
            return a_renamed;
        }
    }

    internal class MyInnerClass
    {
    }
}