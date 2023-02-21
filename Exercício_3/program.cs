// See https://aka.ms/new-console-template for more information

/*Faça um programa que leia os valores dos lados e
altura de um triângulo, calcule e imprima seu
perímetro e área.*/

double ladoa;
double ladob;
double ladoc;
double altura;
double perimetro;
double areatriangulo;

Console.WriteLine("Informe o valor do lado a do triangulo em centímetros:");
ladoa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do lado b, base do triangulo em centímetros:");
ladob = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do lado c do triangulo em centímetros:");
ladoc = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor da altura do triangulo em centímetros:");
altura = Convert.ToDouble(Console.ReadLine());

perimetro = ladoa + ladob + ladoc;

areatriangulo = (ladob * altura) / 2;

Console.WriteLine("O valor do perimetro é: {0:N2} centímetros.", perimetro);

Console.WriteLine("O valor da area do triangulo é: {0:N2} centímetros.", areatriangulo);