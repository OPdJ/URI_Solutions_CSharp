/*
  Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
  indicando se os valores lidos são múltiplos entre si.
*/

using System;
using System.Linq;

class URI{
  static void Main(string[] args){
    int aux = 0;
    int[] values = Console.ReadLine().Split().Select(item => int.Parse(item)).ToArray();

    if((values[0]+values[1]+Math.Abs(values[0]-values[1]))/2 != values[0]){
      aux = values[1];
      values[1] = values[0];
      values[0] = aux;
    } 

    if(values[0]%values[1]==0){
      Console.WriteLine("Sao Multiplos");
    } else{
      Console.WriteLine("Nao sao Multiplos");
    }
  }
}
