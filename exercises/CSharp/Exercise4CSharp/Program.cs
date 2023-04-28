// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program 
{

  public static void Main(string[] args) 
  {
    string[] entrada = Console.ReadLine().Split();
    int participantes = int.Parse(entrada[0]);
    int cachorrosQuentes = int.Parse(entrada[1]);

    double total = (double)participantes / (double)cachorrosQuentes;
    // Console.WriteLine(total + " - P: " + participantes + " - H: " + cachorrosQuentes);
    Console.WriteLine(total.ToString("N2") );

  }
}