/*
  Status Submissão: Accepted ☑

  Escreva um programa que leia três valores com ponto flutuante de dupla precisão:
  A, B e C. Em seguida, calcule e mostre:
  a) a área do triângulo retângulo que tem A por base e C por altura.
  b) a área do círculo de raio C. (pi = 3.14159)
  c) a área do trapézio que tem A e B por bases e C por altura.
  d) a área do quadrado que tem lado B.
  e) a área do retângulo que tem lados A e B.
*/
using System;
using System.Collections.Generic;

class URI{
  static void Main(string[] args){
    double PI = 3.14159;
    var dict = new Dictionary<string, string>();
    string[] formas = {"TRIANGULO", "CIRCULO", "TRAPEZIO", "QUADRADO", "RETANGULO"};

    string[] valuesGeometric = Console.ReadLine().Split();
    var valorA = double.Parse(valuesGeometric[0]);
    var valorB = double.Parse(valuesGeometric[1]);
    var valorC = double.Parse(valuesGeometric[2]);

    dict.Add(formas[0], Math.Round((valorA*valorC)/2, 3).ToString("0.000"));
    dict.Add(formas[1], Math.Round(PI*Math.Pow(valorC, 2), 3).ToString("0.000"));
    dict.Add(formas[2], Math.Round((valorA+valorB)*valorC/2, 3).ToString("0.000"));
    dict.Add(formas[3], Math.Round(Math.Pow(valorB, 2), 3).ToString("0.000"));
    dict.Add(formas[4], Math.Round((valorA*valorB), 3).ToString("0.000"));

    foreach(var geometric in dict){
      Console.WriteLine("{0}: {1}", geometric.Key, geometric.Value);
    }
  }
}
