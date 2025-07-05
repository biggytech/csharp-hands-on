/*
byte a = 4;
byte b = (byte)(a + 70);
*/

/*
try
{
    int a = 33;
    int b = 600;
    byte c = checked((byte)(a + b));
    Console.WriteLine(c);
} catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
*/

/*
string name = "Tom";

// C# doesn't allow to miss 'break' statements!!!
switch (name)
{
    case "Bob":
        Console.WriteLine("Ваше имя - Bob");
        break;
    case "Tom":
        Console.WriteLine("Ваше имя - Tom");
        goto case "Bob";
    case "Sam":
        Console.WriteLine("Ваше имя - Sam");
        break;
}
*/

foreach(char c in "Tom")
{
    if (c == 'o') continue;
    Console.WriteLine($"{c} ");
}