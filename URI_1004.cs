using   System;

class URI{
  static void Main(string[] args){
    string x = Console.ReadLine();
    string y = Console.ReadLine();

    int a;
    int b;
    int.TryParse(x, out a);
    int.TryParse(y, out b);

    Console.WriteLine("PROD = {0}", a * b);
  }
}
