enum Days
{
    Monday,
    Tuesday,
    Wednesday,
}

enum Time: byte
{
    Morning,
    Afternoon
}

enum Nums
{
    One = 1,
    Two,
    Three
};

enum Operation
{
    Add = 1,
    Multiply = 3,
    Divide = 3,
    Modulo = 2,
    Subtract = Modulo
}

class Program
{
    static void Main(string[] args)
    {
        /*
        Operation op = Operation.Divide;
        //Operation op = (Operation)2;
        Console.WriteLine(op);
        Console.WriteLine((int)op);
        */

        /*
        //var tuple = (10, 5);
        (string, int) tuple = ("Tom",5);
        Console.WriteLine(tuple.Item1);
        Console.WriteLine(tuple.Item2);

        var tuple2 = (age: 23, name: "Bob");
        Console.WriteLine(tuple2.Item1);
        Console.WriteLine(tuple2.age);
        Console.WriteLine(tuple2.name);
        var (age, name2) = tuple2;
        Console.WriteLine(name2);
        Console.WriteLine(age);
        tuple2.age = 34; // age not changed
        Console.WriteLine(age);
        */

        Console.WriteLine(returnCortege());
        Console.WriteLine(getNamedTuple().sum);
        passTuple((b: 33, n: 4)); // order main!
    }

    private static (int, int) returnCortege()
    {
        return (1, 2);
    }

    private static (int sum, int num) getNamedTuple()
    {
        var tuple = ( sum: 4, num: 5);
        return tuple;
    }

    private static void passTuple((int n, int b) tuple)
    {
        Console.WriteLine(tuple);
        Console.WriteLine(tuple.n);
        Console.WriteLine(tuple.b);
    }
}
