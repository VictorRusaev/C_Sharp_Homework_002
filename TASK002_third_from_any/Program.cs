Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(Math.Abs(number) > 99)
    Console.WriteLine(Math.Abs(number) / 100 % 10);
else Console.Write("Третьей цифры нет");


// Если я ввожу число больше девяти знаков,
// мне выдаётся следующее сообщение:
// Unhandled exception. System.OverflowException: Value was either too 
// large or too small for an Int32.
//    at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
//    at System.Int32.Parse(String s)
//    at Program.<Main>$(String[] args) in C:\Users\admin\Desktop\Разработчик. GeekBrains\Введение в язык С#\Homeworks\Homework_002\TASK002_third_from_any\Program.cs:line 4
// PS C:\Users\admin\Desktop\Разработчик. GeekBrains\Введение в язык С#\Homeworks\Homework_002\TASK002_third_from_any>