using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the number for Fibonnaci series: ");
    int n = Convert.ToInt32(System.Console.ReadLine());

    int a = 0, b = 1;
    //? Printing the first two numbers of the series
    // System.Console.WriteLine(a);
    // System.Console.WriteLine(b);

    for (int i = 1; i <= n; i++)
    {
      int c = a + b;
      a = b;
      b = c;
      System.Console.WriteLine(c);
    }
  }
}