// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 6");
Console.WriteLine("Четное ли число?");
Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число нечетное");
};
