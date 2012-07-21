using System;

class Program
{
  public static void Main()
  {
    int[][] array;
    array = new int[2][] { new int[] {1, 2, 3}, new int[] {4, 5} };
    //array = new int[20]; //dynamically changed size

    //int [,] rectangle_array = new int[2, 3] { {1, 2, 3}, {4, 5, 6} };

    foreach(var member in array)
    {
      Console.WriteLine("A new member array");
      foreach(var nested_member in member)
      {
        Console.WriteLine("Member: {0}", nested_member);
      }
    }
  }
}
