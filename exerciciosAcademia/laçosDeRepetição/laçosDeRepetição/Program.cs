int contador=0;
Console.WriteLine("Insira um numero");
int num = int.Parse(Console.ReadLine());
while (num >= 0)
{
    Console.WriteLine("Insira um numero");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        contador++;
        Console.WriteLine(contador+" numeros pares");
    }
}
