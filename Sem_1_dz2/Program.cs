// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 4");
Console.WriteLine("Вывод максимального из трех чисел");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1>number2 && number1>number3)
{
    Console.Write("Максимальное число: " + number1);
}
if (number2>number1 && number2>number3)
{
    Console.Write("Максимальное число: " + number2);
}
if (number3>number1 && number3>number2)
{
    Console.Write("Максимальное число: " + number3);
}
if (number1==number2 && number1>number3)
{
     Console.Write("Максимальное число: " + number1);
}

if (number3==number2 && number3>number1)
{
     Console.Write("Максимальное число: " + number3);
}

if (number3==number1 && number3>number2)
{
     Console.Write("Максимальное число: " + number3);
}