// See https://aka.ms/new-console-template for more information

/*Fazer um programa para ler o valor de um produto (em
reais) e o valor de um desconto (em reais). Imprima o
valor do produto após a aplicação do desconto*/

double valorproduto;
double valordesconto;
double valorfinal;

Console.WriteLine("Informe o valor do produto em reais:");
valorproduto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do desconto em reais: ");
valordesconto = Convert.ToDouble(Console.ReadLine());

valorfinal = valorproduto - valordesconto;
    if(valordesconto < valorproduto) {
        Console.WriteLine("O valor do produto em reais após o desconto é de: R$ {0}", valorfinal);        
    } else {
        Console.WriteLine("Não é possível aplicar esse desconto, pois o produto saíra gratuitamente para o cliente.");
    }

