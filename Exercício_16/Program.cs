/*Escreva um procedimento que recebe dois 
números inteiros e imprime, a soma, o produto, a 
diferença, o quociente e o resto entre esses dois 
números.*/

static void operações ( double numero1, double numero2) {

    double soma;
    double produto;
    double diferença;
    double quociente;
    double resto;

    soma = numero1 + numero2;
    produto = numero1 * numero2;
    diferença = numero1 - numero2;
    quociente = numero1 / numero2;
    resto = numero1 % numero2;

    Console.WriteLine("O resultado da soma dos dois números é: {0:n2}", soma);
    Console.WriteLine("O resultado da multiplicação dos dois números é: {0:n2}", produto);
    Console.WriteLine("O resultado da diferença entre estes dois números é: {0:n2}", diferença);
    Console.WriteLine("O resultado da divisão dos dois números é: {0:n2}", quociente);
    Console.WriteLine("O resultado do resto da divisão entre os dois números é: {0:n2}", resto);
}

double valor1;
double valor2;

Console.WriteLine("Insira o primeiro número: ");
valor1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o segundo número: ");
valor2 = Convert.ToDouble(Console.ReadLine());

operações(valor1,valor2);
Console.ReadKey();


