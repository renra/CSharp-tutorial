using System;

class InputAndControl
{
  public static void Main(){
    int input;

    Console.WriteLine("Give me a number:");
    input = Int32.Parse(Console.ReadLine());

    Console.WriteLine("You have given me: {0}", input);

    switch(input)
    {
      case 1:
        Console.WriteLine("One");
        break;
      case 2:
        Console.WriteLine("Two");
        break;
      default:
        Console.WriteLine("Default");
        break;
    }
  }
}
