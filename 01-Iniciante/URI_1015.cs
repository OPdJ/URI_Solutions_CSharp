/*
  Status Submissão: Accepted ☑

  Leia os quatro valores correspondentes aos eixos x e y de dois pontos
  quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles,
  mostrando 4 casas decimais após a vírgula, segundo a fórmula:
  sqrt((x2-x1)²+(y2-y1)²)
*/
using System;

class URI{
  static void Main(string[] args){

    string[] x = Console.ReadLine().Split();
    double a = double.Parse(x[0]);
    double b = double.Parse(x[1]);

    string[] y = Console.ReadLine().Split();
    double c = double.Parse(y[0]);
    double d = double.Parse(y[1]);

    string distancia = Math.Round(Math.Sqrt(Math.Pow(c-a,2)+Math.Pow(d-b,2)), 4).ToString("0.0000");
    Console.WriteLine("{0}", distancia);
  }
}
