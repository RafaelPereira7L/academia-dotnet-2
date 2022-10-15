namespace POO3.Classes;

public class Celular : Eletronico
{
    public override void Ligar()
    {
        Console.WriteLine("Ligando o celular");
        Ligado = true;
    }
}