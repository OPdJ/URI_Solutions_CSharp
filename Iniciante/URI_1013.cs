/*
  Status Submissão: Accepted ☑

  Faça um programa que leia três valores e apresente o maior dos três valores
  lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
  MAIOR AB = (a+b+abs(a-b))/2.
*/
using System;

class URI{
  static void Main(string[] args){
    string[] y = Console.ReadLine().Split();
    int a = int.Parse(y[0]);
    int b = int.Parse(y[1]);
    int c = int.Parse(y[2]);
    int d = ((a+b)+System.Math.Abs(a-b))/2;
    int e = ((c+d)+System.Math.Abs(c-d))/2;

    Console.WriteLine("{0} eh o maior", e);
  }
}
