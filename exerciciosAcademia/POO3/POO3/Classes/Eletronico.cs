namespace POO3.Classes;

public abstract class Eletronico
{
    private int _volts;
    private int _potencia;
    private bool _ligado;

    public bool Ligado
    {
        get => _ligado;
        set => _ligado = value;
    }
    public abstract void Ligar();
    
    public void Desligar()
    {
        _ligado = false;
        Console.WriteLine("Desligando o equipamento");
    }

    public bool VerificaLigado()
    {
        return _ligado;
    }
}