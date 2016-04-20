/*
  Status Submissão: Wrong Answer

  Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a
  2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A
  tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma
  que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
*/
using System;

class URI{
  static void Main(string[] args){

    string x = Console.ReadLine().ToString();
    string y = Console.ReadLine();
    double a;
    double b;

    double.TryParse(x, out a);
    double.TryParse(y, out b);

    decimal media = Convert.ToDecimal(Math.Round(((3.5 * a) + (7.5 * b)) / 11.0, 5));

    Console.WriteLine("MEDIA = {0}", media);
  }
}
