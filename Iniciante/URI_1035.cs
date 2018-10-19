/*
  Status Submissão: Accepted ☑

  Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D
  for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D,
  ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos",
  senão escrever "Valores nao aceitos".
*/
using System;

class URI{
  static void Main(string[] args){

    string[] values = Console.ReadLine().Split();
    var valorA = int.Parse(values[0]);
    var valorB = int.Parse(values[1]);
    var valorC = int.Parse(values[2]);
    var valorD = int.Parse(values[3]);

    if(((valorB > valorC) && (valorD > valorA)) && ((valorC+valorD) > (valorA+valorB)) && ((valorC > 0) && (valorD > 0))){
      Console.WriteLine("Valores aceitos");
    } else{
      Console.WriteLine("Valores nao aceitos");
    }
  }
}
