namespace POO;

internal class Aviao
{
    public string modelo;
    public double velocidade;
    public double altitude;
    public string marca;

    public void acelerar()
    {
        velocidade += 10;
        Console.WriteLine("Acelerando -> "+velocidade);
    }

    public void reduzir()
    {
        velocidade -= 10;
        Console.WriteLine("Reduzindo -> "+velocidade);

    }
    public void subir()
    {
        altitude += 100;
        Console.WriteLine("Subindo -> "+altitude);

    }    
    public void descer()
    {
        altitude -= 100;
        Console.WriteLine("Descendo -> "+altitude);
    }
}