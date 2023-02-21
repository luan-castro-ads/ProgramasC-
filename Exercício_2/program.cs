// See https://aka.ms/new-console-template for more information

/*Faça um programa que lê um valor de salário
mínimo e o salário de um funcionário. O programa
deve calcular e imprimir quantos salários mínimos
esse funcionário ganha. */

double salariominimo;
double salariofuncionario;
double proporcaosalarial;

Console.WriteLine("Informe o valor do salário minímo.");
salariominimo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o salário do funcionário.");
salariofuncionario = Convert.ToDouble(Console.ReadLine());

proporcaosalarial = salariofuncionario / salariominimo;

Console.WriteLine("O funcionario recebe o equivalente a: {0:N2} salários minímos", proporcaosalarial);

