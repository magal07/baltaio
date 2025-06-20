using System;

namespace MeuApp
{
  class While
  {
    static void WhileMain(string[] args)
    {
      int value = 0;
      while (value <= 100)
      {
        Console.WriteLine(value);
        value++;
      }
    }
  }
}

