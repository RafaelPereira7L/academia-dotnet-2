namespace POO2.Classes;

public class Carro
{
    public string modelo { get; }
    private string cor;
    public string placa { get; }
    public string fabricante { get; }
    public double custoAluguel { get; }

    public Carro(string modelo, string cor, string placa, string fabricante, double custoAluguel)
    {
        this.modelo = modelo;
        this.cor = cor;
        this.placa = placa;
        this.fabricante = fabricante;
        this.custoAluguel = custoAluguel;
    }
}