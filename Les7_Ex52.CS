using System;

class Program
{
    static void PrintArray(int[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
      }
    }
    
    static void FillArray(int[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 10);
        }
      }
    }
  
    static void SredArifmet(int[,] matr)
    {
      int m = matr.GetLength(0);
      int n = matr.GetLength(1);
      double sred = 0;
      for (int j = 0; j < n; j++) 
      {
        sred=0;
        for (int i = 0; i < m; i++)
        {
          sred=sred+matr[i,j];
        }
        Console.Write("{0,2:F2}",sred/n +", ");
      }
    }
  
    static void Main(string[] args)
    {
        Console.Write("Введите кол-во строк массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите кол-во столбцов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [,] array = new int[m,n];
        FillArray (array);
        Console.WriteLine("Заданный массив: ");
        PrintArray(array);
        Console.WriteLine("");      
        Console.Write("Среднее арифметическое столбцов: ");
        SredArifmet(array);
    }
  
}
