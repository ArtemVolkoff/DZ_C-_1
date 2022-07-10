ДЗ1

Условия

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8

Решения

Задача 2

using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите первое число");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите второе число");
      int y = Convert.ToInt32(Console.ReadLine());
      if (x > y)
      {Console.Write(x);
        Console.WriteLine(" является наибольшим числом ");
        Console.Write(y);
        Console.WriteLine(" является наименьшим числом ");
      }
      else
      {Console.Write(y);
        Console.WriteLine(" является наибольшим числом ");
        Console.Write(x);
        Console.WriteLine(" является наименьшим числом ");
      }
      
    }
}


Задача 4


using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите первое число");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите второе число");
      int y = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите третье число");
      int z = Convert.ToInt32(Console.ReadLine());
      if ((x >= y) & (y > z))
      {Console.Write(x);
        Console.WriteLine(" является наибольшим числом ");
      }
      else
      if ((x >= z) & (z >= y))
      {Console.Write(x);
        Console.WriteLine(" является наибольшим числом ");
      }
      else
      if ((y >= x) & (x >= z))
      {Console.Write(y);
        Console.WriteLine(" является наибольшим числом ");
      }
      else
        if ((y >= z) & (z >= x) )
      {Console.Write(y);
        Console.WriteLine(" является наибольшим числом ");
      }
       else
        if ((z >= x) & (x >= y) )
      {Console.Write(z);
        Console.WriteLine(" является наибольшим числом ");
      }
      else
      {Console.Write(z);
        Console.WriteLine(" является наибольшим числом ");
      }
    }
}




Задача 6

using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите число");
      int x = Convert.ToInt32(Console.ReadLine());
      if (x % 2 == 0)
      {Console.Write(x);
        Console.WriteLine(" является четным числом ");
      }
      else
      {Console.Write(x);
        Console.WriteLine(" является нечетным числом ");
      }
    }
}

Задача 8

using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите первое число");
      int x = Convert.ToInt32(Console.ReadLine());
      int count = 1;
      while(count<x+1)
      {
        Console.Write(count);
        Console.Write(" ");
        count+=1;
      }
      
    }
}

