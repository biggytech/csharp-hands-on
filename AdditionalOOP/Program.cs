/*
var user = new { Name = "Tom", Age = 34 };
var user2 = new { Name = "Bob", Age = 23 };
var user3 = new { Name = "Alice", Age = 20, Company = "Microsoft" };
// user.Name = "Tom2"; - Not available
Console.WriteLine(user.Name);
Console.WriteLine(user.GetType().Name);
Console.WriteLine(user2.GetType().Name);
Console.WriteLine(user3.GetType().Name);
*/

class User {
    public string Name { get; set; }
}

class Employee {
    public virtual void Work() {
        Console.WriteLine("Я работаю");
    }
}

class Manager : Employee {
    public override void Work() {
        Console.WriteLine("Отлично, работаем дальше!");
    }

    public bool IsOnVacation { get; set; }
    public string Role { get; set; }

    // At least two out parameters!
    public void Deconstruct(out string lang, out string daytime) {
        lang = "eng";
        daytime = "m";
    }
}

class Program {
    public static void Main(string[] args) {
        /*
        User user = new User { Name = "Alice" };
        Console.WriteLine(user.Name);

        // projection initializer
        var person = new {user.Name, Age = 20 };
        Console.WriteLine(person.Name);
        */

        /*
        var people = new[] {
            new { Name = "Bob" },
            new {
                Name = "Alice", 
                // Age = 32 - not supported for untyped array
            }
        };

        foreach(var person in people) {
            Console.WriteLine(person.Name);
        }
        */

        Manager manager = new Manager { IsOnVacation = false };
        Manager manager2 = new Manager { IsOnVacation = true };
        Manager manager3 = new Manager { IsOnVacation = false, Role = "admin" };
        Employee employee = new Employee();

        /*
        UseAsManager1(manager);
        UseAsManager2(manager);
        UseAsManager3(manager);

        UseAsManager1(employee);
        UseAsManager2(employee);
        UseAsManager3(employee);
        */

        /*
        UseAsManager4(manager);
        UseAsManager4(manager2);
        UseAsManager4(employee);
        UseAsManager4(null);
        */

        /*
        Console.WriteLine(GetMessage(manager));
        Console.WriteLine(GetMessage(manager2));
        Console.WriteLine(GetMessage(manager3));
        Console.WriteLine(GetMessage(null));
        */

        /*
        Console.WriteLine(GetWelcome("fr", "m"));
        Console.WriteLine(GetWelcome("eng", "n"));
        Console.WriteLine(GetWelcome("eng", "m"));
        Console.WriteLine(GetWelcome("eng", "e"));
        Console.WriteLine(GetWelcomeManager(manager)); // manager deconstruction
        */

        /*
        Console.WriteLine(GetSum(-10));
        Console.WriteLine(GetSum(12));
        Console.WriteLine(GetSum(101));
        Console.WriteLine(GetSum(200));
        Console.WriteLine(GetSum(203));
        */

        // Deconstructors
        (string a, string b) = manager;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }

    static void UseAsManager1(Employee emp) {
        Manager manager = emp as Manager;
        if (manager != null) {
            if (!manager.IsOnVacation) {
                manager.Work();
            }
        } else {
            Console.WriteLine("Преобразование неудачно");
        }
    }

    static void UseAsManager2(Employee emp) {
        try {
            Manager manager = (Manager)emp;
            if(!manager.IsOnVacation) {
                manager.Work();
            }
        } catch(InvalidCastException ex) {
            Console.WriteLine(ex.Message);
        }
    }

    static void UseAsManager3(Employee emp) {
        if (emp is Manager) {
            Manager manager = (Manager)emp;
            if (!manager.IsOnVacation) {
                manager.Work();
            }
        } else {
            Console.WriteLine("Преобразование недопустимо");
        }
    }

    static void UseAsManager4(Employee emp) {
        // pattern matching - preferable
        /*
        if (emp is Manager manager) {
            if (!manager.IsOnVacation) {
                manager.Work();
            }
        } else {
            Console.WriteLine("Преобразование недоступно");
        }
        */
    
        switch(emp) {
            case Manager manager when !manager.IsOnVacation:
                manager.Work();
                break;
            case Manager manager when manager.IsOnVacation:
                Console.WriteLine("На отдыхе");
                break;
            case null:
                Console.WriteLine("Объект не задан");
                break;
            default:
                Console.WriteLine("Не менеджер");
                break;
        }
    }

    static string GetMessage(Manager manager) => manager switch {
        { IsOnVacation: true } => "На отдыхе!",
        { IsOnVacation: false, Role: "admin", Role: var role } => $"Админ {role} работает!",
        { IsOnVacation: false } => "Работаем!",
        //{ Role: var role } => $"Неизвестная роль {role}",
        null => "null"
        // { } => "undefined" - default case
    };

    static string GetWelcome(string lang, string daytime) => (lang, daytime) switch {
        ("eng", "m") => "Good Morning",
        ("eng", "n") => "Good night",
        ("fr", _) => "French greeting",
        (_, "e") => "Evening!",
        _ => "Not defined greeting"
    };

    static string GetWelcomeManager(Manager manager) => manager switch {
        (var lang, "m") => $"Good Morning by {lang}",
        // ("eng", "n") => "Good night",
        // ("fr", _) => "French greeting",
        // (_, "e") => "Evening!",
        _ => "Not defined greeting"
    };

    static int GetSum(int num) => num switch {
        <= 0 => 0,
        < 100 => num + 100,
        > 100 and < 200 => 200 + num,
        not 200 => 204,
        _ => num  
    };
}