class Program {
    public static void Main(string[] args) {
        /*
        int? z = null;
        int? a = 12;
        int b = 19;
        */
        
        /*
        PrintValue(z);
        PrintValue(a);
        PrintValue(b);
        */

        /*
        Console.WriteLine(z.GetValueOrDefault());
        Console.WriteLine(z.GetValueOrDefault(10));
        Console.WriteLine(a.GetValueOrDefault());
        // Console.WriteLine(b.GetValueOrDefault()); - not working for non-nullable!
        */

        // преобразования
        // E T? -> T
        /*
        int? x1 = 123;
        if (x1.HasValue) {
            int x2 = (int)x1;
            Console.WriteLine(x2);
        }
        */

        // I T -> T?
        /*
        int x1 = 123;
        int? x2 = x1;
        Console.WriteLine(x2);
        */

        // E T -> T?
        /*
        int x1 = 1234;
        int? x2 = (int?) x1;
        Console.WriteLine(x2);
        */

        long? x1 = 5;
        int x2 = (int)x1; // should check HasValue first
        Console.WriteLine(x2);

    }

    public static void PrintValue(int? num) {
        if (num.HasValue) {
            Console.WriteLine(num.Value);
            Console.WriteLine(num);
        } else {
            Console.WriteLine("Нет значения");
        }
    }
}