// Lilia.Shamsutdinova

using Newtonsoft.Json;

namespace TestNamespace;

public class UseNuget:A
{
    public void Test()
    {
        JsonReader jr = null;
    }

    public void UseTest(MyInnerClass someMember)
    {
        Test();
        var name = someMember?.Name;
        if (name != null)
        {
            Console.WriteLine(name);
        }

        _ = new Foo().Bar(2002);




    }

    class Foo {
        public int Bar(int value) => 3003;
    }
}

public class MyInnerClass
{
    public string Name { get; set; }
}

public class A
{
}