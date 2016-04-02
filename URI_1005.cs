using System;

/*
  Solução Não Aceita pelo URI.
*/

class URI{
  static void Main(string[] args){

    string x = Console.ReadLine().ToString();
    string y = Console.ReadLine();
    double a;
    double b;

    double.TryParse(x, out a);
    double.TryParse(y, out b);

    decimal media = Convert.ToDecimal(Math.Round(((3.5 * a) + (7.5 * b)) / 11.0, 5));

    Console.WriteLine("MEDIA = {0}", media);
  }
}
