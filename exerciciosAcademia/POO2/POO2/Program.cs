using POO2.Classes;
using POO2.Herança;

/*
// 1
Console.WriteLine("Informe o titulo do livro");
string titulo = Console.ReadLine();
Console.WriteLine("Informe o autor do livro");
string autor = Console.ReadLine();
Console.WriteLine("Informe a editora do livro");
string editora = Console.ReadLine();
Console.WriteLine("Informe o genero do livro");
string genero = Console.ReadLine();
Console.WriteLine("Informe o ano de publicação do livro");
int ano = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a edição do livro");
int edicao = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o número de páginas do livro");
int paginas = int.Parse(Console.ReadLine());

Livro livro = new Livro(titulo, autor, editora, genero, ano, edicao, paginas);
livro.getInfos();
*/

/*
// 2
Console.WriteLine("Informe o nome");
string nome = Console.ReadLine();
Console.WriteLine("Informe o sobrenome");
string sobrenome = Console.ReadLine();
Console.WriteLine("Informe o genero");
string genero = Console.ReadLine();
Console.WriteLine("Informe o email");
string email = Console.ReadLine();
Console.WriteLine("Informe a idade");
int idade = int.Parse(Console.ReadLine());

Pessoa pessoa = new Pessoa(nome, sobrenome, email, genero, idade);
pessoa.getInfos();*/

// 3
/*Cliente cliente = new Cliente("Rafael", 4);
Carro carro = new Carro("Civic VTI 1993", "azul", "1337", "Honda", 131);
Aluguel aluguel = new Aluguel(cliente, carro);
aluguel.alugar();*/

// 4
/*PessoaArvore pai = new PessoaArvore("Kanye", "West", "Pai");
PessoaArvore mae = new PessoaArvore("Kim", "Kardashian","Mãe");
PessoaArvore filho = new PessoaArvore("Saint", "West", "Filho");
ArvoreGenealogica arvore = new ArvoreGenealogica(filho, pai, mae);
arvore.ImprimirArvore();*/

// 5

/*Produto produto1 = new Produto("Arroz", 10, 10);
Produto produto2 = new Produto("Feijão", 10, 10);
Produto produto3 = new Produto("Macarrão", 10, 10);
Produto produto4 = new Produto("Carne", 30, 10);

List<Produto> produtos = new List<Produto>();
produtos.Add(produto1);
produtos.Add(produto2);
produtos.Add(produto3);
produtos.Add(produto4);

Pedido pedido = new Pedido("Rafael", "dinheiro", produtos);
pedido.getPedido();*/

// 6
/*PessoaAgenda pessoa1 = new PessoaAgenda("Rafael", 19, 1.75);
PessoaAgenda pessoa2 = new PessoaAgenda("João", 20, 1.80);
PessoaAgenda pessoa3 = new PessoaAgenda("Maria", 21, 1.65);
PessoaAgenda pessoa4 = new PessoaAgenda("José", 22, 1.70);
PessoaAgenda pessoa5 = new PessoaAgenda("Ana", 23, 1.60);
Agenda agenda = new Agenda();

agenda.armazenaPessoa(pessoa1);
agenda.armazenaPessoa(pessoa2);
agenda.armazenaPessoa(pessoa3);
agenda.removePessoa(pessoa2);
agenda.imprimeAgenda();
agenda.buscaPessoa("Rafael");
agenda.armazenaPessoa(pessoa4);
agenda.armazenaPessoa(pessoa5);
agenda.imprimeAgenda();*/

// 7
/*Elevador elevador = new Elevador(10, 10);
elevador.Imprimir();
elevador.Entrar();
elevador.Entrar();
elevador.Entrar();
elevador.Entrar();
elevador.Subir();
elevador.Subir();
elevador.Sair();
elevador.Descer();
elevador.Entrar();
elevador.Imprimir();*/

// 8
/*Televisao tv = new Televisao();
ControleRemoto controle = new ControleRemoto();

controle.consultar(tv);
controle.aumentarVolume(tv);
controle.aumentarVolume(tv);
controle.aumentarVolume(tv);
controle.aumentarVolume(tv);
controle.trocarCanal(tv, 37);
controle.aumentarCanal(tv);
Console.WriteLine("----------------");
controle.consultar(tv);*/

/*Animal leao = new Leao("Leao", "Macho", "Sla");
leao.Caminhar();
leao.Dormir();
leao.EmitirSom();
leao.MostrarDados();*/