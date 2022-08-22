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
	  
	    static void MinSumStr(int[,] matr)
	    {
	      int m = matr.GetLength(0);
	      int n = matr.GetLength(1);
        int [] ar = new int [m];
        int sum = 0;
        int str = 0;
        int min = 0;
	      for (int i = 0; i < m; i++)
	      {
	        sum=0;
          for (int j = 0; j < n; j++) 
	        {
	          sum = sum+matr[i,j]; 
	        }
	        ar[i] = sum;
	      }
        min = ar[0];
        for (int i = 0; i < m; i++)
        {
          if (ar[i] < min)
          {
            min = ar[i];
            str = i+1; 
          }
        }
        Console.Write(str);
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
	        Console.Write("Строка с наименьшей суммой элементов: "); 
	        MinSumStr(array);
	    }
	  
	}
