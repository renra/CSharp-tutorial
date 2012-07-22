using System;
using System.Collections;

public class Inventory : IEnumerable
{
  //Just strings to make things simple
  private string[] elements;

  public Inventory(string[] elements)
  {
    this.elements = elements;
  }

  public IEnumerator GetEnumerator()
  {
    return new InventoryEnumerator(this);
  }

  private class InventoryEnumerator : IEnumerator
  {
    private int position = -1;
    private Inventory inv;

    public InventoryEnumerator(Inventory inv)
    {
      this.inv = inv;
    }

    public bool MoveNext()
    {
      bool retval = false;

      if(position < inv.elements.Length - 1)
      {
        position++;
        retval = true;
      }

      return retval;
    }

    public void Reset()
    {
      position = -1;
    }

    //Object?
    public object Current
    {
      get
      {
        return inv.elements[position];
      }
    }
  }
}

public class Program
{
  public static void Main()
  {
    Inventory inventory = new Inventory(new string[] {"lightsaber", "blaster", "healing kit"});

    Console.WriteLine("Let's see what we have in the inventory:");
    foreach(var member in inventory)
    {
      Console.WriteLine(member);
    }
  }
}
