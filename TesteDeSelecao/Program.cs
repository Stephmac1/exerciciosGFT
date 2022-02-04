﻿//Desafio
//Leia 4 valores inteiros A, B, C e D. Com base nisso, se o valor de B for maior do que de C e se D for maior do que A,
//e a soma de C com D for maior que a soma de A e B e se tanto C quanto D forem positivos e, ainda, se a variável A for par, 
//escreva a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

//Entrada
//Quatro números inteiros A, B, C e D.

//Saída
//Imprima a mensagem corretamente esperada pela validação dos valores.

using System; 

class MinhaClasse {

    static void Main(string[] args) { 

        string [] selections = Console.ReadLine().Split(' ');
        int a = int.Parse(selections[0]);
        int b = int.Parse(selections[1]);
        int c = int.Parse(selections[2]);
        int d = int.Parse(selections[3]);

        int soma1 = c + d;
        int soma2 = a + b;

        if (b > c && d > a && soma1>soma2 && c > 0 && d > 0 && a % 2 ==0)
		{
          Console.WriteLine("Valores aceitos");
        } 
        else{
            Console.WriteLine("Valores nao aceitos");
        }
    }
}
