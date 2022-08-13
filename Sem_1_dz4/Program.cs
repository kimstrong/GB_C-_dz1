// See https://aka.ms/new-console-template for more information
Console.WriteLine("Вывод всех четных чисел до заданного числа");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    while (number>2)
    {
        number-=2;
        Console.Write(number + " ");
    }
    
}
else 
{
    number=number-1;
    Console.Write(number + " ");
    while (number>2)
    {
        number-=2;
        Console.Write(number + " ");
    }
    
}
