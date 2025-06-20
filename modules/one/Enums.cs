using System;

namespace MeuApp
{
  class Enums
  {
    static void EnumsMain(string[] args)
    {
      Product mouse = new Product(1, "Mouse Gamer", 299.32, EProductType.Product);
      Product energyMaintence = new Product(2, "Residencial Energy Maintence", 100.02, EProductType.Service);

      mouse.Id = 55;

      Console.WriteLine($"id: {mouse.Id}");
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
      Console.WriteLine((int)mouse.Type);
      Console.WriteLine("------------");
      Console.WriteLine($"id: {energyMaintence.Id}");
      Console.WriteLine(energyMaintence.Name);
      Console.WriteLine(energyMaintence.Price);
      Console.WriteLine(energyMaintence.Type);
    }
    struct Product
    {
      public Product(int id, string name, double price, EProductType type)
      {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
      }
      // properties (prop)
      public int Id;
      public string Name;
      public double Price;
      public EProductType Type;

      // methods 
      public double PriceInDolar(double dolar)
      {
        return Price * dolar;
      }
    }
    enum EProductType
    {
      Product = 1,
      Service = 2
    }
  }
}