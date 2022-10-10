namespace POO2.Classes;

public class Elevador
{
    public int terreo = 0;
    public int andarAtual { get; set; }
    public int totalAndares { get; }
    public int capacidade { get; }
    public int pessoasPresentes { get; set; }
    
    public Elevador(int totalAndares, int capacidade)
    {
        this.totalAndares = totalAndares;
        this.capacidade = capacidade;
    }
    
    public void Entrar()
    {
        if (pessoasPresentes < capacidade)
        {
            pessoasPresentes++;
        }
        else
        {
            Console.WriteLine("Elevador lotado!");
        }
    }
    
    public void Sair()
    {
        if (pessoasPresentes > 0)
        {
            pessoasPresentes--;
        }
        else
        {
            Console.WriteLine("Elevador vazio!");
        }
    }
    
    public void Subir()
    {
        if (andarAtual < totalAndares)
        {
            andarAtual++;
        }
        else
        {
            Console.WriteLine("Elevador no último andar!");
        }
    }
    
    public void Descer()
    {
        if (andarAtual > terreo)
        {
            andarAtual--;
        }
        else
        {
            Console.WriteLine("Elevador no térreo!");
        }
    }
    
    public void Imprimir()
    {
        Console.WriteLine("Andar atual: " + andarAtual);
        Console.WriteLine("Pessoas presentes: " + pessoasPresentes);
    }
}