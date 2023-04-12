using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.model
{
  public class classExemple
  {

    private string _name;
    private int _age;

    public void Apresentar()
    {
      Console.WriteLine("someText");
      Console.WriteLine($"someText with variables {Name}, {Age}");
    }

    // ----------- Getters and Setters -----------

    public string Name
    {
      get => _name;
      set => _name = value;
    }
    public int Age
    {
      get => _age;
      set
      {
        if (value == 0) throw new ArgumentException("invalid age");
        _age = value;
      }
    }

  }


}