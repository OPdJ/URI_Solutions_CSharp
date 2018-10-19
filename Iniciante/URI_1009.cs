/*
  Status Submissão: Accepted ☑

  Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total
  de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor
  ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber
  no final do mês, com duas casas decimais.
*/
using System;

class URI{
  static void Main(string[] args){
    var nome    = Console.ReadLine();
    var salario = double.Parse(Console.ReadLine());
    var vendas  = double.Parse(Console.ReadLine());

    var totalReceb = Math.Round(salario+(vendas*0.15), 2).ToString("0.00");
    Console.WriteLine("TOTAL = R$ {0}", totalReceb);
  }
}
