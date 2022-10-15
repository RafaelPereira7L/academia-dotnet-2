using POO3.Interfaces;

namespace POO3.ClassesInterfaces;

public class Televisao : IEletronico
{
    private int _volts;
    private int _potencia;
    private bool _ligado;

    public bool Ligado
    {
        get => _ligado;
        set => _ligado = value;
    }
    
    
    public void Ligar()
    {
        Console.WriteLine("Ligando a TV");
        _ligado = true;
    }

    public void Desligar()
    {
        Console.WriteLine("Desligando a TV");
        _ligado = false;
    }
    
    public bool VerificaLigado()
    {
        return _ligado;
    }
}
