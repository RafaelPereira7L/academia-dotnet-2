namespace POO2.Classes;

public class Pessoa
{
    private string nome;
    private string sobrenome;
    private string email;
    private string genero;
    private int idade;
    
    public Pessoa(string nome, string sobrenome, string email, string genero, int idade) 
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.email = email;
        this.genero = genero;
        this.idade = idade;
    }
    
    public void getInfos() 
    {
        Console.WriteLine("Nome Completo: "+nome+" "+sobrenome);
        Console.WriteLine("Email: " +email);
        Console.WriteLine("Genero: " +genero);
        Console.WriteLine("Idade: " +idade);
    }
}