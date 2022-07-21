using System;

class Program 
{
    static void Check(params int[] array)
    {
      if (array[0]==array[4] && array[1]==array[3]) Console.WriteLine("Введенное число является полиндромом");
      else Console.WriteLine("Введенное число не является полиндромом");
    }
    static void Main(string[] args) 
    {
      Console.Write("Введите пятизначное число: ");
      int x = Convert.ToInt32(Console.ReadLine());
      int xx = x;
      int[] array1 = new int[5];
      for (int i=0; i<5; i++ ) 
      {
        array1[4-i] = xx%10;
        xx=xx/10;
      }
      Check(array1);
    }
}
