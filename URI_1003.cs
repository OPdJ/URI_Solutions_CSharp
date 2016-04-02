using System;

class URI{
  static void Main(string[] args){
    
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    int x;
    int y;
    int.TryParse(a, out x);
    int.TryParse(b, out y);

    Console.WriteLine("SOMA = {0}", x + y);
  }
}
