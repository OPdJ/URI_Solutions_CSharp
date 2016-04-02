using System;

class URI{
  static void Main(string[] args){

    string A = Console.ReadLine();
    string B = Console.ReadLine();
    short y;
    short z;

    short.TryParse(A, out y);
    short.TryParse(B, out z);

    Console.WriteLine("X = {0}", y + z);
  }
}
