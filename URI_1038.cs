/*
  Status Submissão: Accepted ☑

  Com base na tabela abaixo, escreva um programa que leia o código de um item e a
  quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
*/
using System;
using System.Collections.Generic;

class URI{
  static void Main(string[] args){
    var dict = new Dictionary<int, double>();
    var total = "";
    string[] valores = Console.ReadLine().Split();

    var cod_produto = int.Parse(valores[0]);
    var quant_produto = int.Parse(valores[1]);

    dict.Add(1, 4.00);
    dict.Add(2, 4.50);
    dict.Add(3, 5.00);
    dict.Add(4, 2.00);
    dict.Add(5, 1.50);

    foreach (var totalProd in dict) {
      if(totalProd.Key == cod_produto){
        total = (totalProd.Value*quant_produto).ToString("0.00");
        Console.WriteLine("Total: R$ "+total);
      }
    }
  }
}
