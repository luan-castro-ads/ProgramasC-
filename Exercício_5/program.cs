// See https://aka.ms/new-console-template for more information

/*Construa um programa que aplique um
desconto de 25% sobre o preço de um
produto recebido como entrada e imprima o
valor resultante.*/

double precoproduto;
double porcentagemdesconto;
double valordesconto;
double valorfinal;

Console.WriteLine("Informe o preço do produto:");
precoproduto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a porcentagem de desconto do produto:");
porcentagemdesconto = Convert.ToDouble(Console.ReadLine());

valordesconto = (precoproduto * porcentagemdesconto) / 100;

valorfinal = precoproduto - valordesconto;

Console.WriteLine("O valor de desconto do produto foi: {0:N2}", valordesconto);

Console.WriteLine("O valor final do produto após o desconto é: R$ {0:N2}", valorfinal);
