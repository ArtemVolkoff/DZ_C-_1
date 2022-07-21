using System;

class Program 
{
  static void Pechat (int n)
  {
    for (int i=1; i<=n; i++ ) 
      {
        Console.Write(i*i*i);
        Console.Write(" ");
      }
  }
    static void Main(string[] args) 
    {
      Console.Write("Введите N:");
      int nn = Convert.ToInt32(Console.ReadLine());
      Pechat (nn);
    }
}

