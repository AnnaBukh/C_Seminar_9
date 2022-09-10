// Задача 64. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// выполнить с помощью рекурсии 


Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

void ShowNumbers(int a)
{
    if (a > 1)
    {
        Console.Write($"{a} ");
        ShowNumbers(a - 1);
    }
    if (a == 1) 
    {
     Console.Write("1");
    }
    if (a < 1) 
    {
     Console.Write("введите корректное значение N");
    }
}
ShowNumbers(n);
