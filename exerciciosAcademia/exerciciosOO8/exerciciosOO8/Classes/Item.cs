namespace exerciciosOO8.Classes;

public class Item
{
    private string descricao;
    private DateTime dataDeCriacao;
    private float altura;

    public string Descricao
    {
        get => descricao;
        set => descricao = value;
    }

    public DateTime DataDeCriacao
    {
        get => dataDeCriacao;
        set => dataDeCriacao = value;
    }

    public float Altura
    {
        get => altura;
        set => altura = value;
    }

    public Item() {}
    
    public void ExibirItem()
    {
        Console.WriteLine("Descrição: " + descricao);
        Console.WriteLine("Data de criação: " + dataDeCriacao);
        Console.WriteLine("Altura: " + altura);
    }

    public void Age()
    {
        Console.WriteLine("O item foi criado há " + (DateTime.Now - dataDeCriacao).Days + " dias.");
    }
}