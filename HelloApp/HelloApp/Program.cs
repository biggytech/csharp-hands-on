/*
Console.Write("Введите свое имя: ");
string? name = Console.ReadLine();
Console.WriteLine($"Ваше имя {name}");

string name2 = "Tome";
Console.WriteLine(name2);
name2 = "Bob";
Console.WriteLine(name2);
*/

/*
// двоичная форма литералов
Console.WriteLine(0b01);
Console.WriteLine(0b11);

// шестандцатеричная
Console.WriteLine(0xA);
Console.WriteLine(0xF1);

// M * 10^p
Console.WriteLine(3.2e3);
Console.WriteLine(1.2e-1);

Console.WriteLine('P');
Console.Write('\t');
Console.WriteLine('P');
Console.WriteLine('\x78');
Console.WriteLine("\x78");
Console.WriteLine('\u0420');

Console.WriteLine("Привет \nмир");

// data types
bool isAlive = true;
byte bit = 123;
// byte bit2 = 256; // error
sbyte b = -128;
sbyte c = 127;
short d = 32767;
ushort e = 65535;
int f = 2147483647;
byte a = 0xFF; // but not 0xFFF
uint g = 4294967295;
long h = 1423432;
ulong k = 4643534534532948238;

// float, double, decimal
//char

object o1 = 123;
object o2 = "string";
object o3 = 3.14;

Console.WriteLine(isAlive);
Console.WriteLine(o1);
Console.WriteLine(o3);

float f1 = 3.14f;
decimal d1 = 213.8m;
uint u1 = 10u;
long l1 = 123123l;
ulong u2 = 1231231ul;
*/

/*
Console.WriteLine(u2);

Console.WriteLine("f1 {0}, d1 {1}", f1, d1);

Console.WriteLine("Возраст");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Рост");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Вес");
decimal weight = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"{age} {height} {weight}");
*/

/*
Console.WriteLine(10 / 4);
Console.WriteLine(10f / 4f);
Console.WriteLine(10 % 4);
*/

/*
int a = 3;
int b = 5;
int c = 40;
int d = c-- - b * a;    // a=3  b=5  c=39  d=25
Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");
*/

/*
int x1 = 2; // 010
int y1 = 5; // 101
Console.WriteLine(x1 & y1); // 000
Console.WriteLine(y1 | x1); // 111 = 7

int x2 = 4; // 100
int y2 = 5; // 101
Console.WriteLine(x2 & y2); // 100 = 4
Console.WriteLine(y2 | x2); // 101 = 5
*/

/*
int x = 45; //    0101101
int key = 102; // 1100110
int encrypt = x ^ key; // 1001011 = 75
int decrypt = encrypt ^ key;
Console.WriteLine($"{encrypt} {decrypt}");
*/

int x = 12; // 00001100
Console.WriteLine(~x); // 11110011 = -13 - доп код