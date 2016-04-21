/*
  Status Submissão: Runtime Error ⚑

  Leia os quatro valores correspondentes aos eixos x e y de dois pontos
  quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles,
  mostrando 4 casas decimais após a vírgula, segundo a fórmula:
*/
using System;

class URI{
  static void Main(string[] args){
    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double d = double.Parse(Console.ReadLine());

    Console.WriteLine("{0}", Math.Round(Math.Sqrt(Math.Pow(c-a,2)+Math.Pow(d-b,2)), 4));
  }
}
