/*
  Status Submissão: Accepted ☑

  Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor
  unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor
  unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
*/
using System;

class URI{
  static void Main(string[] args){
    string[] prod01     = Console.ReadLine().Split();
    var numProd01       = int.Parse(prod01[0]);
    var numPecaProd01   = int.Parse(prod01[1]);
    var valorUnitProd01 = double.Parse(prod01[2]);

    string[] prod02     = Console.ReadLine().Split();
    var numProd02       = int.Parse(prod02[0]);
    var numPecaProd02   = int.Parse(prod02[1]);
    var valorUnitProd02 = double.Parse(prod02[2]);

    var totalPagar = Math.Round((numPecaProd01*valorUnitProd01)+(numPecaProd02*valorUnitProd02), 2).ToString("0.00");
    Console.WriteLine("VALOR A PAGAR: R$ {0}", totalPagar);
  }
}
