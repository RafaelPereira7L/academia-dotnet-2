namespace exerciciosOO8.Classes;

public class Animal
{
    private string nome;
    private string tipo;

    public string Nome
    {
        get => nome;
        set => nome = value;
    }

    public string Tipo
    {
        get => tipo;
        set => tipo = value;
    }
    
    public void GetDados()
    {
        Console.WriteLine("Nome: " + nome + " Tipo: " + tipo);
    }
}