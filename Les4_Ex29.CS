using System;

class Program 
{
  static char[] massiv (string a)
  {
    char[] array = new char[(a.Length+1)/2]; 
    int j=0;
    for (int i=1; i<=a.Length; i++ ) 
      {
         if (i%2!=0)
        {
          array[j]=a[i-1];
          j++;
        }
      }
    return array;
  }
  
  static void Main(string[] args) 
    {
      Console.Write("Введите цифры через запятую: ");
      string a = Convert.ToString(Console.ReadLine());
      char[] array2 = new char[(a.Length+1)/2];
      array2 = massiv(a);
      for (int i=0; i<array2.Length; i++ ) 
      {
        Console.Write(array2[i]+" ");
      }
    }
}
