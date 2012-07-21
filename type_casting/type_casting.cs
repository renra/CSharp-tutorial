using System;

class Dog
{}

class Cat
{}

class Program
{
  public static void Main()
  {
    Object[] arr = new Object[4];
    arr[0] = "string";
    arr[1] = 12;
    arr[2] = new Dog();
    arr[3] = new Cat();

    for(var i = 0; i < arr.Length; i++)
    {
      Console.WriteLine("The element is of type: {0}", arr[i].GetType());
    }
  }
}
