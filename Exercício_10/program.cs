// See https://aka.ms/new-console-template for more information

/*Escreva um programa para efetuar as quatro operações
matemáticas básicas (adição, subtração, produto e divisão)
sobre dois valores informados*/

int operacao;
double numero1;
double numero2;
double adicao;
double subtracao;
double multiplicacao;
double divisao;

Console.WriteLine("Informe o primeiro número:");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o outro número:");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a operação desejada:");
Console.WriteLine("1 = Adição");
Console.WriteLine("2 = Subtração");
Console.WriteLine("3 = multiplicação");
Console.WriteLine("4 = divisão");

operacao = Convert.ToInt32(Console.ReadLine());
    if(operacao < 1 || operacao > 4){
        Console.WriteLine("Você não escolheu uma das 4 operações matématicas básicas");
    } else if (operacao == 1) {
        Console.WriteLine("A opção escolhida foi a adição.");
        adicao = numero1 + numero2;
        Console.WriteLine("A soma dos numeros informados é: {0}", adicao);
    } else if (operacao == 2) {
        Console.WriteLine("A opção escolhida foi a subtração");
        subtracao = numero1 - numero2;
        Console.WriteLine("O resultado da subtração destes dois números é: {0}", subtracao);
    } else if (operacao == 3){
        Console.WriteLine("A opção escolhida foi a multiplicação");
        multiplicacao = numero1 * numero2;
        Console.WriteLine("O resultado da multiplicação destes dois números é: {0}", multiplicacao);
    } else if (operacao == 4) {
        Console.WriteLine("A opção escolhida foi a divisão");
        divisao = numero1 / numero2;
        Console.WriteLine("o resultado da divisão é: {0}", divisao);
    }

