/*Elaborar um programa que calcule e apresente o volume de uma 
caixa retangular, por meio da fórmula: 
volume = comprimento*largura*altura*/

double comprimento;
double largura;
double altura;
double volume;

Console.WriteLine("Informe o comprimento da caixa em centímetros: ");
comprimento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a largura da caixa em centímetros: ");
largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a altura da caixa em centímetros: ");
altura = Convert.ToDouble(Console.ReadLine());

volume = comprimento * largura * altura;

Console.WriteLine("O volume da caixa retangular é: {0} cm³.", volume);