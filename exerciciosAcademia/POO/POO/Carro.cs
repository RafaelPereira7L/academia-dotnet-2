namespace POO;

internal class Carro
{
    private double velocidadeMax;
    private string modelo;
    private string cor;
    private string placa;
    private string fabricante;
    private bool ligado = false;

    public bool getLigado()
    {
        return ligado;
    }

    public string getCor()
    {
        return cor;
    }

    public void setCor(string cor)
    {
        this.cor = cor;
    }
    
    
    public void ligar()
    {
        ligado = true;
        Console.WriteLine("O carro foi ligado");
    }

    public void desligar()
    {
        ligado = false;
        Console.WriteLine("O carro foi desligado");
    }
}