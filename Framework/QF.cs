using System.Text.RegularExpressions;

namespace Framework
{
    public class Qf
    {
        public Qf(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Test(string result)
        {
            result = Regex.Replace(result, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);
            Qf2 qf2;
            qf2 = new Qf2(Name)
            {
                Age = 1,
                IsAnimal = false,
                IsAnimal2 = "false"
            };

            var qf4 = new Qf2(Name);

            MyLocalFunc(qf2);

            void MyLocalFunc(Qf2 qf3)
            {
                return;
            }
        }
    }
}