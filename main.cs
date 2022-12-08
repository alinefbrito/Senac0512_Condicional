using System;

class Program {
  public static void Main (string[] args) {
    //declara uma variavel do tipo Inteiro e uma do tipo caractere(texto)
    //A variável String recebe o valor digitado e armazena. Toda entrada é sempre um texto
  Int16 num;
    String entrada;
    //Escreval
    Console.WriteLine("Digite um nro");
    //Leia
    entrada=Console.ReadLine();
    //converte a entrada em texto no formato númerico
    num = Int16.Parse(entrada);
//se(num%2=0) entao 
    //C# a comparação é feita com ==

    
    if (num%2==0)
    {Console.WriteLine("Nro par");
     //condição Se dentro de outra condição
     if (num%3==0)
     {
       Console.WriteLine("Nro divisivel por 3");
     }
     
     }
    else
    {
      Console.WriteLine("Nro Impar");
    }

  //if com condiçoes E --> &&
    // OU --> ||
    if(num%3 ==0  && num%2==0)
    {
      Console.WriteLine("Nro divisivel por 2 e 3 ao mesmo tempo");
    }
    else{
      Console.WriteLine("Nro não divisivel por 2 e 3 ao mesmo tempo");
    }
    
    
    }
}