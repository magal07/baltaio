using System;

namespace MeuApp
{
  class MethodsAndFunctions
  {
    static void MethodsAndFunctionsMain(string[] args)
    {
      MyMethod();
      string name = FullName("Marcelo", "Magalhães", 26);
      Console.WriteLine(name);
      Console.WriteLine(FullName("Balta", "IO"));
    }
    static void MyMethod()
    {
      Console.WriteLine("C# is great!");
    }

    static string FullName(
    string name,
    string surname,
    int age = 0
    )
    {
      return name + " " + surname + " have " + age.ToString() + " years!";
    }
  }
}
