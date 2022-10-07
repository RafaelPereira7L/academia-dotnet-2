namespace POO;

internal class Lampada
{
    private bool ligada;
    private double potencia;

    public void ligar()
    {
        ligada = true;
        Console.WriteLine("Ligando lâmpada!");
    }

    public void desligar()
    {
        ligada = false;
        Console.WriteLine("Desligando lâmpada!");
    }

    public bool estaLigada()
    {
        return ligada;
    }
}