using System;

namespace MeuApp
{
  class Structs
  {
    static void StructsMain(string[] args)
    {
      Product mouse = new Product(1, "Mouse Gamer", 299.32);

      mouse.Id = 55;

      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
    }
    struct Product
    {
      public Product(int id, string name, double price)
      {
        Id = id;
        Name = name;
        Price = price;
      }
      // properties (prop)
      public int Id;
      public string Name;
      public double Price;

      // methods 
      public double PriceInDolar(double dolar)
      {
        return Price * dolar;
      }
    }
  }
}
