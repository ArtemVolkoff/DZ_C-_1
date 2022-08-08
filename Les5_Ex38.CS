using System;

class Program
{
    static void PrintArray(double[] col)
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
        double [] array = new double[n];
        double max = 0;
        double min = 100;
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(0, 100);
            if (max < array[i]) max=array[i];
            if (min > array[i]) min=array[i];
        }
        double dif = max-min;
        PrintArray(array);
        Console.WriteLine("");
        Console.WriteLine("Максимальный элемент: "+ max);
        Console.WriteLine("Минимальный элемент: "+ min);
        Console.WriteLine("Разница между максимальным и минимальным элементов массива = "+ dif);
    }
}
