/*
  Status Submissão: Accepted ☑

  Leia um valor inteiro, que é o tempo de duração em segundos de um determinado
  evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
*/
using System;

class URI{
  static void Main(string[] args){
    int hours, minut, seg;
    int x = int.Parse(Console.ReadLine());

    hours = x/3600;
    minut = (x-(hours*3600))/60;
    seg = x-(hours*3600)-(minut*60);

    Console.WriteLine("{0}:{1}:{2}", hours, minut, seg);
  }
}
