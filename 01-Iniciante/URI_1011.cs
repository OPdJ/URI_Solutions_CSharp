/*
  Status Submissão: Accepted ☑

  Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o
  valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3.
  Considere (atribua) para pi o valor 3.14159.

  Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas
  linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois
  inteiros é outro inteiro.
*/
using System;

class URI{
  static void Main(string[] args){
    double PI   = 3.14159;
    double raio = double.Parse(Console.ReadLine());

    string volume = Math.Round((4/3.0)*PI*Math.Pow(raio, 3), 3).ToString("0.000");

    Console.WriteLine("VOLUME = {0}", volume);
  }
}
