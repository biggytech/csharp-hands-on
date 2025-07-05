class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person(string n)
    {
        Name = n;
    }

    public void Display()
    {
        Console.WriteLine(Name);
    }
}

class Employee: Person
{
    public string Company { get; set; }
    public void Display()
    {
        Console.WriteLine($"Overrided: {Name}");
    }

    public Employee(string n, string c): base(Employee.getInhName(n))
    {
        Company = c;
    }

    public static string getInhName(string n)
    {
        return $"test - {n}";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        /*
        //Employee e = new Employee { Name = "Tom" }; // Person name = new Employee() ! - можно использовать так, но это не равноценно !
        Employee e = new Employee("tom", "Cars");
        e.Display();
        */

        // 1
        Person p = new Person("Alla"); //new Employee("Alla", "comp")
        Employee e = p as Employee;
        if (e == null)
        {
            Console.WriteLine("Преобразование неудачно");
        } else
        {
            Console.WriteLine(e.Company);
        }

        //2 
        try
        {
            Employee e2 = (Employee)p;
            Console.WriteLine(e2.Company);
        } catch(InvalidCastException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //3
        if (p is Employee)
        {
            Employee e3 = (Employee)p;
            Console.WriteLine(e3.Company);
        } else
        {
            Console.WriteLine("not employee");
        }
    }
}

sealed class Admin // non-inheritable class
{

}