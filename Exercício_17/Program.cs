
/*Considerando a fórmula para o cálculo da distância 
entre dois pontos (x1, y1) e (x2,y2):
a) Escreva uma função que receba como 
parâmetros as coordenadas de dois pontos e 
retorne a distância entre eles.
b) Escreva um programa C# (função principal) que 
capture do teclado as coordenadas dos 3 
vértices de um triângulo, calcule e imprima o 
perímetro deste triângulo. Este programa deve 
utilizar a função do item anterior.*/

static double distanciaentredoispontos (double x1, double x2, double y1, double y2) {

    double distancia;

    distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

    return distancia;
}

double x1, y1, x2, y2, x3, y3; 

Console.WriteLine("Informe as coordenadas dos 3 vértices do triângulo.");

Console.WriteLine(" Informe a coordenada de x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" Informe a coordenada de y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" Informe a coordenada de x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" Informe a coordenada de y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" Informe a coordenada de x3: ");
x3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" Informe a coordenada de y3: ");
y3 = Convert.ToDouble(Console.ReadLine());

double distancia1, distancia2, distancia3;

distancia1 = distanciaentredoispontos(x1, y1, x2, y2);

distancia2 = distanciaentredoispontos(x2, y2, x3, y3);

distancia3 = distanciaentredoispontos(x3, y3, x1, y1);

double perimetro;

perimetro = distancia1 + distancia2 + distancia3;

Console.WriteLine("O perímetro do triângulo é: {0:N2} ", perimetro);

