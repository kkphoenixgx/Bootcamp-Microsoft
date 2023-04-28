// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program 
{
  public static void Main() 
  {
    string numero = Console.ReadLine();

    int defaultvalue = 0;
    if( !(int.TryParse(numero, out defaultvalue )) ) Environment.Exit(0);

    string badLuck = "13";
    bool checkLuck = numero.Contains(badLuck);

    if(checkLuck) Console.WriteLine($"{numero} es de Mala Suerte");
    else Console.WriteLine($"{numero} NO es de Mala Suerte");

  }
}