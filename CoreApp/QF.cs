// Lilia.Shamsutdinova

namespace TestNamespace;

public class QF
{
    // TODO: test
    public string Name { get; set; }
    
    // TODO: test 2
    public void Test()
    {
        Console.WriteLine("");
        int test_t = 1;
        int test_t1 = 1;
        int test_t2 = 1;
    }

    enum SomeEnum
    {
        A,
        B,
        C
    }

    public static void Main()
    {
        var e = SomeEnum.C;
        var s = SomeEnum.A;
        var t = SomeEnum.B;

        Console.WriteLine(e is not SomeEnum.A or SomeEnum.B);
    }
}