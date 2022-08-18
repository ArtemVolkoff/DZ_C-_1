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
  
    static void FindElementPosition(int[,] matr, int a, int b)
    {
        int m = matr.GetLength(0);
        int n = matr.GetLength(1);
        bool f = false;
        int m1 = 0;
        int n1 = 0;
        for (int i = 0; i < m; i++)
        {
          for (int j = 0; j < n; j++)
          {
            if (i == a-1 && j == b-1) 
            {
              f=true;
              m1=i;
              n1=j;
            }
          }
        }
      if (f)
            {
              Console.WriteLine("");
              Console.Write($"Элемент [{a},{b}] = {matr[m1,n1]}");
            }
            else
            {
              Console.WriteLine("");
              Console.Write($"Такого элемента нет");
            } 
    }
  
    static void FindElement(int[,] matr, int a)
    {
      int m = matr.GetLength(0);
      int n = matr.GetLength(1);
      bool f = false;
      int m1 = 0;
      int n1 = 0;
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (matr[i,j] == a) 
          {
            f=true;
            m1=i;
            n1=j;
          }
        }
      }
      if (f)
          {
            Console.WriteLine("");
            Console.Write($"Элемент находится на позиции [{m1+1},{n1+1}]");  
          }
          else 
          {
            Console.WriteLine("");
            Console.Write($"Такого элемента нет"); 
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
        Console.Write("Введите номер строки элемента: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца элемента: ");
        int y = Convert.ToInt32(Console.ReadLine());
        FindElementPosition(array,x,y);
        Console.WriteLine("");
        Console.Write("Введите значение элемента: ");
        int z = Convert.ToInt32(Console.ReadLine());
        FindElement(array,z);
    }
  
}
