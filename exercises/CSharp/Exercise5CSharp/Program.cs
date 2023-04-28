// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

class Program 
{
  public static void Main() 
  {
    int tamanhoSequencia = Convert.ToInt32(Console.ReadLine());
    int quantidadeNumerosMarcados = 0;
    int ultimoNumeroLido = 0; // Inicializa em zero, porque "Vi é igual a 1 ou 2";
    for (int i = 0; i < tamanhoSequencia; i++) {
      int vi = Convert.ToInt32(Console.ReadLine());
      //TODO: Verificar se o numero lido (Vi) é diferente do último numero lido para marcá-lo.
      ultimoNumeroLido = vi;
    }
    //TODO: Imprimir a quantidade de números marcados.
  }
}