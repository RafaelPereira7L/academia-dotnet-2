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
/*int[] vetor = new int[10];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Informe um numero para verificar se está no array");
int numero = int.Parse(Console.ReadLine());
bool result = false;
int posicao = 0;
for (int i = 0; i < vetor.Length; i++)
{
    if (numero == vetor[i])
    {
        result = true;
        posicao = i;
    }
}
if (result == true)
{
    Console.WriteLine("O numero " + numero + " está no vetor na posição " + posicao);
}
else
{
    Console.WriteLine("O número fornecido não existe no vetor!");
}*/

// EXERCICIO 13
/*int[] vetor = new int[100];
int qtd2 = 0, qtd4 = 0, qtd8 = 0;
int i = 0;
while (true)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
    if (vetor[i] == 2) qtd2++;
    if (vetor[i] == 4) qtd4++;
    if (vetor[i] == 8) qtd8++;
    if (vetor[i] == -1) return;
    i++;
}
Console.WriteLine("O numero 2 aparece "+qtd2+" vezes");
Console.WriteLine("O numero 4 aparece "+qtd4+" vezes");
Console.WriteLine("O numero 8 aparece "+qtd8+" vezes");*/

// EXERCICIO 14
/*int[] vetor = new int[50];
int codigo = 1;

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());

    if (vetor[i] == 0) return;
    if (vetor[i] == 1) codigo = 1;
    if (vetor[i] == 2) codigo = 2;
}

if (codigo == 1)
{
    foreach(int num in vetor)
    {
        Console.Write(num+" | ");
    }
}
else
{
    Array.Reverse(vetor);
    foreach(int num in vetor)
    {
        Console.Write(num+" | ");
    }
}*/

// EXERCICIO 15
/*int[] vetor = new int[50];
int[] vetor2 = new int[50];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um numero");
    vetor[i] = int.Parse(Console.ReadLine());
}
vetor2 = vetor;
Array.Reverse(vetor2);
foreach(int num in vetor)
{
    Console.Write(num+" | ");
}
Console.WriteLine("");
foreach(int num in vetor2)
{
    Console.Write(num+" | ");
}*/

// EXERCICIO 16
/*int[] x = new int[10] { 1,2,3,4,5,6,7,8,9, 10 };
int[] y = new int[10] { 1,6,30,4,5,60,7,9, 10, 11 };
int[] uniao = new int[20];
int[] diferenca = new int[10];
int[] interseccao = new int[10];
Console.WriteLine("UNIÃO");
x.CopyTo(uniao, 0);
int auxU = 10;
// 0  1  2  3  4  5  6  7  8   9
//int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] y = new int[10] { 1, 6,30, 4, 5,60, 7, 9,10, 11 };
for (int i = 0; i < y.Length; i++) 
{//elementos de x e elementos y que não estão em X            
for (int j = 0; j < x.Length; j++)
{
    if(y[i] == x[j])
    {
        break;
    }
    if(j == (x.Length - 1))
    {
        uniao[auxU] = y[i];
        auxU++;
    }
}
}
for (int i = 0; i < auxU; i++)
{
    Console.WriteLine(uniao[i]);
}
Console.WriteLine("");
Console.WriteLine("DIFERENÇA");
//diferença - elementos de X que não estão no Y
// 0  1  2  3  4  5  6  7  8   9
//int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] y = new int[10] { 1, 6,30, 4, 5,60, 7, 9,10, 11 };
Console.WriteLine("INTERSECÇÃO");
//os elementos que aparecem em X e Y            
int auxI = 0;
for (int i = 0; i < x.Length; i++)
{
    for (int j = 0; j < y.Length; j++)
    {
        if (x[i] == y[i])
        {
            interseccao[auxI] = x[i];
            auxI++;
            break;
        }
    }
}
for (int i = 0; i < auxI; i++)
{
    Console.WriteLine(interseccao[i]);
}
Console.WriteLine("");*/