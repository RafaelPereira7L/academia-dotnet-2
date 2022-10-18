namespace exerciciosOO8.Classes;

public class Personagem
{
    public string Nome { get; }
    public int Poder { get; }

    public Personagem()
    {
        Nome = " ";
        Poder = 0;
    }
    
    public Personagem(string nome, int poder)
    {
        Nome = nome;
        Poder = poder;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome+ " Poder: " + Poder);
    }
}