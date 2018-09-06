/*
  Status Submissão: Accepted ☑

  A fórmula para calcular a área de uma circunferência é: area = π . raio2.
  Considerando para este problema que π = 3.14159:

  - Efetue o cálculo da área, elevando o valor de Raio ao quadrado e multiplicando
    por π.
*/
using System;

class URI{
  static void Main(string[] args){
    double PI = 3.14159;

    double raio = double.Parse(Console.ReadLine());
    string area = Math.Round(PI*Math.Pow(raio, 2), 4).ToString("0.0000");

    Console.WriteLine("A={0}", area);
  }
}
