class Program
{
    delegate void Handler(string mes);
    static event Handler Notify;
    public static void Main(string[] args)
    {
        Notify += showMessage;

        Notify("test event");
    }

    public static void showMessage(string mes)
    {
        Console.WriteLine($"Message: {mes}");
    }
}