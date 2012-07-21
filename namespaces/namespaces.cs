using System;

namespace Tao
{
  namespace Jin
  {
    class PR
    {
      public static void Method()
      {
        Console.WriteLine("Black Jin");
      }
    }
  }

  namespace Yang
  {
    class PR
    {
      public static void Method()
      {
        Console.WriteLine("White Yang");
      }
    }
  }
}

class Program
{
  public static void Main()
  {
    Tao.Jin.PR.Method();
    Tao.Yang.PR.Method();
  }
}
