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

        /*Console.WriteLine("Informe a agencia");
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
        conta.exibirDados();*/

        /*Carro carro = new Carro();
        carro.ligar();
        Console.WriteLine(carro.getLigado());
        carro.desligar();
        Console.WriteLine(carro.getLigado());
        carro.setCor("amarillo");
        Console.WriteLine(carro.getCor());*/


        /*Console.WriteLine("Digite uma temperatura em Fº");
        Temperatura temp = new Temperatura();
        temp.setCelsius(Double.Parse(Console.ReadLine()));
        Console.WriteLine(temp.getCelsius());*/
        /*Cliente cliente = new Cliente("Rafael", 19);
        Conta acc = new Conta(cliente, 1337, "Corrente");
        while(true)
        {
            Console.WriteLine("Digite 1 para sacar, 2 para depositar, 3 para consultar saldo, 0 para sair");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite o valor do saque");
                    acc.debitar(double.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Digite o valor do deposito");
                    acc.creditar(double.Parse(Console.ReadLine()));
                    break;  
                case 3:
                    Console.WriteLine(acc.getSaldo());
                    break;
                default:
                    Console.WriteLine("O cliente "+cliente.nome+" possui saldo de "+acc.getSaldo());
                    return;  
            }
        }
        */
        
        Cliente cliente = new Cliente("Rafael");
        CarroAluguel carro = new CarroAluguel("Civic VTI 1993", "azul", "1337", "Honda");
        Aluguel aluguel = new Aluguel(cliente, carro);
        cliente.diasAluguel = 2;
        carro.custoAluguel = 150;
        aluguel.alugar();
    }
}