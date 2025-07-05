namespace MyLib
{
    public class Person
    {
        static Person()
        {
            Console.WriteLine("Создан первый Person");
        }

        public string name;
        public int age;
        //public string autoVal = "Cocoo";

        private string privName;
        public string pubName
        {
            get
            {
                return privName;
            }
            set
            {
                privName = value;
            }
        }

        public string autoVal { get; set; } = "CoCoo";
        public string rOnly { get; }

        public Person(string r)
        {
            rOnly = r;
        }
    }
    public static class Math
    {
        static void printStaticMethod()
        {

        }

        //void testMethod()
        //{

        //}
    }
}