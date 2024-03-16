// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.WriteLine("Введите первое число");
//string num1Str = Console.ReadLine();
//int numb1 = Convert.ToInt32(num1Str);
int numb1 = Convert.ToInt32(Console.ReadLine())!;
Console.WriteLine("Введите второе число");
int numb2 = Convert.ToInt32(Console.ReadLine())!;

// int numb1 = 25;
// int numb2 = 5;


if (numb1 == numb2 * numb2)
{
    Console.WriteLine("Число является квадратом второго");
}
else
{
    Console.WriteLine("Число не является квадратом второго");
}
