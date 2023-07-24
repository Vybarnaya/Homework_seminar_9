// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//  = 4; N = 8. -> 30
Console.Write ("Введите число  M  :");
int m = int.Parse(Console.ReadLine());
Console.Write ("Введите число N (больше, чем M) :");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
if ( m>n){
  Console.WriteLine("Неверно введено число N. Введите число N (больше, чем M)");
}
Console.WriteLine();
FindSumElements (m, n);
Console.WriteLine(FindSumElements (m, n));

int FindSumElements (int m, int n)
{
  int sum =m;
  if (m == n) return n;
  else{
    m++;
    sum  = sum + FindSumElements (m, n);
    
  }
  return sum ;
}
    
