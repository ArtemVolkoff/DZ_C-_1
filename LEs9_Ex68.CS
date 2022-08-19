using System;

class Program
{
    static double Ak(double a, double b)
    {
     if (a == 0) return b+1;
     if (a > 0 && b == 0) return Ak(a-1,1); 
     if (a > 0 && b > 0) return Ak(a-1,Ak(a,b-1)); 
     return Ak(a,b);
    }
  
    static void Main(string[] args)
    {
      Console.Write("Введите m: ");
      double m = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите n: ");
      double n = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(Ak(m,n));

    }
  
}  

