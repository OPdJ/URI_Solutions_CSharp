/*
  Status Submissão:

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

    string[] tipo_troca = {"nota", "moeda"};

    double valor_troca = double.Parse(Console.ReadLine());

    for(int i = 0; tipo_troca.Length > i; ++i)
    {
      Console.WriteLine("{0}S:", tipo_troca[i].ToUpper());
      if(tipo_troca[i].Equals("nota"))
      {
        for(int j = 0; notas.Length > j; ++j)
        {
          aux = valor_troca/notas[j];
          Console.WriteLine("{0} {1}(s) de R$ {2}", Math.Floor(aux).ToString("0"), tipo_troca[i], notas[j].ToString("0.00"));
          aux = (valor_troca%notas[j]);
          valor_troca = aux;
        }
      } else
      {
        for(int j = 0; notas.Length > j; ++j)
        {
          aux = valor_troca/moedas[j];
          Console.WriteLine("{0} {1}(s) de R$ {2} ", Math.Floor(aux).ToString("0"), tipo_troca[i], moedas[j].ToString("0.00"));
          aux = (valor_troca%moedas[j]);
          valor_troca = aux;
        }
      }
    }
  }
}
