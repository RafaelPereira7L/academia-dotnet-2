namespace POO2.Classes;

public class Pedido
{
    private string nomeCliente;
    private string tipoPagamento;
    private List<Produto> produtos;
    
    public Pedido(string nomeCliente, string tipoPagamento, List<Produto> produtos)
    {
        this.nomeCliente = nomeCliente;
        this.tipoPagamento = tipoPagamento;
        this.produtos = produtos;
    }

    public void getPedido()
    {
        Console.WriteLine("Nome do cliente: " + nomeCliente);
        Console.WriteLine("Tipo de pagamento: " + tipoPagamento);
        Console.WriteLine("Produtos ↓ ");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto.getProduto());
        }
    }
}