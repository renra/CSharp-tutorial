using System;
using System.Text;

class ReadKeyWithStringBuilder
{
  public static void Main()
  {
    StringBuilder result = new StringBuilder();
    char c;

    Console.WriteLine("Type something:");

    do
    {
      c = Console.ReadKey().KeyChar;
      result.Append(c);
    } while ( c.ToString() != Environment.NewLine );

    Console.WriteLine("You have written: {0}", result.ToString());
  }
}
