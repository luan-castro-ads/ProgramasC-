
/*Faça uma função que receba o valor de um produto 
e um percentual de acréscimo. A função deve retornar 
o valor do produto após a aplicação do acréscimo.*/

static double jurosproduto (double preco, double acrescimo, double aumentopreco) {
    
    double precoatualizado;

    precoatualizado = preco + aumentopreco;
    return precoatualizado;
}

double preco;
double acrescimo;
double aumentopreco;
double precoatualizado;


Console.WriteLine("Informe o preço do produto: ");
preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o percentual de acréscimo do produto: ");
acrescimo = Convert.ToDouble(Console.ReadLine());
    if(acrescimo > 0) {
        Console.WriteLine("Faixa de acréscimo no valor do produto aceita.");
    } else (acrescimo < 0 && acrescimo >= - 100) {
        Console.WriteLine("Ao aplicar esta faixa de acréscimo. Você estará dando um desconto ao invés de aumentar o preço do produto.");
    }

aumentopreco = (acrescimo / 100) * preco;

precoatualizado = jurosproduto (preco, acrescimo, aumentopreco);

Console.WriteLine("O preço do produto após a aplicação do acréscimo é: R$ {0:n2}", precoatualizado);