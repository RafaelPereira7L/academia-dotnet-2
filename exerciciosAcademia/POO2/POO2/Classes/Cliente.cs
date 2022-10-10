namespace POO2.Classes;

public class Cliente
{
    public string nome { get; }
    public int diasAluguel { get; }

    public Cliente(string nome, int diasAluguel)
    {
        this.nome = nome;
        this.diasAluguel = diasAluguel;
    }
}