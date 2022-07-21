using System;

class Program 
{
     static double points (double a_x, double a_y, double a_z, double b_x, double b_y, double b_z)
      {
      double num = (b_x - a_x)*(b_x - a_x) + (b_y - a_y)*(b_y - a_y) + (b_z - a_z)*(b_z - a_z);
      return Math.Sqrt(num);
      }
  
    static void Main(string[] args) 
    {
      
      Console.Write("Введите координату x первой точки: ");
      double a_x = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите координату y первой точки: ");
      double a_y = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите координату z первой точки: ");
      double a_z = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите координату x второй точки: ");
      double b_x = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите координату y второй точки: ");
      double b_y = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите координату z второй точки: ");
      double b_z = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine(Math.Round(points(a_x, a_y, a_z, b_x, b_y, b_z),2));

    }
}
