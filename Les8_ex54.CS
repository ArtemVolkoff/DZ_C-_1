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
	  
	    static void MatrPoryadok(int[,] matr)
	    {
	      int m = matr.GetLength(0);
	      int n = matr.GetLength(1);
        int l = matr[0,0];
        int jl = 0;
	      for (int i = 0; i < m; i++)
	      {
	        
          for (int j = 0; j < n; j++) 
	        {
	          l = matr[i,j];
            jl = j;
            for (int k = j; k < n; k++) 
            {
              if (matr[i,k] < l)
              {
                l = matr[i,k];
                jl = k;
              }
            }

            if (jl!=j)
            {
              matr[i,jl] = matr[i,j];
              matr[i,j] = l;
            }
            
	        }
	        
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
	        Console.Write("Упорядоченная матрица: ");
          Console.WriteLine(""); 
	        MatrPoryadok(array);
          PrintArray(array);
	    }
	  
	}
