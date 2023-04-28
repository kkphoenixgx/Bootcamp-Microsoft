using System;

namespace Program 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      int[] numberList = new int[5]; 
   
      int number1 = int.Parse(Console.ReadLine());
      int number2 = int.Parse(Console.ReadLine());
      int number3 = int.Parse(Console.ReadLine());
      int number4 = int.Parse(Console.ReadLine());
      int number5 = int.Parse(Console.ReadLine());

      numberList[0] = number1;
      numberList[1] = number2;
      numberList[2] = number3;
      numberList[3] = number4;
      numberList[4] = number5;
      

      int quantidadePares = 0;
      int quantidadeImpares = 0;
      int quantidadePositivos = 0;
      int quantidadeNegativos = 0;
      
      for(int i = 0; i <= 4; i++){
        if(numberList[i] % 2 == 0) quantidadePares += 1;
        if(numberList[i] % 2 != 0) quantidadeImpares += 1;
        if(numberList[i] > 0) quantidadePositivos += 1;
        if(numberList[i] < 0) quantidadeNegativos += 1;

        Console.WriteLine(i);
      }

      Console.WriteLine($"{quantidadePares} par(es)");
      Console.WriteLine($"{quantidadeImpares} impar(es)");
      Console.WriteLine($"{quantidadePositivos} positivo(s)");
      Console.WriteLine($"{quantidadeNegativos} negativo(s)");

    }
  }
}