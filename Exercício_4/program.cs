// See https://aka.ms/new-console-template for more information

/*Faça um programa que leia um número inteiro
e imprima o seu antecessor e sucessor.*/

int numero;
int numeroanterior;
int numeroposterior;

Console.WriteLine("Informe um numero inteiro.");
numero = Convert.ToInt32(Console.ReadLine());

numeroanterior = numero - 1;

numeroposterior = numero + 1;

Console.WriteLine("O numero anterior ao número informado é: {0}", numeroanterior);

Console.WriteLine("O numero posterior ao número informado é: {0}", numeroposterior);


