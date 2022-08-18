using System;

class Program
{
    static void PrintArray(double[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", matr[i, j]);
        }
        Console.WriteLine();
      }
    }
    
    static void FillArray(double[,] matr)
    {
      Random random = new Random();
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i,j] = random.NextDouble();
        }
      }
    }

    static void Main(string[] args)
    {  
        
        Console.Write("Введите кол-во строк массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите кол-во столбцов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double [,] array = new double [m,n];
        FillArray (array);
        Console.WriteLine("Заданный массив: ");
        PrintArray(array);
        Console.WriteLine("");
    }
}
