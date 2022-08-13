// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 2");
Console.WriteLine("Вывод максимального из двух чисел");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.Write("Максимальное число: " + number1);
}
else 
{
    Console.Write("Максимальное число: " + number2);
}
