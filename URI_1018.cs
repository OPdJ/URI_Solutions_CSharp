/*
  Status Submissão: Accepted ☑

  Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis
  (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de
  100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas
  necessárias.
*/
using System;

class URI{
  static void Main(string[] args){
    int[] x = {100, 50, 20, 10, 5, 2, 1};
    int aux;

    int y = int.Parse(Console.ReadLine());

    Console.WriteLine("{0}", y);
    for (int i = 0; x.Length > i; ++i )
    {
        aux = y/x[i];
        Console.WriteLine("{0} nota(s) de R$ {1},00", aux, x[i]);
        aux = (y%x[i]);
        y = aux;
    }
  }
}
