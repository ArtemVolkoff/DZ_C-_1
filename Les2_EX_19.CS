using System;

class Program 
{
    static void Main(string[] args) 
    {
      Console.Write("Введите пятизначное число: ");
      int x = Convert.ToInt32(Console.ReadLine());
      int xx = x;
      int[] array = new int[5];
      for (int i=0; i<5; i++ ) 
      {
        array[4-i] = xx%10;
        xx=xx/10;
      }
      if (array[0]==array[4] && array[1]==array[3]) Console.WriteLine("Введенное число является полиндромом");
      else Console.WriteLine("Введенное число не является полиндромом");

    }
}
