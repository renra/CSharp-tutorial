using System;
using Gtk;

class Hello
{
  public static void Main()
  {
    Application.Init();
    Window window = new Window("Hello World!");
    window.Show();

    Application.Run();
  }
}
