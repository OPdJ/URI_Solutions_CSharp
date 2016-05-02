/*
  Status Submissão: Accepted ☑

  Leia um valor de ponto flutuante com duas casas decimais. Este valor representa
  um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis
  no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2.
  As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a
  relação de notas necessárias.
*/
using System;

class URI{
  static void Main(string[] args){
    double[] notas = {100, 50, 20, 10, 5, 2};
    double[] moedas = {1, 0.50, 0.25, 0.10, 0.05, 0.01};
    double aux;

    double valor_troca = double.Parse(Console.ReadLine());

    Console.WriteLine("NOTAS:");
    for(int j = 0; notas.Length > j ; ++j)
    {
      aux = valor_troca/notas[j];
      Console.WriteLine("{0} nota(s) de R$ {1}", Math.Floor(aux).ToString("0"), notas[j].ToString("0.00"));
      valor_troca = double.Parse((valor_troca%notas[j]).ToString("0.00"));
    }

    Console.WriteLine("MOEDAS:");
    for(int j = 0; notas.Length > j; ++j)
    {
      aux = valor_troca/moedas[j];
      Console.WriteLine("{0} moeda(s) de R$ {1}", Math.Floor(aux).ToString("0"), moedas[j].ToString("0.00"));
      valor_troca = double.Parse((valor_troca%moedas[j]).ToString("0.00"));
    }
  }
}
