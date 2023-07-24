//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write ("Введите число  M  :");
int m = int.Parse(Console.ReadLine());
Console.Write ("Введите число N  :");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int A = GetFunction (m,n);
Console.Write($"При значениях m={m}, n={n} -> A(m,n)= {GetFunction(m,n)}");

int GetFunction (int m, int n){
    if (m == 0) return n+1;
    else if (m>0 && n==0) return GetFunction (m -1, 1);
    else  return GetFunction(m - 1, GetFunction(m, n - 1));
}
