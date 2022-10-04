// EXERCICIO 1
/*int[,] matriz = new int[5,3];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (j == 0)
        {
            Console.WriteLine("Informe numeros para a primeira coluna");
            matriz[i, j] = int.Parse(Console.ReadLine());
            matriz[i, 1] = matriz[i,j] +10;
            matriz[i, 2] = matriz[i, j] * 2;
        }
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
    }
    Console.WriteLine();
}*/

// EXERCICIO 2
/*int[,] matriz = new int[5,3];
Console.WriteLine("Preencha a matriz 3x3");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
            Console.WriteLine("Informe um numero");
            matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 3; i++)
{
    matriz[i, i] += matriz[i, i];
}
for (int j = 0; j < 3; j++)
{ 
    matriz[j, j] += matriz[j, j];
}

for (int i = 0; i < 3; i++)
{
    Console.Write("[" + i + "," + i + "] = " + matriz[i, i] + "  ");
    Console.WriteLine();
}

for (int j = 0; j < 3; j++)
{
    Console.Write("[" + j + "," + j + "] = " + matriz[j, j] + "  ");
    Console.WriteLine();
}*/

// EXERCICIO 3
/*
int[,]matriz = new int[4,4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 4; i++)
{
    Console.Write("[" + i + "," + i + "] = " + matriz[i, i] + "  ");
}
*/

// EXERCICIO 4
/*int[,]matriz = new int[5,5];
int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (matriz[i, j] % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }
        if (matriz[i, j] >= 0)
        {
            positivos++;
        }
        else
        {
            negativos++;
        }
        if (matriz[i, j] == 0) zeros++;
    }
}
Console.WriteLine("Quantidade de pares "+pares);
Console.WriteLine("Quantidade de impares "+impares);
Console.WriteLine("Quantidade de positivos "+positivos);
Console.WriteLine("Quantidade de negativos "+negativos);
Console.WriteLine("Quantidade de zeros "+zeros);*/

// EXERCICIO 5
/*double[,]matriz = new double[2,3];
double[,]matriz2 = new double[2,3];
double[,]soma = new double[2,3];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i, j] = double.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz2[i, j] = double.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        soma[i, j] = matriz[i, j] + matriz2[i, j];
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("[" + i + "," + j + "] = " + soma[i, j] + "  ");
    }
}*/

// EXERCICIO 6
/*Random random = new Random();
int randomNumber = random.Next(0,9);
int[,]matriz = new int[4,4];
int maior = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matriz[i, j] = randomNumber;
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (matriz[i, j] > maior) maior = matriz[i, j];
    }
}
Console.WriteLine("O maior numero da matriz é: "+maior);*/

// EXERCICIO 7
/*int[,]matriz = new int[3,3];
int[,]matriz2 = new int[3,3];
int[,]matrizSubtracao = new int[3,3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz2[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrizSubtracao[i, j] = matriz[i, j] - matriz2[i, j];
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("[" + i + "," + j + "] = " + matrizSubtracao[i, j] + "  ");
    }
}*/

// EXERCICIO 9 
/*int[,]matriz = new int[4,4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[(3 - i), (3 - j)] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
    }
}*/

// EXERCICIO 10 
/*int[,]matriz = new int[3,3];
bool result=false;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Pesquise um numero");
int numero = int.Parse(Console.ReadLine());

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (matriz[i, j] == numero)
        {
            Console.WriteLine("O número existe no vetor");
            return;
        }
        else
        {
            Console.WriteLine("Número inexistente");
        }
    }
}*/

// EXERCICIO 11
/*double[,]matriz = new double[4,4];
double[,]matriz2 = new double[4,4];
double media=0;
int abaixo = 0, acima = 0, naMedia = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i,j] = double.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz2[i,j] = double.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        media += matriz[i, j] / matriz2[i, j];
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        media += matriz[i, j] / matriz2[i, j];
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (matriz[i, j] < media) abaixo++;
        if (matriz2[i, j] < media) abaixo++;
        if (matriz[i, j] == media) naMedia++;
        if (matriz2[i, j] == media) naMedia++;
        if (matriz[i, j] > media) acima++;
        if (matriz2[i, j] > media) acima++;
    }
}
Console.WriteLine("Elementos abaixo da media "+abaixo);
Console.WriteLine("Elementos na media "+naMedia);
Console.WriteLine("Elementos acima da media "+acima);*/


// EXERCICIO 12
/*
double[,]matriz = new double[3,3];
double[,]resultante = new double[3,3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i,j] = double.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        resultante[i, j] = matriz[i, j] / (i + j);
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("[" + i + "," + j + "] = " + resultante[i, j] + "  ");
    }
}*/

// EXERCICIO 13
/*int[,]matriz = new int[4,3];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if((i + j)%2==0) Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
    }
}*/

// EXERCICIO 14
/*int[,]matriz = new int[5,5];
int somaPrincipal = 0;
int somaSecundaria = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 5; i++)
{
    somaPrincipal += matriz[i, i];
    somaSecundaria += matriz[4-i, i];
}
if(somaPrincipal == somaSecundaria)
{
    Console.WriteLine("A soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária");
}
else
{
    Console.WriteLine(
        "A soma dos elementos da diagonal principal NÃO é igual a soma dos elementos da diagonal secundária");
}*/

// EXERCICIO 15
/*int[,]matriz = new int[5,5];
bool elementosIguais = false;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 5; i++)
{
    if (matriz[i, i] == matriz[4 - i, i])
    {
        elementosIguais = true;
    }
    else
    {
        elementosIguais = false;
    }
}
if(elementosIguais == true)
{
    Console.WriteLine("Os elementos da diagonal principal são iguais aos da secundária");
}
else
{
    Console.WriteLine("Os elementos da diagonal principal NÃO são iguais aos da secundária");
}*/

// EXERCICIO 16
/*int[,]matriz = new int[4,4];
int[,]matriz2 = new int[4,4];
int[,]soma = new int[4,4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz2[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        soma[i, j] = matriz[i, j] + matriz2[i, j];
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("[" + i + "," + j + "] = " + soma[i, j] + "  ");
    }
}*/

// EXERCICIO 17
/*int[,]matriz = new int[3,4];
int[,]matrizTransposta = new int[4,3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrizTransposta[i, j] = matriz[j, i];
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("[" + i + "," + j + "] = " + matrizTransposta[i, j] + "  ");
    }
}*/

// EXERCICIO 18
/*int[,]matriz = new int[10,10];
int menor = 10000, maior = 0;
int[,] menorElemento = new int[3,1];
int linhaMaiorElemento = 0;
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (matriz[i, j] > maior)
        {
            maior = matriz[i, j];
            linhaMaiorElemento = i;
        }
        if (matriz[linhaMaiorElemento, j] < menor)
        {
            menor = matriz[linhaMaiorElemento, j];
            menorElemento[0,0] = matriz[linhaMaiorElemento, j];
            menorElemento[1,0] = linhaMaiorElemento;
            menorElemento[2,0] = j;
        }
    }
}
Console.WriteLine("Elemento minimax: "+menorElemento[0,0]);
Console.WriteLine("Linha do elemento minimax: "+menorElemento[1,0]);
Console.WriteLine("Coluna do elemento minimax: "+menorElemento[2,0]);*/
