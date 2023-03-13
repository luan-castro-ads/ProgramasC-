/*Faça um procedimento que receba por parâmetro 
o tempo de duração de um experimento expresso 
em segundos e imprima na tela esse mesmo tempo 
em horas, minutos e segundos.*/

static void duracaoevento (int duracao) {

    int horas;
    int minutos;
    int segundos;
    
    horas = duracao / 3600;

    minutos = (duracao % 3600) / 60;

    segundos = duracao - ((horas * 3600) + (minutos * 60));

    Console.WriteLine("O evento informado durou: {0} horas, {1} minutos e {2} segundos.", horas, minutos, segundos);
}

int duracaosegundos; 

Console.WriteLine("Informe a duração do evento em segundos: ");
duracaosegundos = Convert.ToInt32(Console.ReadLine());

duracaoevento(duracaosegundos);




