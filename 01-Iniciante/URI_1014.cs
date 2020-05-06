/*
  Status Submissão: Accepted ☑

  Calcule o consumo médio de um automóvel sendo fornecidos a distância total
  percorrida (em Km) e o total de combustível gasto (em litros).
*/
using System;

class URI{
  static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("{0} km/l", Math.Round((a/b),3));
  }
}
