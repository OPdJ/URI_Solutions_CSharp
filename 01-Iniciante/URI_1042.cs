/*
  Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, 
  uma linha em branco e em seguida, os valores na sequência como foram lidos.
*/

using System;
using System.Linq;

class URI{
  static void Main(string[] args){
    int i = 0;
    string[] values = Console.ReadLine().Split();
    string[] values2 = values.ToArray();

    values = sortValues(values);

    while(i < values.Length)
    {
      Console.WriteLine(values[i]);
      i++;
    }
    Console.WriteLine("");
    i = 0;
    while(i < values.Length)
    {
      Console.WriteLine(values2[i]);
      i++;
    }
  }

  static string[] sortValues(string[] values)
  {
    int i = 0;
    int j = 0;
    bool aux = true;
    string aux2 = "";
    
    while(i < values.Length)
    {
    aux = true;
    j = values.Length;
      while(j <= values.Length && aux)
      {
        if(i == j-1){
          aux = false;
          break;
        }

        if(Convert.ToInt16(values[i]) > Convert.ToInt16(values[j-1])){
          aux2 = values[i];
          values[i] = values[j-1];
          values[j-1] = aux2;
        }
      j--;
      }
    i++;
    }
    return values;
  }
}
