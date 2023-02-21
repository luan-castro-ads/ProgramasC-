// See https://aka.ms/new-console-template for more information

/*Elaborar um programa que calcule o índice de massa corporal
(IMC) de um usuário qualquer, sabendo-se que o IMC é
determinado pela divisão da massa do indivíduo (em
quilogramas) pelo quadrado de sua altura (em metros).*/

double quilogramas;
double altura;
double imc;

Console.WriteLine("Informe seu peso em kg: ");
quilogramas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe sua altura em metros: ");
altura = Convert.ToDouble(Console.ReadLine());

imc = quilogramas / (altura * altura);
    if(imc < 18.5) {
        Console.WriteLine("Você está classificado na categoria: magreza");
    } else if (imc >= 18.5 && imc <= 24.9) {
        Console.WriteLine("Você está classificado na categoria: normal");
    } else if (imc > 24.9 && imc <= 29.9) {
        Console.WriteLine("Você está classificado na categoria: sobrepeso");
    } else if (imc >=30 && imc <=34.9) {
        Console.WriteLine("Você está classificado na categoria: obesidade grau 1");
    } else if (imc >= 35 && imc <= 39.9) {
        Console.WriteLine("Você está classificado na categoria: obesidade grau 2");
    } else if (imc >= 40) {
        Console.WriteLine("Você está classificado na categoria: obesidade grau 3");
    }

Console.WriteLine("O seu índice de massa corporal é: {0:N2} ", imc);
