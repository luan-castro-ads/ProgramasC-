/*Faça uma função que receba o valor de um produto 
e um percentual de desconto. A função deve retornar 
o valor do produto após a aplicação do desconto.*/

static double precoaposdesconto (double valordesconto, double preco) {
    
    double precocomdesconto;

    precocomdesconto = preco - valordesconto;

    return precocomdesconto;
}

double desconto;
double preco;
double precofinal;
double valordesconto;

Console.WriteLine("Informe o preço do produto: ");
preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a porcentagem de desconto: ");
desconto = Convert.ToDouble(Console.ReadLine());
    if(desconto > 0 && desconto < 100) {
        Console.WriteLine("Faixa de desconto aceita.");
    } else {
        Console.WriteLine("Impossível aplicar esta faixa de desconto.");
    }

valordesconto = (desconto / 100) * preco;

precofinal = precoaposdesconto(valordesconto, preco);

Console.WriteLine("O preço do produto após a aplicação do desconto é: R$ {0:N2}", precofinal);