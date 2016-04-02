/*
  Status Submissão: Accepted
*/
using System;

class URI{
  static void Main(string[] args){
    double a = int.Parse(Console.ReadLine());

    Console.WriteLine("{0} minutos", Math.Round((a/30)*60));
  }
}
