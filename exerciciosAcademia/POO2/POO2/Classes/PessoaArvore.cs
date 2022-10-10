namespace POO2.Classes;

public class PessoaArvore
{
    private string nome;
    private string sobrenome;
    private string parentesco;
    
    public PessoaArvore(string nome, string sobrenome, string parentesco)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.parentesco = parentesco;
    }
    
    public string NomeCompleto()
    {
        return nome + " " + sobrenome;
    }
}