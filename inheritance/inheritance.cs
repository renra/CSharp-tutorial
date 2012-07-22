using System;

public class Program
{
  public static void Main()
  {
    Jedi jedi = new Jedi();
    JediMaster master = new JediMaster();

    jedi.Meditate();
    jedi.Heal();
    jedi.WieldSaber();

    Console.WriteLine("---------");
    master.Meditate();
    master.Heal();
    master.WieldSaber();
  }
}

public class Jedi
{
  public virtual void Meditate()
  {
    Console.WriteLine("The Jedi's mind and heart are clearing up.");
  }

  public virtual void Heal()
  {
    Console.WriteLine("The Jedi begins to focus increasing the natural healing rate of his cells.");
  }

  //not virtual!!!
  public void WieldSaber()
  {
    Console.WriteLine("The Jedi moves the saber in simple but efficient moves careful not to cut himself.");
  }
    
}

public class JediMaster : Jedi
{
  public override void Meditate()
  {
    Console.WriteLine("Pure white light issues from the Jedi blessing all that comes in its path.");
  }

  public new void Heal()
  {
    Console.WriteLine("The Jedi contacts his cells and lets the Force heal them instantly.");
  }

  public new void WieldSaber()
  {
    Console.WriteLine("The Jedi moves the saber as if it were a part of his body in a harmony orchestrated by the Force.");
  }
}
