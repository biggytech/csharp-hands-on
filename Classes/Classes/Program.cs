using System;

namespace Program
{
    class Person
    {
        public string name;
        public int age = 18;

        public Person(): this("No Name")
        {
            Console.WriteLine("Constructor 1...");
        }

        public Person(string n): this(n, 18)
        {
            Console.WriteLine("Constructor 2...");
            Console.WriteLine($"Name is: {n}");
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person noName = new Person(); // C#9: Person tom = new ();
            noName.PrintInfo();
            new Person("Bob").PrintInfo();
            new Person("Tom", 34).PrintInfo();

            Person dylan = new Person("name") { age = 23, name = "Dylan" };
            dylan.PrintInfo();
        }    
    }
}