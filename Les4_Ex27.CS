using System;

class Program 
{
  static int summ (int x) 
  {
    int s = 0;
    int y=x/10;
    while (y>=1)
    {
       y=y/10;
       s++;
    }
  
    int xx=x;
    int[] array = new int[s+1];
    for (int i=0; i<=s; i++ ) 
    {
      array[s-i] = xx%10;
      xx=xx/10;
    }
    
    int sum=0;
    for (int i=0; i<=s; i++ ) 
    {
      sum=sum + array[i];
    }
    return sum;
  }
  
  static void Main(string[] args) 
    {
      Console.Write("Введите число: ");
      int a = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Сумма цифр числа ="+summ(a));
    }
}
