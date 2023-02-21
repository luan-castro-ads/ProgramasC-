// See https://aka.ms/new-console-template for more information

/*Fazer um programa para imprimir na primeira linha o
dia, na segunda linha o mês e na terceira o ano de seu
nascimento.
*/

int dia;
string mes;
int ano;

Console.WriteLine("Informe o dia do seu nascimento.");
dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o nome do mês de seu nascimento");
mes = Convert.ToString(Console.ReadLine());

Console.WriteLine("Informe o ano de seu nascimento");
ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você nasceu no dia:");
Console.WriteLine("{0}", dia);
Console.WriteLine("{0}", mes);
Console.WriteLine("{0}", ano);

