/*
  Status Submissão: Accepted ☑

  Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno.
  A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B
  tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0,
  sempre com uma casa decimal.
*/
using System;

class URI{
  static void Main(string[] args){
    double notaA = double.Parse(Console.ReadLine());
    double notaB = double.Parse(Console.ReadLine());
    double notaC = double.Parse(Console.ReadLine());

    string media = Math.Round(((notaA*2)+(notaB*3)+(notaC*5))/10, 1).ToString("0.0");
    Console.WriteLine("MEDIA = {0}", media);
  }
}
