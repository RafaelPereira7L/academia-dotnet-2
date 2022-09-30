/*int contador=0;
int num = 0;
while (num >= 0)
{
    Console.WriteLine("Insira um numero");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        contador++;
        Console.WriteLine(contador+" numeros pares");
    }
}*/


/*1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
*/

/*Console.WriteLine("Informe um numero inteiro positivo");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("Valor incorreto!");
}
else
{
    Console.WriteLine("Numero digitado: "+num);

    for (int i = 1; i < num; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}*/


/*
2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
Exemplo:
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
 
Deseja informar outro número (s/n)? S
 
Digite um número inteiro positivo: 12
Numero digitado: 20
Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
Deseja informar outro número (s/n)? N 
*/

/*char choose = 's';
Console.WriteLine("Informe um numero inteiro positivo");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("Valor incorreto!");
}
else
{
    Console.WriteLine("Numero digitado: "+num);
    
    while (choose == 's')
    {
        for (int i = 1; i < num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Deseja informar outro número? (s/n)");
        choose = Char.Parse(Console.ReadLine());
        if (choose == 's')
        {
            Console.WriteLine("Informe um numero inteiro positivo");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Valor incorreto!");
            }
        }
        else
        {
            return;
        }
    }
}*/



/* 
3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   
*/

/*while (true)
{
    Console.WriteLine("Informe um numero");
    int num = int.Parse(Console.ReadLine());
    if (num == 0)
    {
        return;
    }
    else
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }
        
    }

        int qtdDivisoes = 0;
        int counter = 1;

        while (counter < 8)
        { 
            if (num % counter == 0) qtdDivisoes++;
            counter++;
        }
        if (qtdDivisoes > 2)
        {
            Console.WriteLine("O numero não é primo");
        }
        else
        {
            Console.WriteLine("O numero é primo!");
        }

}*/


/*  
4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco. 
*/
 
/*int joao = 0;
int zeca = 0;
int branco = 0;

while (true)
{
    Console.WriteLine("Informe JOAO, ZECA, BRANCO ou FIM");
    string choose = Console.ReadLine();

    if (choose == "JOAO")
    {
        joao++;
    } else if (choose == "ZECA")
    {
        zeca++;
    }
    else if (choose == "BRANCO")
    {
        branco++;
    }
    else
    {
        Console.WriteLine("Joao -> "+joao);
        Console.WriteLine("Zeca -> "+zeca);
        Console.WriteLine("Brancos -> "+branco);
        return;
    }
}*/



/*
5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos 
e o número de pessoas que votaram.
*/
/*int joao = 0;
int zeca = 0;
int branco = 0;
int nulo = 0;

while (true)
{
    Console.WriteLine("Informe JOAO, ZECA, BRANCO ou FIM");
    string choose = Console.ReadLine();
    if (choose == "JOAO")
    {
        joao++;
    } else if (choose == "ZECA")
    {
        zeca++;
    }
    else if (choose == "BRANCO")
    {
        branco++;
    } else if (choose == "FIM")
    {
        Console.WriteLine("Joao -> "+joao);
        Console.WriteLine("Zeca -> "+zeca);
        Console.WriteLine("Brancos -> "+branco);
        Console.WriteLine("Nulos -> "+nulo);
        if (joao > zeca)
        {
            Console.WriteLine("João foi o candidato vencedor");
        }
        else
        {
            Console.WriteLine("Zeca foi o candidato vencedor");
        }
        return;
    }
    else
    {
        nulo++;
    }
}*/

 
/*
6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.
*/

/*while (true)
{
    Console.WriteLine("Informe a sua idade");
    int idade = int.Parse(Console.ReadLine());

    if (idade <= 0)
    {
        Console.WriteLine("Informe a sua idade");
        idade = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Idade -> "+idade);
        return;
    }
}*/



/* 
7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.
*/


/*string nome;
int idade;
float salario;
do
{
    Console.Write("Nome: ");
    nome = Console.ReadLine();
    if (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Digite um nome válido!!");
    } else
    {
        break;
    }
} while (true);
do
{
    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade <= 0)
    {
        Console.WriteLine("Digite uma idade válida!!");
    } else
    {
        break;
    }
} while (true);
do
{
    Console.Write("Salário: ");
    salario = float.Parse(Console.ReadLine());
    if (salario <= 0)
    {
        Console.WriteLine("Digite um salário válido!!");
    } else
    {
        break;
    }
} while (true);
Console.WriteLine("Seus dados são: ");
Console.WriteLine("Nome: " + nome.ToUpper());
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Salário: " + salario);*/
 
 
 
/* 
8. Faça um programa em VS que solicite um numero inteiro. S
e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
*/

/*while (true)
{

    try
    {    
        Console.WriteLine("Informe um numero inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero -> "+numero);

        Console.WriteLine("Deseja repetir o programa?(s/n)");
        char opt = Char.Parse(Console.ReadLine());
        if (opt != 's')
        {
            return;
        }
    }
    catch
    {
        Console.WriteLine("ERRO, Insira um numero inteiro");
    }
}*/


/*
9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos.
*/

/*
int[] pessoas = new int[30];
int filhos1=0, filhos2=0, filhos3=0, semFilhos =0;

for (int i = 0; i < pessoas.Length; i++)
{
    Console.WriteLine("Informe quantos filhos a pessoa"+i+" possui");
    pessoas[i] = int.Parse(Console.ReadLine());
    if (pessoas[i] >= 3 && pessoas[i] <= 3)
    {
        filhos1++;
    } else if (pessoas[i] >= 4 && pessoas[i] <= 7)
    {
        filhos2++;
    } else if (pessoas[i] >= 8)
    {
        filhos3++;
    }
    else
    {
        semFilhos++;
    }
}
Console.WriteLine(semFilhos+" pessoas não possuem filhos");
Console.WriteLine(filhos1+" pessoas possuem entre 1 e 3 filhos");
Console.WriteLine(filhos2+" pessoas possuem entre 4 e 7 filhos");
Console.WriteLine(filhos3+" pessoas possuem mais de 8 filhos");
*/

/*
10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres.
*/

/*int qtdMasc = 0, qtdFem = 0;
int qtd30 = 0, qtd60 = 0;
int somaIdadeM = 0;
float mediaM = 0;

for (int counter = 0; counter < 4; counter++)
{
    Console.WriteLine("Informe o genero da pessoa "+counter+" M ou F");
    char genero = Char.ToLower(Char.Parse(Console.ReadLine()));
    Console.WriteLine("Informe a idade da pessoa "+counter);
    int idade = int.Parse(Console.ReadLine());
    if (genero == 'm') qtdMasc++;
    if (genero == 'f')
    {
        qtdFem++;
        somaIdadeM += idade;
    }
    if (idade < 30) qtd30++;
    if (idade > 60) qtd60++;
}
mediaM = somaIdadeM / qtdFem;

Console.WriteLine(qtdMasc+" Pessoas do sexo masculino");
Console.WriteLine(qtdFem+" Pessoas do sexo feminino");
Console.WriteLine(qtd30+" Pessoas com idade inferior a 30 anos");
Console.WriteLine(qtd60+" Pessoas com idade inferior a 60 anos");
Console.WriteLine("Média de idade das mulheres "+mediaM);*/



/*
11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
*/

/*int[] nota = new int[5];
int menor = 0, maior = 0, soma = 0;
double media;

for (int i = 0; i < nota.Length; i++)
{
    while (true)
    {
        Console.WriteLine("Informe a nota");
        nota[i] = int.Parse(Console.ReadLine());
        if (nota[i] == -1)
        {
            return;
        }
        else
        {
            if (nota[i] > maior)
            {
                maior = nota[i];
            }

            if (nota[i] < menor)
            {
                menor = nota[i];
            }
            soma += nota[i];
            media = soma / nota[i];
        }
    }
    
}
Console.WriteLine("Maior nota "+maior);
Console.WriteLine("Menor nota "+menor);
Console.WriteLine("Media das notas "+media);*/

/*
 
12. Apresentar o total da soma dos cem primeiros números inteiros.
*/

/*
int soma = 0;

for (int i = 0; i <= 100; i++)
{
    soma = soma + i;
}
Console.WriteLine(soma);
*/

/*
13. Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500.
*/

/*int soma = 0;

for (int i = 0; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        soma = soma + i;
    }
}
Console.WriteLine(soma);*/

/*
14. Mostrar as potências de 2 variando de 0 a 10.
*/

/*
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(Math.Pow(i, 2));
}
*/


/*
15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
Considerar nota 7,0 como mínima para aprovação.
*/
/*int[] nota = new int[4];
int[] pesos = new int[4];
pesos[0] = 2;
pesos[1] = 1;
pesos[2] = 2;
pesos[3] = 4;
int i=0;
int soma=0;
float media;

for (i = 0; i < 4; i++)
{
    Console.WriteLine("Insira a nota");
    nota[i] = int.Parse(Console.ReadLine());
    nota[i] *= pesos[i];
    soma += nota[i];
}
media = soma / 4;
if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}*/

/*
16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N*3*3; N*3*3*3; etc).
*/

/*Console.WriteLine("Informe um numero");
int num = int.Parse(Console.ReadLine());
while (true)
{
    if (num < 250)
    {
        num *= 3;
    }
    else
    {
        return;
    }
}
Console.WriteLine(num);*/

/*
17. Apresentar os quadrados dos números inteiros de 15 a 200.
*/

/*for (int i = 15; i < 200; i++)
{
    Console.WriteLine(Math.Pow(i, 2));
}*/

/*
18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
elevada a um expoente qualquer, ou seja, NM.
*/

/*
Random rnd = new Random();
Console.WriteLine("Informe uma base");
int basePotencia = int.Parse(Console.ReadLine());
int expoente = rnd.Next();
Console.WriteLine(Math.Pow(basePotencia, expoente));
*/

/*
19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 100,00.
O final da leitura de dados se dará com a entrada de um salário negativo.
*/
/*
int counter = 0;
float totalSalario = 0;
float mediaSalario = 0;
float totalFilhos = 0;
float mediaFilhos = 0;
float maiorSalario = 0;

while (true)
{
    Console.WriteLine("Informe o salario");
    float salario = float.Parse(Console.ReadLine());
    totalSalario += salario;
    Console.WriteLine("Informe o numero de filhos");
    float filhos = float.Parse(Console.ReadLine());

    if (salario < 0) return;
    if (salario > maiorSalario) maiorSalario = salario;
    counter++;
}
mediaSalario = totalSalario / counter;
mediaFilhos = totalFilhos / counter;
Console.WriteLine("Media salario "+mediaSalario);
Console.WriteLine("Media filhos "+mediaFilhos);
Console.WriteLine("Maior salario "+maiorSalario);
*/

/*
20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
certa região, a qual coletou os seguintes dados referentes a cada habitante para 
serem analisados:
- sexo (masculino e feminino)
- cor dos olhos (azuis, verdes ou castanhos)
- cor dos cabelos ( louros, castanhos, pretos)
- idade 
 
Faça um algoritmo que determine e escreva: 
 
- a maior idade dos habitantes
- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
e que tenham olhos verdes e cabelos loiros.
O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.*/

/*
int maiorIdade=0;
int quantidadeMulheresCaracteristicas = 0;

while (true)
{
    Console.WriteLine("Informe o sexo (masculino e feminino)");
    string genero = Console.ReadLine();
    Console.WriteLine("Informe a cor dos olhos (azuis, verdes ou castanhos)");
    string olhos = Console.ReadLine();
    Console.WriteLine("Informe a cor dos cabelos ( loiros, castanhos, pretos)");
    string cabelos = Console.ReadLine();
    Console.WriteLine("Informe a idade");
    int idade = int.Parse(Console.ReadLine());

    if (idade > maiorIdade) maiorIdade = idade;
    if (genero == "feminino" && idade >= 18 && idade <= 35 && olhos == "verdes" && cabelos == "loiros")
        quantidadeMulheresCaracteristicas++;
    if (idade == -1) return;

}
Console.WriteLine("Maior idade dos habitantes "+maiorIdade);
Console.WriteLine("Quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos loiros. "+quantidadeMulheresCaracteristicas);*/