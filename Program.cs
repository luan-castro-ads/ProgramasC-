// See https://aka.ms/new-console-template for more information

/*Faça um programa que lê uma temperatura em
graus Celsius e apresenta-a convertida em graus
Fahrenheit. A fórmula de conversão: F ←
(9*C+160)/5*/

double temperaturacelsius;
double temperaturafahrenheit;

Console.WriteLine("Informe uma temperatura em graus Celsius.");
temperaturacelsius = Convert.ToDouble(Console.ReadLine());

temperaturafahrenheit = ( 9 * temperaturacelsius + 160) / 5;

Console.WriteLine("A temperatura informada corresponde a {0} graus fahrenheit.", temperaturafahrenheit);