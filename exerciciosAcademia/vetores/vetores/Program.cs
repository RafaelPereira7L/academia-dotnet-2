/*int[] b = new int[5];
Console.WriteLine("Leitura dos valores");
for (int i = 0; i < b.Length; i++)
{
    Console.WriteLine("Digite o valor "+i+" ");
    b[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < b.Length; i++)
{
    Console.WriteLine("Valor índice "+i+" é igual a "+b[i]);
}*/

/*
double[] notas= new double[50];
double media;

Console.WriteLine("Leitura dos valores");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine("Digite a nota do aluno "+i);
    notas[i] = Double.Parse(Console.ReadLine());
}

media = 0;
Console.WriteLine("Calculo da media");
for (int i = 0; i < notas.Length; i++)
{
    media += notas[i];
}
media = media/50;
Console.WriteLine("Media");
Console.WriteLine(media);
*/

/*int[] idade = new int[40];
int i, conta=0;
Console.WriteLine("Informe as idades dos alunos da turma");
for (i = 0; i < idade.Length; i++)
{
    idade[i] = int.Parse(Console.ReadLine());
    if (idade[i] >= 18)
    {
        conta++;
    }
}

Console.WriteLine("Existem "+conta+" alunos com idade maior ou igual a 18 anos");
for (i = 0; i < idade.Length; i++)
{
    if (idade[i] >= 18)
    {
        Console.WriteLine("Aluno "+i+" tem "+idade[i]+" anos");
    }
}*/

/*int[] vetor = new int[10];
int i, maior = -100000;
for (i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o valor "+i);
    vetor[i] = int.Parse(Console.ReadLine());
    if (vetor[i] > maior)
    {
        maior = vetor[i];
    }
}
Console.WriteLine("Maior valor "+maior);*/


/* EXERCICIO 1

int[] vetor = new int[10];
int pares = 0, impares = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
    if (vetor[i] % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}

Console.WriteLine("Quantidade de numeros pares "+pares);
Console.WriteLine("Quantidade de numeros impares "+impares);*/

// EXERCICIO 2
/*int[] vetor = new int[20];
int[] vetor1 = new int[20];
int[] somaVetores = new int[20];


for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor1.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < somaVetores.Length; i++)
{
    somaVetores[i] = vetor[i] + vetor1[i];
    Console.WriteLine(somaVetores[i]);
}*/

// EXERCICIO 3
/*int[] vetor = new int[5];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
    int qtdDivisoes = 0;
    int counter = 1;
    while (counter < 8)
    { 
        if (vetor[i] % counter == 0) qtdDivisoes++;
        counter++;
    }
    if (qtdDivisoes > 2)
    {
        Console.WriteLine("O numero "+vetor[i]+" não é primo");
    }
    else
    {
        Console.WriteLine("O numero "+vetor[i]+" é primo!");
    }
}*/

// EXERCICIO 4
/*int[] vetor = new int[10];
int[] vetor1 = new int[10];
int[] somaVetores = new int[10];


for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor1.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < somaVetores.Length; i++)
{
    somaVetores[i] = vetor[i] * vetor1[i];
}

for (int i = 0; i < somaVetores.Length; i++)
{
    Console.Write(somaVetores[i]+" | ");
}*/

// EXERCICIO 5
/*
int[] vetor = new int[5];
int menorValor = 100000;
int indice = 0;
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());

    if (menorValor > vetor[i])
    {
        menorValor = vetor[i];
        indice = i;
    }
}
Console.WriteLine("Menor valor => "+menorValor+" índice => "+indice);*/

// EXERCICIO 6
/*int[] vetor = new int[11];

for (int i = 1; i < vetor.Length; i++)
{
    int index = vetor.Length - i;
    Console.WriteLine("Informe um numero");
    vetor[index] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i]+" | ");
}*/

// EXERCICIO 7
/*int[] vetor = new int[10];
int[] vetor2 = new int[10];

for (int i = 1; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
    int number = vetor[i];
    if (number % 2 == 0)
    {
        vetor2[i] = number;
    }
    else
    {
        vetor2[(vetor2.Length-i)] = number;
    }
}

for (int i = 1; i < vetor2.Length; i++)
{
    Console.Write(vetor2[i]+" | ");
}*/

// EXERCICIO 8 
/*float[] vetor = new float[5];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = float.Parse(Console.ReadLine());
}


for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] < 0)
    {
        Console.Write(i +" | ");        
    }
    else
    {
        Console.Write(vetor[i]+" | ");        
    }
}*/

// EXERCICIO 9
/*int[] vetor = new int[10];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}
Array.Sort(vetor);
foreach(int num in vetor)
{
    Console.Write(num);
}*/

// EXERCICIO 10
/*int[] vetor = new int[10];
int[] vetor2 = new int[10];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] != 0)
    {
        vetor2[i] = vetor[i];
    }
    else
    {
        vetor2[i] = 2;
    }
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]+" | ");
    Console.WriteLine(vetor2[i]+" | ");
}*/

// EXERCICIO 11
/*int[] vetor = new int[10];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}

Array.Reverse(vetor);
foreach(int num in vetor)
{
    Console.Write(num+" | ");
}*/

// EXERCICIO 12 

int[] vetor = new int[10];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Informe 0 numero");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i < vetor.Length; i++)
{
    
}