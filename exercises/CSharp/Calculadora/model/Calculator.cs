using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.model
{
  public class Calculator
  {
    public int Sum(int x, int y)
    {
      return x + y;
    }
    public int Subtract(int x, int y)
    {
      return x - y;
    }
    public int Multiply(int x, int y)
    {
      return x * y;
    }
    public int Divide(int x, int y)
    {
      return x / y;
    }
    public int Power(int x, int y)
    {
      return (int)Math.Pow(x, y);
    }
  }
}