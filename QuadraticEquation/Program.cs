
using System.Globalization;

double a, b, c, d, x1, x2;
bool successA, successB, successC;


Console.WriteLine("Задайте значення а:");
do
{
    successA = double.TryParse(Console.ReadLine(), out a);
    if (!successA)
    {
        Console.WriteLine("Невірно задане значення а");
    }
} while (!successA);
Console.WriteLine("Задайте значення b:");
do
{
    successB = double.TryParse(Console.ReadLine(), out b);
    if (!successB)
    {
        Console.WriteLine("Невірно задане значення b");
    }
} while (!successB);
Console.WriteLine("Задайте значення c:");
do
{
    successC = double.TryParse(Console.ReadLine(), out c);
    if (!successC)
    {
        Console.WriteLine("Невірно задане значення c");
    }
} while (!successC);



if (a == 0)
{
    x1 = -c / b;
    Console.WriteLine($"X={x1}");
}
else
{
    d = b * b - 4 * a * c;

    if (d < 0)
    {
        Console.WriteLine("Коренiв немає");
    }
    else if (d == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine($"X={x1}");
    }
    else if (d > 0)
    {
        x1 = (-b + System.Math.Sqrt(d)) / (2 * a);
        x2 = (-b - System.Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"X1={x1}, X2={x2}");
    }
}
