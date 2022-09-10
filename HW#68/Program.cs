// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29
// формула :        n+1                 при m = 0
//          A(m,n)= A(m-1, 1)               m > 0, n = 0 
//                  A(m-1, A(m, n-1))       m > 0, n > 0  

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n ");
int n = int.Parse(Console.ReadLine());


int FunkAkkerman(int a, int b)
{
   if (a == 0) return (b + 1); // при m = 0, функция равна (n + 1)  
   if (a != 0 && b == 0) return FunkAkkerman(a - 1, 1); // при m не равно 0, n = 0 
   if (a > 0 && b > 0) return FunkAkkerman(a - 1, FunkAkkerman (a, b - 1)); //при m > 0, n > 0 
   return FunkAkkerman(a, b);
}

int result = FunkAkkerman(m, n);
Console.Write($"функция Аккермана А({m},{n}) равна: {result} ");