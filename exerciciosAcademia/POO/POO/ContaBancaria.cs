namespace POO;

internal class ContaBancaria
{
    private string agencia;
    private string tipo;
    private double valor;
    private string conta;

    public ContaBancaria(string agencia, string tipo, double valor, string conta)
    {
        this.agencia = agencia;
        this.conta = conta;
        this.valor = valor;
        this.tipo = tipo;
    }
    public void sacar(double saque)
    {
        valor -= saque;
        Console.WriteLine("Saque efetuado. O saldo é "+valor);
    }
    public void depositar(double deposito)
    {
        valor += deposito;
        Console.WriteLine("Deposito efetuado. O saldo é "+valor);
    }
    public void transferir(double transferencia)
    {
        valor -= transferencia;
        Console.WriteLine("Transferencia efetuada. O saldo é "+valor);
    }

    public void exibirDados()
    {
        Console.WriteLine("Agencia "+agencia);
        Console.WriteLine("Conta "+conta);
        Console.WriteLine("Tipo "+tipo);
        Console.WriteLine("Valor "+valor);
    }
}