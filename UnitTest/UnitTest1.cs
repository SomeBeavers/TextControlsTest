namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            NameOfTest = "try catch test";
            try
            {
                Assert.Pass();
            }
            catch (Exception myException)
            {
                Console.WriteLine(myException);
                throw;
            }
        }

        public string NameOfTest { get; set; }
    }
}