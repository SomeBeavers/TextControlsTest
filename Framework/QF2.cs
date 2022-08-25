namespace Framework
{
    public class Qf2
    {
        public Qf2(string name)
        {
            throw new System.NotImplementedException();
        }

        public Qf2():this("Jane Doe")
        {
            string localName = "Bob";
            var qf4 = new Qf2(localName);
        }

        public int Age { get; set; }
        public bool? IsAnimal { get; set; }

        public string IsAnimal2 { get; set; }
    }
}

// comment