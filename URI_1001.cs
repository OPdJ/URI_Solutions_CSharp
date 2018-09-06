/*
  Status Submissão: Accepted ☑

  Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A
  e B atribuindo o seu resultado na variável X. Imprima X conforme exemplo
  apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo
  especificado e não esqueça de imprimir o fim de linha após o resultado, caso
  contrário, você receberá "Presentation Error".
*/
using System;

class URI{
  static void Main(string[] args){

    string A = Console.ReadLine();
    string B = Console.ReadLine();
    short y;
    short z;

    short.TryParse(A, out y);
    short.TryParse(B, out z);

    Console.WriteLine("X = {0}", y + z);
  }
}
