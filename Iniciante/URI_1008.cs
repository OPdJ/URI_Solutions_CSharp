/*
  Status Submissão: Accepted ☑

  Escreva um programa que leia o número de um funcionário, seu número de horas
  trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
  A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
*/
using System;

class URI{
  static void Main(string[] args){
    var qtdFuncionario = int.Parse(Console.ReadLine());
    var numHorasTrab   = int.Parse(Console.ReadLine());
    var valorHoraTrab  = double.Parse(Console.ReadLine());

    var salario = Math.Round(numHorasTrab*valorHoraTrab, 2).ToString("0.00");
    Console.WriteLine("NUMBER = {0}", qtdFuncionario);
    Console.WriteLine("SALARY = U$ {0}", salario);
  }
}
