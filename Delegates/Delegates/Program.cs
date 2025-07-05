class Program
{
    delegate void Message();

    public static void Main(string[] args)
    {
        Message me = Morning;

        /*
        if (DateTime.Now.Hour < 12)
        {
            me = Morning;
        } else
        {
            me = Night;
        }
        */
        me -= Morning;
        me = Morning;
        me += Night;
        me += Morning;
        me = new Message(Morning) + new Message(Night);

        me?.Invoke();
    }

    private static void Morning()
    {
        Console.WriteLine("morning");
    }

    private static void Night()
    {
        Console.WriteLine("night");
    }
}