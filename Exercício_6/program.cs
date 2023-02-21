// See https://aka.ms/new-console-template for more information

/* Construa um programa para ler um intervalo
de tempo em segundos, converter para
horas, minutos e segundos e imprimir o
resultado.*/

int quantidadesegundos;
int horas;
int minutos;
int segundos;

Console.WriteLine("Informe uma quantidade em segundos: ");
quantidadesegundos = Convert.ToInt32(Console.ReadLine());

horas = quantidadesegundos / 3600;
minutos = (quantidadesegundos % 3600) / 60;
segundos = quantidadesegundos - ((horas * 3600) + ( minutos * 60));

Console.WriteLine("A quantidade de segundos informada corresponde a: {0} horas, {1} minutos e {2} segundos", horas, minutos, segundos);

