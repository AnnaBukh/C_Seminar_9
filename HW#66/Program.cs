// Задайте значения M и N . Напишите программу, которая найдет сумму натуральных элементов
// в промежутке от M до N

Console.WriteLine("Введите целое положительное число M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N : ");
int n = int.Parse(Console.ReadLine());


int SumNumbers(int a, int b)
{
   if (a == b) return a;// если указывать 0, то сумма по след пунктам не верная получается(не берется одно число), а как исправить недопетрила
   else if (a < b) return (b + SumNumbers(a, b - 1));
   else return (b + SumNumbers(a, b + 1)); 
}

int result = SumNumbers(m, n);
Console.Write($"сумма элементов от {m} до {n} равна: {result} ");

