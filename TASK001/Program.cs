Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if((number > 99) && (number < 1000))
{
    int firstNumber = number % 10;
    int secondNumber = number / 10 % 10;
    int lastNumber = number / 100;
    Console.WriteLine(secondNumber);
}
else Console.Write("Вы ввели не трёхзначное число!");
