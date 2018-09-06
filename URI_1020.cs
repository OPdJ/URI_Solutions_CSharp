/*
  Status Submissão: Accepted ☑

  Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a
  em anos, meses e dias

  Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo
  mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses
  e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de
  testar raciocínio matemático simples.
*/
using System;

class URI{
  static void Main(string[] args){
    string[] periodos = {"ano", "mes", "dia"};
    int year, month, day;

    int x = int.Parse(Console.ReadLine());
    year = x/365;
    month = (x%365)/30;
    day = (x%365)%30;

    Console.WriteLine("{0} {1}(s)", year, periodos[0]);
    Console.WriteLine("{0} {1}(es)", month, periodos[1]);
    Console.WriteLine("{0} {1}(s)", day, periodos[2]);
  }
}
