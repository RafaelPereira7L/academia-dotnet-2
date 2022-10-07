namespace POO;

internal class Aluguel
{
    private Cliente cliente;
    private CarroAluguel carro;
    public Aluguel(Cliente cliente, CarroAluguel carro)
    {
        this.cliente = cliente;
        this.carro = carro;
    }

    public double totalAluguel()
    {
        return cliente.diasAluguel * carro.custoAluguel;
    }
    public void alugar()
    {
     Console.WriteLine("O cliente "+cliente.nome+" alugou o carro modelo "+carro.fabricante+" "+carro.modelo+" de placa "+carro.placa+" pelo valor de: "+totalAluguel()+" reais");
    }
}