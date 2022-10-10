namespace POO2.Classes;

public class PessoaAgenda
{
    private string nome;
    private int idade;
    private double altura;
    
    public PessoaAgenda(string nome, int idade, double altura)
    {
        this.nome = nome;
        this.idade = idade;
        this.altura = altura;
    }
    
    public string getNome()
    {
        return nome;
    }

    public void getDados()
    {
        Console.WriteLine("Nome: "+nome + " Idade: "+idade + " Altura: "+altura); 
    }
}