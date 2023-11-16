double a = 0, b = 0, c = 0;
int n1, n2, n3;

Console.WriteLine("Задайте кiлькiсть iтерацiй для а");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте кiлькiсть iтерацiй для b");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте кiлькiсть iтерацiй для с");
n3 = int.Parse(Console.ReadLine());
for (int i = 0; i <= n1; i++)
{
    a += -1.0 / 3 + 1.0 / 5 + System.Math.Pow(-1, i) / (2 * i + 1);
}
Console.WriteLine($"a = {a}");
for (int i = 1; i <= n2; i++)
{
    b += 1 + 1 / (i * i);
}
Console.WriteLine($"b = {b}");
for (int i = 1; i <= n3; i++)
{
    int Fact = 1;
    for (int j = 1; j <= i; j++)
    {
        Fact *= j;
    }
    c += Fact;
}
Console.WriteLine($"c = {c}");