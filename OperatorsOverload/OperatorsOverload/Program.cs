class Counter
{
    public int Value;

    public static Counter operator +(Counter c1, Counter c2)
    {
        return new Counter { Value = c1.Value + c2.Value };
    }

    public static bool operator >(Counter c1, Counter c2)
    {
        return (c1.Value > c2.Value);
    }

    public static bool operator <(Counter c1, Counter c2)
    {
        return c1.Value < c2.Value;
    }

    public static bool operator ==(Counter c1, Counter c2)
    {
        return c1.Value == c2.Value;
    }

    public static bool operator !=(Counter c1, Counter c2)
    {
        return c1.Value != c2.Value;
    }

    public static int operator +(Counter c1, int a)
    {
        return c1.Value + a;
    }

    public static Counter operator ++(Counter c1)
    {
        return new Counter { Value = c1.Value + 1 }; // inc/decr returns new class instance! (для пред- и пост- операторов)
    }

    public static bool operator true(Counter c1)
    {
        return c1.Value != 0;
    }

    public static bool operator false(Counter c1)
    {
        return c1.Value == 0;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Counter c1 = new Counter { Value = 1 };
        Counter c2 = new Counter { Value = 0 };
        Console.WriteLine(c1 > c2);
        Console.WriteLine(c1 < c2);
        Console.WriteLine(c1 == c2);
        Console.WriteLine(c1 != c2);

        Console.WriteLine((c1 + c2).Value);
        Console.WriteLine(c1 + 12);
        //c2++;
        //c2++;
        Console.WriteLine(c2.Value);

        if (c2) Console.WriteLine($"c2 is true");
        else Console.WriteLine("false");
    }
}