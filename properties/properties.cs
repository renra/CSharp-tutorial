using System;

class Dog
{
  private string name;
  private int age;

  public string Name
  {
    get
    {
      return name;
    }

    set
    {
      name = value;
    }
  }

  public int Age
  {
    get
    {
      return age;
    }

    set
    {
      age = value;
    }
  }

  public override string ToString()
  {
    return "Name: " + Name + ", age: " + Age;
  }
}

class Program
{
  public static void Main()
  {
    Dog buddy = new Dog();
    buddy.Name = "Buddy";
    buddy.Age = 12;

    Console.WriteLine("This dog is: {0}", buddy);
  }
}
