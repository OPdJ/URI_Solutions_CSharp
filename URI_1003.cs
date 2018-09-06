/*
  Status Submissão: Accepted ☑

  Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a
  soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta
  variável.
*/
using System;

class URI{
  static void Main(string[] args){

    string a = Console.ReadLine();
    string b = Console.ReadLine();
    int x;
    int y;
    int.TryParse(a, out x);
    int.TryParse(b, out y);

    Console.WriteLine("SOMA = {0}", x + y);
  }
}
