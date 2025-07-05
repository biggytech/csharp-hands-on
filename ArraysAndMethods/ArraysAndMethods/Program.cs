/*
int[] numbers = new int[4];
numbers[1] = 123;

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

int[] nums = { 1, 2, 3 };
// ERROR
// nums[4] = 123;
string[] people = { "Tom", "Andy" };
Console.WriteLine(people.Length);

Console.WriteLine(people[^1]); // последний с конца
*/

/*
// МНОГОМЕРНЫЕ МАССИВЫ
int[,] nums = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
Console.WriteLine(nums.Length);
foreach(int i in nums)
{
    Console.WriteLine(i);
}

int rowsLength = nums.GetUpperBound(0) + 1;
Console.WriteLine(rowsLength);
int colsLength = nums.Length / rowsLength; // nums.GetUpperBound(1) + 1;
Console.WriteLine(colsLength);

for (int i = 0; i < rowsLength; i++)
{
    for (int j = 0; j < colsLength; j++)
    {
        Console.Write($"{nums[i, j]} ");
    }
    Console.WriteLine();
}
*/

// МАССИВ МАССИВОВ (зубчатый)
//int[][] nums = new int[2][];
//nums[0] = new int[] { 1, 2 };
//nums[1] = new int[] { 3, 4, 5 };

int[][] nums = { 
    new int[] { 1, 2, 3},
    new int[] {4, 5}
};

foreach(int[] row in nums)
{
    foreach(int num in row)
    {
        Console.Write($"{num} ");
    }
    Console.WriteLine();
}

for(int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j <nums[i].Length; j++)
    {
        Console.Write($"{nums[i][j]} ");
    }
    Console.WriteLine();
}