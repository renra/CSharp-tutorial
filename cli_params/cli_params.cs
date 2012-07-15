using System;

class Program
{
  public static void Main(string [] args)
  {
    foreach(var arg in args)
    {
      Console.WriteLine("Cli param: {0}", arg);
    }
  }
}
