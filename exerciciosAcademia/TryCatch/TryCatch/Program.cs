try
{
    int x;
    Console.WriteLine("Informe um número: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine("O número informado foi: " + x);
    Console.WriteLine("O valor 50 dividido por "+ x + " é igual a: " + 50 / x);
}
catch(DivideByZeroException)
{
    Console.WriteLine("Não é possível dividir por zero!");
}
catch(FormatException)
{
    Console.WriteLine("O valor informado não é um número!");
}
catch(OverflowException)
{
    Console.WriteLine("O número informado é muito grande!");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro inesperado: "+e);
}
finally
{
    Console.WriteLine("Fim do programa!");
}