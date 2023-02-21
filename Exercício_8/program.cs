// See https://aka.ms/new-console-template for more information

/*Imprimir o valor 2.346728 com 1, 2, 3 e 5 casas
decimais.*/

double numero;
numero = 2.346728;

Console.WriteLine("O valor do numero impresso com 1 casa decimal após a vírgula é: {0:N1}", numero);

Console.WriteLine("O valor do numero impresso com 2 casas decimais após a vírgula é: {0:N2}", numero);

Console.WriteLine("O valor do numero impresso com 3 casa decimais após a vírgula é: {0:N3}", numero);

Console.WriteLine("O valor do numero impresso com 5 casas decimais após a vírgula é: {0:N5}", numero);
