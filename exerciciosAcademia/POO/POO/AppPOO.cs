namespace POO;

public class AppPOO
{
    static void Main(string[] args)
    {
        Console.WriteLine("Apresentando Classes, objetos, métodos e orientação a objetos básica");
        /*Lampada l1 = new Lampada();
        l1.ligar();
        Console.WriteLine("Status da Lâmpada: "+l1.estaLigada());
        l1.desligar();
        Console.WriteLine("Status da Lâmpada: "+l1.estaLigada());*/

        /*Aviao airplane1 = new Aviao();
        airplane1.marca = "Airplane1337";
        airplane1.modelo = "Random Model";
        airplane1.altitude = 1337;
        airplane1.velocidade = 999;
        airplane1.acelerar();
        airplane1.reduzir();
        airplane1.subir();
        airplane1.descer();*/

        Console.WriteLine("Informe a agencia");
        string agencia = Console.ReadLine();
        Console.WriteLine("Informe o tipo");
        string tipo = Console.ReadLine();
        Console.WriteLine("Informe o valor");
        double valor = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a conta");
        string contaBancaria = Console.ReadLine();        
        
        ContaBancaria conta = new ContaBancaria(agencia, tipo, valor, contaBancaria);
        conta.depositar(100);
        conta.sacar(200);
        conta.transferir(350);
        conta.exibirDados();
    }
}