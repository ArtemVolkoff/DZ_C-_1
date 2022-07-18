using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите число, обозначающее день недели");
      int x = Convert.ToInt32(Console.ReadLine());

      
      if (x == 6)
      {
        Console.WriteLine("Это выходной день");
      }
      else
      if (x == 7)
        {
        Console.WriteLine("Это выходной день");
      }
      else
        Console.WriteLine("Это будний день ");
      
    }
}
