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
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Informe um numero");
        matriz2[i, j] = int.Parse(Console.ReadLine());
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



