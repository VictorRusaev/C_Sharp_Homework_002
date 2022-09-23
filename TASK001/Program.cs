Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if((number > 99) && (number < 1000))
    Console.WriteLine(number / 10 % 10);
else Console.Write("Вы ввели не трёхзначное число!");
