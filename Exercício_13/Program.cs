static void mediaaritmetica (double valor1, double valor2, double valor3, double media)
{
    Console.WriteLine("A media dos numeros informados é: {0:N2}", media);
}

double numero1;
double numero2;
double numero3;
double medianumeros;

Console.WriteLine("Informe o primeiro número: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o terceiro número: ");
numero3 = Convert.ToDouble(Console.ReadLine());

medianumeros = (numero1 + numero2 + numero3) / 3;

mediaaritmetica(numero1, numero2, numero3, medianumeros);

Console.ReadKey();
