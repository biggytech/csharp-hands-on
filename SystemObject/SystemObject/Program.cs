class Person
{
    public string Name { get; set; }
    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Person p = new Person { Name = "Tom" };
        Person p2 = new Person { Name = "Tom" };
        Console.WriteLine(p.GetHashCode());
        Console.WriteLine(p2.GetHashCode());
        Console.WriteLine(p.Equals(p2));
    }
}