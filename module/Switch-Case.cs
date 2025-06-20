using System;

namespace MeuApp
{
  class SwitchCase
  {
    static void SwitchCaseMain(string[] args)
    {
      string valor = "Marcelo";
      switch (valor)
      {
        case "João":
          Console.WriteLine("Não é o Marcelo");
          break;
        case "Paulo":
          Console.WriteLine("Não é o Marcelo");
          break;
        case "Júlio":
          Console.WriteLine($"O {valor} foi encontrado!");
          return;
        default:
          Console.WriteLine($"O {valor} não foi encontrado!");
          break;
      }
    }
  }
}
