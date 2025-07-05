class Program {
    public static void Main(string[] args) {
        /*
        Person person = new Person { Name = "Tom" };
        person.Name = "Bob";
        Console.WriteLine(person.Name);
        */

        /*
        Person p1 = new Person { Name = "Tom" };
        Person p2 = new Person { Name = "Tom" };
        Console.WriteLine(p1.Equals(p2));

        User u1 = new User { Name = "Tom" };
        User u2 = new User { Name = "Tom" };
        Console.WriteLine(u1.Equals(u2));
        */

        /*
        Person p1 = new Program.Person { Name = "Tom", Age = 24 };
        Person p2 = p1 with { Name = "Sam" };
        Console.WriteLine($"{p1.Name} - {p1.Age}");
        Console.WriteLine($"{p2.Name} - {p2.Age}");
        */

        PosPerson p = new Program.PosPerson("Tom", 23);
        var (name, age) = p;
        Console.WriteLine(name);
        Console.WriteLine(age);
    }

    public record PosPerson(string Name, int Age);

    // public record Person {
    //     public int Age { get; set; }
    //     public string Name { get; set; }
    // }

    // public class User {
    //     public string Name { get; set; }
    // }
}