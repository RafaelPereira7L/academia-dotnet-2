namespace POO2.Herança;

public class Leao : Animal
{
    public Leao(string nome, string sexo, string raça) : base(nome, sexo, raça){}

    public override void EmitirSom()
    {
        Console.WriteLine("Rugido");
    }
    
    public override void Dormir() 
    {
        Console.WriteLine("Dormindo");
    }
    
    public override void Caminhar()
    {
        Console.WriteLine("Caminhando");
    }

}