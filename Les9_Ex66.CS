using System;

class Program
{
    static string NumbersRec(int a, int b)
    {
     if (a <= b) return NumbersRec(a,b-1) + $"{b}, ";
     else return string.Empty;
    }
  
    static void Main(string[] args)
    {
      Console.Write("Введите m: ");
      int m = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите n: ");
      int n = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine( NumbersRec(m,n) );
    }
  
}
