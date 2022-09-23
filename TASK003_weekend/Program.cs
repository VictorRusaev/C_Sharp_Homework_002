Console.Clear();

Console.WriteLine("Введите число от 1 до 7");
int weekday = int.Parse(Console.ReadLine());

if((weekday < 1) ^ (weekday > 7))
    Console.WriteLine("Вы ввели число не от 1 до 7");
else if((weekday == 6) ^ (weekday == 7))
    Console.Write("выходной");
else Console.Write("будний");
