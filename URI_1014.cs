using System;

class URI{
  static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("{0} km/l", Math.Round((a/b),3));
  }
}
