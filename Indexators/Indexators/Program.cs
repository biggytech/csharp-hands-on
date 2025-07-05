class Person
{
    public string Name { get; set; }
}

class People
{
    private Person[] data;
    public string Title { get; set; }

    public People()
    {
        data = new Person[5];
    }

    // indexer
    public Person this[int index, int justAnotherIndexCanBeHere]
    {
        get
        {
            return data[index];
        }

        set
        {
            data[index] = value;
        }
    }

    public string this[string prop]
    {
        get
        {
            if (prop == "title") return Title;
            return null;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        People people = new People {  Title = "test2"};
        people[0,0] = new Person { Name = "tom" };
        people[1,0] = new Person { Name = "bob" };
        Console.WriteLine(people[1,0]?.Name);
        Console.WriteLine(people["title"]);
    }
}