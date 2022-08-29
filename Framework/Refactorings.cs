// Lilia.Shamsutdinova

using System.Text.RegularExpressions;

namespace Framework
{
    public class Refactorings
    {
        private string thisIsBackingFiledAndNoBlinkingCoooooool;

        public void UseTest()
        {
            Test();
        }

        private MyInnerClass Test(/*caret*/)
        {

            //result = Regex.Replace(result, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);
            //Regex

            CopyPasteMe();
            return null;
        }

        private static void CopyPasteMe()
        {
        }

        public string Name
        {
            get => thisIsBackingFiledAndNoBlinkingCoooooool;
            set => thisIsBackingFiledAndNoBlinkingCoooooool = value;
        }
    }

    internal class MyInnerClass
    {
    }
}