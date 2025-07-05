class Program
{
    public static void Main(string[] args)
    {
        /*
        try
        {
            int x = 5;
            int y = x / 0;
            Console.WriteLine("Конец");
        }
        catch // catch(DivideByZeroException ex) or catch(DivideByZeroException)
        {
            Console.WriteLine("Exception");
            //Console.WriteLine(ex.Message);
        } finally
        {
            Console.WriteLine("finally");
        }

        int num;
        string input = Console.ReadLine();

        if (Int32.TryParse(input, out num))
        {
            Console.WriteLine(num);
        } else
        {
            Console.WriteLine("Wrong input");
        }

        int x2 = 1;
        
        try
        {
            int y2 = x2 / 0;
            Console.WriteLine("Конец");
        }
        // CATCH WORKS ONLY ONCE!
        catch(DivideByZeroException) when (x2 == 1)
        {
            Console.WriteLine("Exception");
            //Console.WriteLine(ex.Message);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("finally");
        }
        */

        try
        {
            int[] numbers = new int[4];
            numbers[7] = 9;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("IndexOutOfRange");
            int y = 5;
            int x = y / 0;
        }
        catch (DivideByZeroException) // not get called
        {
            Console.WriteLine("DivideByZero");
        }
        catch
        {
            Console.WriteLine("ex");
        }
    }
}