namespace POO2.Classes;

public class ArvoreGenealogica
{
    private PessoaArvore filho;
    private PessoaArvore pai;
    private PessoaArvore mae;
    
    public ArvoreGenealogica(PessoaArvore filho, PessoaArvore pai, PessoaArvore mae)
    {
        this.filho = filho;
        this.pai = pai;
        this.mae = mae;
    }
    
    public void ImprimirArvore()
    {
        Console.WriteLine("Pai: " + pai.NomeCompleto());
        Console.WriteLine("Mãe: " + mae.NomeCompleto());
        Console.WriteLine("Filho: " + filho.NomeCompleto());
    }
}