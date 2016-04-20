/*
  Status Submissão: Wrong Answer

  Faça um programa que leia três valores e apresente o maior dos três valores
  lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
  MAIOR AB = (a+b+abs(a-b))/2.  
*/
using System;

class URI{
  static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = ((a+b)+System.Math.Abs(a-b))/2;

    Console.WriteLine("{0} eh maior", ((c+d)+System.Math.Abs(c-d))/2);
  }
}
