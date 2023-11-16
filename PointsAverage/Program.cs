Console.WriteLine("Введіть бали учня");
int score;
int count = 0;
int result = 0;
while (count != 5)
{
    score = int.Parse(Console.ReadLine());
    count++;
    result += score/5;
}
if (result >= 50)
    Console.WriteLine("Студента допущено до екзамену");
else
{
    Console.WriteLine("Студента не допущено до екзамену");
}
