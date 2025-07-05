class MathLib
{
    public readonly double K = 8.7;
    public const double PI = 3.14;
    //public static double K;

    public MathLib(double k)
    {
        K = k;
    }

    public void method()
    {
        const double x = 1.12;
        Console.WriteLine(x);
        Console.WriteLine(K);
        //K = 123;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MathLib.PI);
        MathLib m = new MathLib(324);
        m.method();
        //Console.WriteLine(m.PI);
    }
}

readonly struct User
{
    public readonly int Id;
    public int Age { get; }
}