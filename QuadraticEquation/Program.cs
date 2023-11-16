
double a, b, c, d, x1, x2;
Console.WriteLine("Задайте значення а:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте значення b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте значення c:");
c = double.Parse(Console.ReadLine());
if (a == 0)
{
    x1 = -c / b;
    Console.WriteLine($"X={x1}");
}
else
{
    d = b*b - 4 * a * c;
    if (d < 0)
        Console.WriteLine("Коренів немає");
    if (d == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine($"X={x1}");
    }
    if (d > 0)
    {
        x1 = -b + System.Math.Sqrt(d) / (2 * a);
        x2 = -b - System.Math.Sqrt(d) / (2 * a);
        Console.WriteLine($"X1={x1}, X2={x2}");
    }

}
