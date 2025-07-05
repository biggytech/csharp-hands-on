using Acc = Namespaces.AccountSpace.Account; // important!
using static System.Console;
using MyLib;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Acc a = new Acc();
            WriteLine("Test");
            ReadLine();

            /*
            Person person = new Person { name = "Tom", age = 23, autoVal = "ttt"};
            Console.WriteLine(person.name);
            person.pubName = "blah";
            WriteLine(person.pubName);
            WriteLine(person.autoVal);
            */
            Person person = new Person("sfsdfsdf");
            Person p = new("sdfsdf");
            WriteLine(person.rOnly);
            //person.rOnly = "sdfsdfsfdsdf";
        }
    }

    namespace AccountSpace
    {
        class Account
        {

        }
    }
}