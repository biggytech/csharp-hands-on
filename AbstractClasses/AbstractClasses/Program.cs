abstract class Person
{
    public string Name { get; set; }
    public Person(string n)
    {
        Name = n;
    }
}

class Employee: Person
{
    public string Company { get; set; }
    public Employee(string n, string c): base(n)
    {
        Company = c;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee("Tom", "comp");
        // Person p = new Person("sdf"); cannot directly call abstract class constructor!
    }
}