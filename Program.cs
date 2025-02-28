using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a number to find its prime factors:");
    string? input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
      System.Console.WriteLine("Input cannot be null or empty.");
      return;
    }
    int n = int.Parse(input);

    if (n < 2)
    {
      System.Console.WriteLine(n);
      return;
    }

    while (n % 2 == 0)
    {
      System.Console.WriteLine(2);
      n /= 2;
    }

    for (int i = 3; i * i <= n; i += 2)
    {
      while (n % i == 0)
      {
        System.Console.WriteLine(i);
        n /= i;
      }
    }

    if (n > 2)
    {
      System.Console.WriteLine(n);
    }
  }
}