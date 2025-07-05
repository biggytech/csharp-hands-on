class Account<T>
{
    private T id = default(T);
    public T Id { get; set; } = default(T);
    public int Sum;
}

class Program
{
    public static void Main(string[] args)
    {
        Account<int> acc = new Account<int> { Sum = 100 };
        Transaction<Account<int>, int> tx = new Transaction<Account<int>, int> { Acc = acc, Sum = 20 };
        Console.WriteLine(tx.Acc.Sum);
        Console.WriteLine(tx.Acc.Id);
        tx.Execute(new Account<int> { Sum = 10 });
    }
}

class Transaction<U, V> where U: Account<int>
{
    // multiple generic parameters
    public U Acc { get; set; }
    public int Sum { get; set; }

    public void Execute<T>(T acc2) where T: Account<int>
    {
        if (Acc.Sum >= Sum)
        {
            Acc.Sum -= Sum;
            Acc.Sum -= acc2.Sum;
            Console.WriteLine($"Acc: {Acc.Sum}, sum: -{Sum}");
        }
    }
}