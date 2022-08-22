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
	  
	    static void MatrUmnozhenie(int[,] matr1,int[,] matr2,int[,] matr3)
	    {
	      int m = matr1.GetLength(0);
	      int n = matr1.GetLength(1);

	      for (int i = 0; i < m; i++)
	      {
          for (int j = 0; j < n; j++) 
	        {
	          matr3[i,j]=matr1[i,j]*matr2[i,j]; 
	        }
	      }
	    }
	  
	    static void Main(string[] args)
	    {
	        Console.Write("Введите кол-во строк массива: ");
	        int m = Convert.ToInt32(Console.ReadLine());
	        Console.Write("Введите кол-во столбцов массива: ");
	        int n = Convert.ToInt32(Console.ReadLine());
	        int [,] array1 = new int[m,n];
          int [,] array2 = new int[m,n];
          int [,] array3 = new int[m,n];
	        Console.WriteLine("");
          FillArray (array1);
	        Console.WriteLine("Заданный массив 1: ");
	        PrintArray(array1);
	        Console.WriteLine("");
          FillArray (array2);
	        Console.WriteLine("Заданный массив 2: ");
	        PrintArray(array2);
          Console.WriteLine("");
	        Console.Write("Перемноженный массив: ");
          Console.WriteLine("");
	        MatrUmnozhenie(array1,array2,array3);
          PrintArray(array3);
	    }
	  
	}
