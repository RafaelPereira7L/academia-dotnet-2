namespace POO3.Classes;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(int idade, string nome)
    {
        this.Idade = idade;
        this.Nome = nome;
    }
}