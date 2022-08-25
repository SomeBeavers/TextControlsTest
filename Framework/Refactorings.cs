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
            CopyPasteMe();
            return null;
        }

        private static void CopyPasteMe()
        {
        }
    }

    internal class MyInnerClass
    {
    }
}