namespace POO3.Classes;

public class Televisao : Eletronico
{
    public override void Ligar()
    {
        Console.WriteLine("Ligando a TV");
        Ligado = true;
    }
}