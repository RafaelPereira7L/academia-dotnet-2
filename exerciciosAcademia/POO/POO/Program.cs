/*1. Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e 
que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e 
exibir a lista ordenada.
*/

/*List<string> nomes = new List<string>();
do
{
    Console.WriteLine("Informe um nome");
    Console.WriteLine("Para sair digite 'sair'");
    string nome = Console.ReadLine();
    string[] nomeCompleto = nome.Split(" ");

    if (nome == "sair") break;
    if (nomeCompleto.Length < 2)
    {
        Console.WriteLine("O nome deve conter no mínimo duas palavras");
    }
    if (nomes.Contains(nome.ToUpper()))
    {
        Console.WriteLine("Este nome já está cadastrado!");
    }
    else
    {
        nomes.Add(nome.ToUpper());
        nomes.Sort();
    }
} while (true);

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}*/

/*
2. Fazer um programa em VS que popule uma lista com números inteiros (0 a 1000) que sejam sorteados
randomicamente. O programa deve pedir ao usuário quantos números deseja armazenar. Ao final, o programa
deve exibir os números populados na lista.
*/

/*Random rnd = new Random();
List<int> numbers = new List<int>();

Console.WriteLine("Quantos numeros você deseja armazenar na lista?");
int quantity = int.Parse(Console.ReadLine());

for (int i = 0; i < quantity; i++)
{
    numbers.Add(rnd.Next(0, 1000));
}

foreach (var number in numbers)
{
    Console.WriteLine(number);
}*/


/*
3. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
lista, o programa deve listar os domínios de emails cadastrados no programa.

Menu
1 - Cadastrar email
2 - Listar 
3 - Sair 
Opção: 
*/
/*List<string> emails = new List<string>();

while (true)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1 - Cadastrar email");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("Opção: ");
    int opcao = int.Parse(Console.ReadLine());
    
    if (opcao == 1)
    {
        Console.WriteLine("Informe o email");
        string email = Console.ReadLine();
        if(!emails.Contains(email))
        {
            emails.Add(email);
        }
        else
        {
            Console.WriteLine("Este email já está cadastrado");
        }
    }

    else if (opcao == 2)
    {
        foreach (var email in emails)
        {
            Console.Write(email+" | ");
        }

        Console.WriteLine("");
    }
    else
    {
        return;
    }
}*/

/*
4. Fazer um programa em VS que realize um CRUD (inserir, pesquisar, atualizar e deletar) 
completo em uma lista de nomes de criptomoedas. Neste programa, somente o nome da criptomoeda deve 
ser cadastrado (em maiúsculo). Ao cadastrar, não pode haver duplicidade de dados na lista. Sempre
que a opção listar for acionada, a listagem deve ser exibida de forma ordenada. No processo de 
remoção, o usuário entra com o nome da criptomoeda que deseja remover. Caso o programa a encontre,
deve remover e avisar o usuário que a operação ocorreu corretamente, e caso não a encontre, avisar
ao usuário que nome não foi encontrado.

Menu 
1 - Cadastrar criptomoeda 
2 - Listar criptomoedas
3 - Remover criptomoeda
4 - Sair
Opção: 
*/

/*List<string> cryptos = new List<string>();

while (true)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1 - Cadastrar criptomoeda");
    Console.WriteLine("2 - Listar criptomoedas");
    Console.WriteLine("3 - Remover criptomoeda");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Opção: ");
    int opcao = int.Parse(Console.ReadLine());
    
    if (opcao == 1)
    {
        Console.WriteLine("Informe o nome da crypto");
        string crypto = Console.ReadLine().ToUpper();
        if(!cryptos.Contains(crypto))
        {
            cryptos.Add(crypto);
        }
        else
        {
            Console.WriteLine("Esta criptomoeda já está cadastrada");
        }
    }

    else if (opcao == 2)
    {
        foreach (var crypto in cryptos)
        {
            Console.Write(crypto+" | ");
        }

        Console.WriteLine("");
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Informe o nome da crypto");
        string crypto = Console.ReadLine().ToUpper();
        if(cryptos.Contains(crypto))
        {
            cryptos.Remove(crypto);
            Console.WriteLine("Esta criptomoeda foi removida com sucesso!");
        }
        else
        {
            Console.WriteLine("ERRO! Esta criptomoeda não existe");
        }
    }
    else
    {
        return;
    }
    cryptos.Sort();
}*/



/*
5. Crie um programa em VS que popule duas listas (lista1 e lista2) com números aleatórios (100 a 200).
A quantidade de números deve ser informada pelo usuário. Em seguida, o programa deve listar os 
conteúdos das duas listas e exibir os números que aparecem em ambas as listas.
*/
/*
Random rnd = new Random();
List<int> lista1 = new List<int>();
List<int> lista2 = new List<int>();

Console.WriteLine("Informe a quantidade de numeros para preencher a lista");
int qtd = int.Parse(Console.ReadLine());
for (int i = 0; i < qtd; i++)
{
    lista1.Add(rnd.Next(100,200));
    lista2.Add(rnd.Next(100,200));
}
for (int i = 100; i < 200; i++)
{
    if(lista1.Contains(i) && lista2.Contains(i)) Console.Write(i+" | ");
}
*/

/*
6. Continuação do exercício 1. Entretanto, quando listar os nomes, mostrar somente os sobrenomes.
Além disso, o programa deve mostrar as pessoas que são da mesma família.
*/
/*List<string> nomes = new List<string>();
do
{
    Console.WriteLine("Informe um nome");
    Console.WriteLine("Para sair digite 'sair'");
    string nome = Console.ReadLine();
    string[] nomeCompleto = nome.Split(" ");

    if (nome == "sair") break;
    if (nomeCompleto.Length < 2)
    {
        Console.WriteLine("O nome deve conter no mínimo duas palavras");
    }
    if (nomes.Contains(nome.ToUpper()))
    {
        Console.WriteLine("Este nome já está cadastrado!");
    }
    else
    {
        nomes.Add(nome.Split(" ")[1].ToUpper());
        nomes.Sort();
    }
} while (true);

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}*/
