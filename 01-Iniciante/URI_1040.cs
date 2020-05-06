/*
  Status Submissão:

  Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente
  às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente,
  para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ".
  Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se
  a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a
  média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve
  imprimir a mensagem "Aluno em exame.".

  No caso do aluno estar em exame, leia um valor correspondente à nota do exame
  obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota
  digitada. Recalcule a média (some a pontuação do exame com a média anteriormente
  calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais )
  ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos
  (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem
  "Media final: " seguido da média final para esse aluno.
*/
using System;

class URI{
  static void Main(string[] args){
    string[] valores = Console.ReadLine().Split();

    var n1 = float.Parse(valores[0]); 
    var n2 = float.Parse(valores[1]); 
    var n3 = float.Parse(valores[2]); 
    var n4 = float.Parse(valores[3]);

    var media = ((n1*2)+(n2*3)+(n3*4)+(n4*1))/10.0;

    if(media >= 7.0){
      Console.WriteLine("Media: {0}", Math.Round(media, 1).ToString("0.0"));
      Console.WriteLine("Aluno aprovado.");
    } else if(media < 5.0){
      Console.WriteLine("Media: {0}", Math.Round(media, 1).ToString("0.0"));
      Console.WriteLine("Aluno reprovado.");
    } else if(media >= 5.0 && media <= 6.9){
      Console.WriteLine("Media: {0}", Math.Round(media, 1).ToString("0.0"));
      Console.WriteLine("Aluno em exame.");
      float n5 = float.Parse(Console.ReadLine());
      media = (media+n5)/2.0; 
      Console.WriteLine("Nota do exame: {0}", Math.Round(n5, 1).ToString("0.0"));
        if(media >= 5.0){
          Console.WriteLine("Aluno aprovado.");
        } else {
          Console.WriteLine("Aluno reprovado.");
        }

      Console.WriteLine("Media final: {0}", Math.Round(media, 1).ToString("0.0"));
    }         
  }
}
