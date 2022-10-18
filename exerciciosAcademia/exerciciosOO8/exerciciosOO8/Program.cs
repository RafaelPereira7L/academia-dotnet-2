using exerciciosOO8.Classes;

//1
/*
int counter = 0;
string nomeMaiorPoder = "";
int maior = 0;
List<Personagem> personagens = new List<Personagem>();

while(counter <3)
{
    Console.WriteLine("Informe o nome do personagem");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe o poder do personagem");
    int poder = int.Parse(Console.ReadLine());
    if(poder < 0 || poder > 10)
    {
        Console.WriteLine("Poder inválido");
        break;
    }
    personagens.Add(new Personagem(nome, poder));
    counter++;
}

foreach(var personagem in personagens)
{
    personagem.ExibirDados();
    if (personagem.Poder > maior)
    {
        nomeMaiorPoder = personagem.Nome;
        maior = personagem.Poder;
    }
}

Console.WriteLine("O personagem com maior poder é: " + nomeMaiorPoder + " com " + maior + " de poder");
*/

//2
/*int counter = 0;
List<Animal> animais = new List<Animal>();
Animal animal = new Animal();

while (counter <5)
{
    Console.WriteLine("Informe o nome do animal");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe o tipo do animal");
    string tipo = Console.ReadLine();

    if (tipo == "cachorro")
    {
        animal.Nome = nome;
        animal.Tipo = tipo;
        animais.Add(animal);
        counter++;
    }
    else if (tipo == "gato")
    {
        animal.Nome = nome;
        animal.Tipo = tipo;
        animais.Add(animal);

        counter++;
    }
    else if (tipo == "peixe")
    {
        animal.Nome = nome;
        animal.Tipo = tipo;
        animais.Add(animal);

        counter++;
    } else
    {
        Console.WriteLine("Tipo inválido");
    }
}

foreach(var anAnimal in animais)
{
    anAnimal.GetDados();
}*/

//3 
/*List<Asteroide> asteroides = new List<Asteroide>();
Asteroide asteroide = new Asteroide();
Console.WriteLine("Insira a posição x do asteroide");
asteroide.Posicao_x = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a posição y do asteroide");
asteroide.Posicao_y = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o tamanho do asteroide");
asteroide.Tamanho = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a velocidade do asteroide");
asteroide.Velocidade = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a energia do asteroide");
asteroide.Energia = int.Parse(Console.ReadLine());
asteroides.Add(asteroide);*/


// 4
/*Item item = new Item();

Console.WriteLine("Informe a descricao do item");
string descricao = Console.ReadLine();
item.Descricao = descricao;
Console.WriteLine("Informe a data de criação do item");
DateTime dataDeCriacao = DateTime.Parse(Console.ReadLine());
item.DataDeCriacao = dataDeCriacao;
Console.WriteLine("Informe a altura do item");
float altura = float.Parse(Console.ReadLine());
item.Altura = altura;
item.ExibirItem();
item.Age();*/



// 5
/*List<PlanoCartesiano> objetos = new List<PlanoCartesiano>();
PlanoCartesiano objeto = new PlanoCartesiano(10, 10);
PlanoCartesiano objeto1 = new PlanoCartesiano(11, 14);
PlanoCartesiano objeto2 = new PlanoCartesiano(12, 15);
PlanoCartesiano objeto3 = new PlanoCartesiano(13, 16);
objetos.Add(objeto);
objetos.Add(objeto1);
objetos.Add(objeto2);
objetos.Add(objeto3);

foreach(var obj in objetos)
{
    obj.Mostrar();
}*/



//6
/*
List<Funcionario> func = new List<Funcionario>();
int opc;
    do
    {
    Console.WriteLine(" === Bem-vindo ao sistema de funcionários === \n");
    Console.WriteLine("1 - Registrar um novo funcionário");
    Console.WriteLine("2 - Exibir todos os funcionários");
    Console.WriteLine("3 - Bonificar um funcionário");
    Console.WriteLine("4 - Demitir um funcionário");
    Console.WriteLine("5 - Encerrar");
    Console.Write("\nOpção: ");
        opc = int.Parse(Console.ReadLine());
        switch (opc)
        {
        case 1:
            Console.Write("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write($"Informe o departamento do funcionário '{nome}': ");
            string departamento = Console.ReadLine();
            Console.Write($"Informe o salário do funcionário '{nome}': ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write($"Informe a data de entrada do funcionário '{nome}' \n(01/01/2022) ou pressione Enter para a data de hoje: ");
            string data = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(data))
            {
                data = DateTime.Now.ToShortDateString();
            }
            Console.Write($"Informe o RG do funcionário '{nome}': ");
            string rg = Console.ReadLine();
            func.Add(new Funcionario(nome, departamento, salario, data, rg, true));
            Console.WriteLine($"\n'{nome}' cadastrado com sucesso!\n");
            break;
        case 2:
            Console.Clear();
            foreach (var f in func)
            {
                Console.WriteLine($"Funcionário: {f.Nome}  |  Departamento: {f.Departamento}  |  Salário: {f.Salario:C}");
                Console.Write($"Contratado em: {f.DataEntrada}  |  RG: {f.Rg}  |  ");
                if (f.Ativo)
                {
                    Console.WriteLine($"Situação atual: 'Admitido'");
                }
                else
                {
                    Console.WriteLine($"Situação atual: 'Demitido'");
                }
                Console.WriteLine();
            }
            break;
        case 3:
            break;
        }
} while (opc != 5);
*/

//7
/*IDictionary<string, int> livros = new Dictionary<string, int>();
int opt=0;
do
{
    Console.WriteLine("1 - Adicionar livro");
    Console.WriteLine("2 - Remover livro");
    Console.WriteLine("3 - Exibir todos os livros");
    Console.WriteLine("4 - Pesquisar livro por nome");
    Console.WriteLine("0 - Sair");
    opt = int.Parse(Console.ReadLine());
    
    switch (opt)
    {
        case 1:
            Console.WriteLine("Informe o nome do livro");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o numero de paginas do livro");
            int paginas = int.Parse(Console.ReadLine());
            livros.Add(nome, paginas);
            break;
        case 2:
            Console.WriteLine("Informe o nome do livro");
            string nome1 = Console.ReadLine();
            livros.Remove(nome1);
            break;
        case 3:
            foreach(var livro in livros)
            {
                Console.WriteLine($"Nome: {livro.Key} | Preço: {livro.Value}");
            }
            break;
        case 4:
            Console.WriteLine("Informe o nome do livro");
            string nome2 = Console.ReadLine();
            if (livros.ContainsKey(nome2))
            {
                Console.WriteLine($"Nome: {nome2} | Preço: {livros[nome2]}");
            }
            else
            {
                Console.WriteLine("Livro não encontrado");
            }
            break;
    }

} while(opt != 0);*/

