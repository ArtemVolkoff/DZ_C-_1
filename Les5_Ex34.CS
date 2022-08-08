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
        Console.Write("Введите размерность массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        int y = 0;
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(100, 1000);
            if (array[i]%2 == 0) y=y+1;
        }
        PrintArray(array);
        Console.WriteLine("");
        Console.WriteLine("Кол-во четных элементов в массиве - " + y);
    }
}
