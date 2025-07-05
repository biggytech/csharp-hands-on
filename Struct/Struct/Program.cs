struct User
{
    public string name;
    public int age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, age: {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        User tom;
        tom.age = 18;
        tom.name = "Tom";
        tom.DisplayInfo();
    }
}