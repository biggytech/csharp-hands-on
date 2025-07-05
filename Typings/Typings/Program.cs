class Counter
{
    public int Seconds { get; set; }

    public static implicit operator Counter (int x)
    {
        return new Counter {  Seconds = x };
    }

    public static explicit operator int (Counter c)
    {
        return c.Seconds;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Counter c = new Counter { Seconds = 23 };
        int x = (int)c;
        Console.WriteLine(x);

        Counter c2 = x;
        Console.WriteLine(c2.Seconds);
    }
}