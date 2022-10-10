namespace POO2.Classes;

public class Livro
{
    private string titulo;
    private string autor;
    private string editora;
    private string genero;
    private int ano;
    private int edicao;
    private int paginas;
    
    public Livro(string titulo, string autor, string editora, string genero, int ano, int edicao, int paginas)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.editora = editora;
        this.genero = genero;
        this.ano = ano;
        this.edicao = edicao;
        this.paginas = paginas;
    }
    
    public void getInfos()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Editora: " + editora);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Edição: " + edicao);
        Console.WriteLine("Páginas: " + paginas);
    }
}