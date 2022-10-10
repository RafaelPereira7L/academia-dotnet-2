namespace POO2.Classes;

public class Agenda
{
    private List<PessoaAgenda> pessoas = new List<PessoaAgenda>();
    
    public void armazenaPessoa(PessoaAgenda pessoa)
    {
        pessoas.Add(pessoa);
    }
    
    public void removePessoa(PessoaAgenda pessoa)
    {
        pessoas.Remove(pessoa);
    }
    
    public void buscaPessoa(String nome)
    {
        for (int i = 0; i < pessoas.Count; i++)
        {
            if (pessoas[i].getNome().Equals(nome))
            {
                Console.WriteLine("Nome: " + pessoas[i].getNome()+ " Posição: " + i);
            }
        }
    }
    
    public void imprimeAgenda()
    {
        foreach (var pessoa in pessoas)
        {
            pessoa.getDados();
        }
    }
}   