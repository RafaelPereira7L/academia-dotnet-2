/*StreamWriter writer = new StreamWriter("E:\\Repositorios\\Academia-dotnet\\atosUfn.txt", true);*/
//Nome, idade, sexo, email, telefone, estado civil, casa propria ou não, valor aluguel
//Gerar um arquivo, utilizando o ; como caractere delimitador para cada uma dessas informações.
//Todas as informações, ficam na mesma linha - cada linha é uma pessoa
//apenas nome, idade e casa propria são campos obrigatórios
//EXEMPLO
//Rafael;19;;;;;sim;0

/*string nome = "";
int idade = 0;
string casaPropria = "";
double valorAluguel = 0;


try
{
    Console.WriteLine("Digite o nome (obrigatório)");
    nome = Console.ReadLine();
    if(nome == "")
    {
        throw new Exception("Nome é obrigatório");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}

try
{
    Console.WriteLine("Digite a idade (obrigatório)");
    idade = int.Parse(Console.ReadLine());
    if(idade == 0)
    {
        throw new Exception("Idade é obrigatório");
    }
} catch (Exception e)
{
    Console.WriteLine(e);
}

    Console.WriteLine("Digite o sexo (opcional)");
    string sexo = Console.ReadLine();

    Console.WriteLine("Digite o email (opcional)");
    string email = Console.ReadLine();


    Console.WriteLine("Digite o telefone (opcional)");
    string telefone = Console.ReadLine();

    Console.WriteLine("Digite o estado civil (opcional)");
    string estadoCivil = Console.ReadLine();


try
{
    Console.WriteLine("Digite se possui casa própria - sim ou não (obrigatório)");
    casaPropria = Console.ReadLine();
    if(casaPropria == "")
    {
        throw new Exception("Casa própria é obrigatório");
    }
    if(casaPropria == "não" || casaPropria == "nao" || casaPropria == "Nao" || casaPropria == "Não")
    {
        Console.WriteLine("Digite o valor do aluguel (obrigatório)");
        valorAluguel = double.Parse(Console.ReadLine());
    }

} catch (Exception e)
{
    Console.WriteLine(e);
}

writer.WriteLine(nome+";"+idade+";"+sexo+";"+email+";"+telefone+";"+estadoCivil+";"+casaPropria+";"+valorAluguel);
writer.Close();*/

//exemplo 2

Console.WriteLine("Informe o nome");
string nome = Console.ReadLine();

Console.WriteLine("Informe a idade");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o sexo");
string sexo = Console.ReadLine();

Console.WriteLine("Informe o email");
string email = Console.ReadLine();

Console.WriteLine("Informe o fone");
string fone = Console.ReadLine();

Console.WriteLine("Informe o estado civil");
string estado = Console.ReadLine();

Console.WriteLine("Tem casa propria? (1 = SIM, 2 = NÃO");
int casa = int.Parse(Console.ReadLine());

double aluguel = 0;
if (casa == 2)
{
    Console.WriteLine("Informe o aluguel");
    aluguel = double.Parse(Console.ReadLine());
}

List<string> linhas = new List<string>();

if (File.Exists("E:\\Repositorios\\Academia-dotnet\\exemplo2.txt"))
{
    StreamReader reader = new StreamReader("E:\\Repositorios\\Academia-dotnet\\exemplo2.txt");


    linhas.Add(reader.ReadLine());

    string linha = "";

    while (linha != null)
    {
        linha = reader.ReadLine();

        if (linha != null)
            linhas.Add(linha);
    }

    reader.Close();

}

linhas.Add(nome + ";" + idade + ";" + sexo + ";" + email + ";" + fone + ";" + estado + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel);

StreamWriter writer = new StreamWriter("E:\\Repositorios\\Academia-dotnet\\exemplo2.txt");

foreach (string item in linhas)
{
    writer.WriteLine(item);
}

writer.Close();