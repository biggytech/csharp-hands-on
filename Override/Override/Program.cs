class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine(Name);
    }
}

class Employee: Person
{
    public string Company { get; set; }

    public Employee(string name, string company): base(name)
    {
        Company = company;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"{Name}, {Company}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee("Tom", "comp");
        e.Display();
    }
}