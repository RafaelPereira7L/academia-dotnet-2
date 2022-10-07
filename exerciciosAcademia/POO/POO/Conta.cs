namespace POO;

internal class Conta
{
    private Cliente cliente;
    private double saldo = 0;
    private string tipo = "corrente";

    public Conta(Cliente cliente, double saldo, string tipo)
    {
        this.cliente = cliente;
        this.saldo = saldo;
        this.tipo = tipo;
    }

    public void creditar(double valor)
    {
        saldo += valor;
        Console.WriteLine("Creditado "+valor);
    }
    
    public void debitar(double valor)
    {
        saldo -= valor;
        Console.WriteLine("Debitado "+valor);
    }

    public double getSaldo()
    {
        return saldo;
    }
}