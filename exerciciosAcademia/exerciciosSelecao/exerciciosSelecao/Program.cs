/* EXERCICIO 1
float area;
Console.WriteLine("Infome o valor da altura");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine("Infome o valor da base");
float baseTriangulo = float.Parse(Console.ReadLine());

if (altura == 0 || baseTriangulo == 0)
{
    Console.WriteLine("Por favor insira os valores corretamente.");
}
else
{
    area = (baseTriangulo * altura) / 2;
    Console.WriteLine("A area do triangulo é: "+area);
}
*/ 

/* EXERCICIO 2
Console.WriteLine("Informe um numero");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("O numero é PAR");
}
else
{
    Console.WriteLine("O numero é IMPAR");
}*/

 /* EXERCICIO 3
double media;
Console.WriteLine("Informe o numero 1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o numero 2");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o numero 3");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o numero 4");
int num4 = int.Parse(Console.ReadLine());

media = (num1+num2+num3+num4)/4;

if (num1 > media)
{
    Console.WriteLine("O numero 1 é superior a media");
}
if (num2 > media)
{
    Console.WriteLine("O numero 2 é superior a media");
}if (num3 > media)
{
    Console.WriteLine("O numero 3 é superior a media");
}if (num4 > media)
{
    Console.WriteLine("O numero 4 é superior a media");
}*/

/* EXERCICIO 4
Console.WriteLine("Insira a quantidade de horas de aulas dadas pelo Professor1");
int horasProf1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor por hora do Professor1");
int valorProf1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a quantidade de horas de aulas dadas pelo Professor2");
int horasProf2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor por hora do Professor2");
int valorProf2 = int.Parse(Console.ReadLine());

int salarioProf1 = horasProf1*valorProf1;
int salarioProf2 = horasProf2*valorProf2;

if (salarioProf1 > salarioProf2)
{
    Console.WriteLine("O Professor1 tem o salario superior ao Professor2");
}
else
{
    Console.WriteLine("O Professor2 tem o salario superior ao Professor1");
}*/

/* EXERCICIO 5
Console.WriteLine("Insira a Nota1");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a Nota2");
float nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;
if (media >= 7)
{
    Console.WriteLine("APROVADO!");
}
else
{
    Console.WriteLine("Insira a nota do exame");
    float exame = float.Parse(Console.ReadLine());
    float mediaFinal = (exame + media) / 2;
    if (mediaFinal >= 5)
    {
        Console.WriteLine("APROVADO!");
    }
    else
    {
        Console.WriteLine("REPROVADO!");
    }
}*/

/* EXERCICIO 6
Console.WriteLine("Insira o nome");
string nome = Console.ReadLine().ToUpper();
Console.WriteLine("Insira a altura(metros)");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o peso(KG)");
float peso = float.Parse(Console.ReadLine());
float imc = peso / (altura * altura);

if (imc < 18)
{
    Console.WriteLine(nome+" -> Baixo peso");
} else if (imc >= 18 && imc < 25)
{
    Console.WriteLine(nome+" -> Peso normal");
} else if (imc >= 25 && imc < 30)
{
    Console.WriteLine(nome+" -> Sobrepeso");
} else if (imc >= 30 && imc < 35)
{
    Console.WriteLine(nome+" -> Obesidade");
} else if (imc >= 35)
{
    Console.WriteLine(nome+" -> Obesidade grau sério");
}*/

/* EXERCICIO 7
Console.WriteLine("Informe a frase");
string frase = Console.ReadLine();
Console.WriteLine("Informe a palavra para pesquisar");
string palavra = Console.ReadLine();

if (frase.Contains(palavra))
{
    Console.WriteLine("A palavra "+palavra+" está na frase "+frase);
}
else
{
    Console.WriteLine("A palavra "+palavra+" NÃO está na frase");
}*/

/* EXERCICIO 8
Console.WriteLine("Informe o codigo do funcionario");
int codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o salario base do funcionario");
float salarioBase = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o total de vendas do funcionario");
float totalVendas = float.Parse(Console.ReadLine());

if (totalVendas >= 10000)
{
    double salario = salarioBase + totalVendas*0.1;

    Console.WriteLine("O salario do funcionario "+codigo+" será de: "+salario);
} else if (totalVendas >= 1000)
{
    double salario = salarioBase + totalVendas*0.07;
    Console.WriteLine("O salario do funcionario "+codigo+" será de: "+salario);
} else if (totalVendas >= 500)
{
    double salario = salarioBase + totalVendas*0.05;
    Console.WriteLine("O salario do funcionario "+codigo+" será de: "+salario);
}
else
{
    Console.WriteLine("O salario do funcionario "+codigo+" será de: "+salarioBase);
}*/

/* EXERCICIO 9
Console.WriteLine("Informe a medição de glicemia");
float glicemia1 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a medição de glicemia");
float glicemia2 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a medição de glicemia");
float glicemia3 = float.Parse(Console.ReadLine());
float media = (glicemia1 + glicemia2 + glicemia3) / 3;

if (glicemia1 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
} else if (glicemia1 > 250)
{
    Console.WriteLine("Risco de hiperglicemia");
}
if (glicemia2 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
} else if (glicemia2 > 250)
{
    Console.WriteLine("Risco de hiperglicemia");
}
if (glicemia3 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
} else if (glicemia3 > 250)
{
    Console.WriteLine("Risco de hiperglicemia");
}

if (media < 80)
{
    Console.WriteLine("É preciso diminuir 2 unidades de insulina");
} else if (media > 150)
{
    Console.WriteLine("É necessário adicionar 2 unidades de insulina");
}*/

/* EXERCICIO 10
Console.WriteLine("Informe o nome do atleta1");
string nome1 = Console.ReadLine();
Console.WriteLine("Informe a idade do atleta1");
int idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a altura do atleta1");
float altura1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o nome do atleta2");
string nome2 = Console.ReadLine();
Console.WriteLine("Informe a idade do atleta2");
int idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a altura do atleta2");
float altura2 = float.Parse(Console.ReadLine());

if (altura1 >= altura2 && idade1 < idade2)
{
    Console.WriteLine(nome1+" "+idade1+" "+altura1);
}
else
{
    Console.WriteLine(nome2+" "+idade2+" "+altura2);
}*/

/* EXERCICIO 11
Console.WriteLine("Insira a hora");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Insira os minutos");
int minutos = int.Parse(Console.ReadLine());

if (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <= 59)
{
    Console.WriteLine(hora+":"+minutos);
}
else
{
    Console.WriteLine("Informe os valores corretamente");
}*/


/* EXERCICIO 12
Console.WriteLine("Informe o codigo do operario");
int codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o numero de horas trabalhadas do operario");
int numeroHoras = int.Parse(Console.ReadLine());
float salario = numeroHoras * 10;
Console.WriteLine("Salario base: "+salario);
if (numeroHoras > 50)
{
    float extra = (numeroHoras - 50) * 20;
    Console.WriteLine("Operario "+codigo);
    Console.WriteLine("Salario total: "+ (extra+salario));
    Console.WriteLine("Salario excedente: "+extra);
}
else
{
    float extra = 0;
    Console.WriteLine("Operario "+codigo);
    Console.WriteLine("Salario total: "+ (extra+salario));
    Console.WriteLine("Salario excedente: "+extra);
}*/

/* EXERCICIO 13
Console.WriteLine("Informe a altura");
float altura = float.Parse(Console.ReadLine());

double homem = (72.7 * altura) - 58;
double mulher = (62.1 * altura) - 44.7;

Console.WriteLine("Peso ideal para homem: "+homem);
Console.WriteLine("Peso ideal para mulher: "+mulher);
*/


/*
EXERCICIO 14
Console.WriteLine("Informe o tamanho do arquivo(em MB)");
float tamanho = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a velocidade da internet(em MBps)");
float velocidade = float.Parse(Console.ReadLine());
float tempo = tamanho / velocidade;
Console.WriteLine("Tempo aproximado de download: "+tempo/60+" minutos");
*/


/*
EXERCICIO 15
Console.WriteLine("Informe o tamanho em metros quadrados da área a ser pintada");
float tamanho = float.Parse(Console.ReadLine());
float litros = 3;
float qtdLatas = (tamanho / litros)/18;
float preco = qtdLatas*80;
Console.WriteLine("Quantidade de latas: "+qtdLatas);
Console.WriteLine("Preço total: "+preco);*/

/*
16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).

18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
plus: você pode gerar o número de forma randomica (função random c#).

*/

