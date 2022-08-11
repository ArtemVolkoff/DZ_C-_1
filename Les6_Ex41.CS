using System;

class Program 
{
  static void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.Write($"{col[position]} ");
            position++;
        }
    }

  static void Main(string[] args) 
    {
      Console.WriteLine("Сколько чисел вы будете вводить?");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите числа:");
      int[] array = new int[n];
      for (int i=0; i<n; i++ )
      {
        Console.Write($"Число {i+1} = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("");
      Console.WriteLine("Введенный массив: ");
      PrintArray(array);
      int count = 0;
      for (int i=0; i<n; i++ ) 
      {
         if (array[i] > 0) count++;
      }
      Console.WriteLine("");
      Console.WriteLine("Кол-во положительных числе в массиве = " + count);
    }
}
