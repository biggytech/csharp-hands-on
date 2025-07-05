class Program {
    public static void Main(string[] args) {
        Person p1 = new Person { Name = "Tom" };
        Console.WriteLine(p1);
        Person p2 = new Person("Alice");
        Console.WriteLine(p2);
        Person p3 = new Person("Bob");
        // p3.Name = "Bob Second"; - error because of init keyword!
        Console.WriteLine(p3);
    }

    class Person {
        private string name;
        // public string Name { get; init; }
        public string Name {
            get => name;
            init {
                name = $"name is {value}";
            }
        }

        public Person() {} // needed for object initializer

        public Person(string n) {
            Name = n;
        }

        public override string ToString() {
            return Name;
        }
    }
}