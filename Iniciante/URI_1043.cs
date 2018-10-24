/*
Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
Perimetro = XX.X
Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
Area = XX.X
*/

using System;
using System.Linq;

class URI{
    static void Main(string[] args){
        int i = 0;
        int auxA = 0;
        int auxB = 0;
        Double[] values = Console.ReadLine().Split().Select(valor => Double.Parse(valor)).ToArray();
        bool[] Triangul = new bool[values.Length];

        while(i < values.Length){
            switch(i){
                case 0:
                    auxA = 1;
                    auxB = 2;
                break;
                case 1:
                    auxA = 0;
                    auxB = 2;
                break;
                case 2:
                    auxA = 1;
                    auxB = 0;
                break;
            }

            if(Math.Abs(values[auxA]-values[auxB]) < values[i] && values[i] < (values[auxB]+values[auxA])){
                Triangul[i] = true;
            }
            i++;
        }

        if(Triangul[0] && Triangul[1] && Triangul[2]){
            Console.WriteLine("Perimetro = {0}", (values[0]+values[1]+values[2]).ToString("0.0"));
        } else{
            Console.WriteLine("Area = {0}", (((values[0]+values[1])/2)*values[2]).ToString("0.0"));
        }
    }
}