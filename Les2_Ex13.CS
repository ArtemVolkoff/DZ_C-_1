using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите число");
      string x = Console.ReadLine();
      int symbol=3;
      if (x.Length < symbol)
      {
        Console.WriteLine("Третьей цифры нет.");
      }
      else
      {
        Console.WriteLine("Третья цифра введенного числа: ");
      Console.WriteLine(x[2]);
      }
      
    }
}
