namespace POO2.Herança;

public abstract class Animal
{
    protected string nome;
    protected string sexo;
    protected string raça;

    public Animal(string nome, string sexo, string raça)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.raça = raça;

    }

    public abstract void EmitirSom();

    public abstract void Dormir();

    public abstract void Caminhar();
    
    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Raça: " + raça);
    }
}