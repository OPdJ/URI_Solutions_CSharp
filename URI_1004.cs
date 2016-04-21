/*
  Status Submissão: Accepted ☑

  Leia dois valores inteiros. A seguir, calcule o produto entre estes dois
  valores e atribua esta operação à variável PROD. A seguir mostre a variável
  PROD com mensagem correspondente.
*/
using   System;

class URI{
  static void Main(string[] args){
    string x = Console.ReadLine();
    string y = Console.ReadLine();

    int a;
    int b;
    int.TryParse(x, out a);
    int.TryParse(y, out b);

    Console.WriteLine("PROD = {0}", a * b);
  }
}
