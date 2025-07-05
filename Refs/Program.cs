class Program {
    public static void Main(string[] args) {
        /*
        int x = 5;
        ref int xRef = ref x;
        Console.WriteLine(x);
        xRef = 123;
        Console.WriteLine(x);
        */

        int[] numbers = { 1, 2, 3, 4, 5 };
        ref int numRef = ref FindIndex(numbers, 1);
        Console.WriteLine(numRef);
        Console.WriteLine(numbers[1]);
        numRef = 324;
        Console.WriteLine(numbers[1]);
    }

    public static ref int FindIndex(int[] numbers, int index) {
        for (int i = 0; i < numbers.Length; i++) {
            if (i == index) {
                return ref numbers[i];
            }
        }

        return ref numbers[0];
    }
}