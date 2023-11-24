Console.WriteLine("Введiть бали учня");
int score;
int count = 0;
int result = 0;
while (count != 5)
{
    if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
    {
        count++;
        result += score / 5;
    }
    else
    {
        Console.WriteLine("Некоректне введення. Будь ласка, введiть цiле число вiд 0 до 100");
    }
}
if (result >= 50)
    Console.WriteLine("Студента допущено до екзамену");
else
{
    Console.WriteLine("Студента не допущено до екзамену");
}
