namespace POO2.Classes;

public class Produto
{
    private string nome;
    private double preco;
    private int quantidade;
    
    public Produto(string nome, double preco, int quantidade)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidade = quantidade;
    }

    public string getProduto()
    {
        return "Produto: " + nome+ ", Preço: " + preco + ", Quantidade: " + quantidade;
    }
}