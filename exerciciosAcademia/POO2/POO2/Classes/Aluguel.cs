namespace POO2.Classes;

public class Aluguel
{
    private Cliente cliente;
    private Carro carro;
    public Aluguel(Cliente cliente, Carro carro)
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
        Console.WriteLine("O cliente "+cliente.nome+" alugou o carro modelo "+carro.fabricante+" "+carro.modelo+" de placa "+carro.placa);
        Console.WriteLine("O "+carro.modelo+" foi alugado por "+cliente.diasAluguel+" dias pelo valor total de "+totalAluguel()+" reais");
    }
}