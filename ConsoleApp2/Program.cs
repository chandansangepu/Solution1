// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
}
// 2nd program
Console.WriteLine("Enter String");
string abc = Console.ReadLine();
string result = string.Empty;
if (!string.IsNullOrEmpty(abc))
{
    for (int j = abc.Length - 1; j >= 0; j--)
    {
        result += abc[j];
    }
}
Console.WriteLine(result);