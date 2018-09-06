/*
  Status Submissão: Accepted ☑

  Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de
  Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente
  “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.
*/
using System;

class URI{
  static void Main(string[] args){

    string[] values = Console.ReadLine().Split();

    var valueA = double.Parse(values[0]);
    var valueB = double.Parse(values[1]);
    var valueC = double.Parse(values[2]);

    var delta = (Math.Pow(valueB, 2) - 4*valueA*valueC);
    if((delta != 0) && (valueA > 0) && (delta > 0))
    {
      var bhaskR1 = Math.Round((-valueB+Math.Sqrt(delta))/(2*valueA), 5).ToString("0.00000");
      var bhaskR2 = Math.Round((-valueB-Math.Sqrt(delta))/(2*valueA), 5).ToString("0.00000");

      Console.WriteLine("R1 = {0}", bhaskR1);
      Console.WriteLine("R2 = {0}", bhaskR2);
    } else {
      Console.WriteLine("Impossivel calcular");
    }
  }
}
