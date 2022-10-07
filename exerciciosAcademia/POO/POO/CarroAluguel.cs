namespace POO;

internal class CarroAluguel
{
    public string modelo { get; }
    private string cor;
    public string placa { get; }
    public string fabricante { get; }
    public double custoAluguel { get; set; }

    public CarroAluguel(string modelo, string cor, string placa, string fabricante)
    {
        this.modelo = modelo;
        this.cor = cor;
        this.placa = placa;
        this.fabricante = fabricante;
    }
}