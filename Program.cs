// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Clear();
string[] ArrayFirst = new string[] { "one", "two", "three", "four", "fife", "six", "seven", "eight", "nine" };
string[] ArrayItog = new string[ArrayFirst.Length];
int MaxStringLength = 3;

for (int count = 0; count < ArrayFirst.Length; count++)
{
    if (ArrayFirst[count].Length <= MaxStringLength)
    {
        ArrayItog[count] = ArrayFirst[count];
    }
    else ArrayItog[count] = "";
    Console.Write($"{ArrayItog[count]} ");
}
