namespace POO3.Classes;

public class Playstation : Eletronico
{
    public override void Ligar()
    {
        Console.WriteLine("Ligando Playstation");
        Ligado = true;
    }
}