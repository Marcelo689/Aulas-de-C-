﻿using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           string nomeCompleto,frase,ultimoNome;
           int qtdQuartos,idade;
           double precoInternet,altura;

            Console.Write("Informe seu nome completo :");
            nomeCompleto = Console.ReadLine();
            Console.Write("Quantos quartos tem na sua casa? ");
            qtdQuartos = int.Parse(Console.ReadLine());
            Console.Write("Informe o preço da sua internet: ");
            precoInternet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe seu último nome, idade e altura(mesma linha)");
            frase= Console.ReadLine();

            string[] vetor= frase.Split(" ");

            ultimoNome= vetor[0];
            idade = int.Parse(vetor[1]);
            altura =double.Parse(vetor[2]);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoInternet.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}
