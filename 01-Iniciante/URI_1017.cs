/*
  Status Submissão: Accepted ☑

  Joaozinho quer calcular e mostrar a quantidade de litros de combustível
  gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L. Para isso, ele
  gostaria que você o auxiliasse através de um simples programa. Para efetuar o
  cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade
  média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e,
  em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3
  casas decimais após o ponto.
*/
using System;

class URI{
  static void Main(string[] args){
    int consumo = 12;

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    double x = Convert.ToDouble(a*b);
    string litros = Math.Round(x/consumo,3).ToString("0.000");
    Console.WriteLine(litros);
  }
}
